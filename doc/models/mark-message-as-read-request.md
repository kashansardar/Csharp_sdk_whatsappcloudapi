
# Mark Message as Read Request

## Structure

`MarkMessageAsReadRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MessagingProduct` | `string` | Required | Messaging service used for the request. Use 'whatsapp'. |
| `Status` | `string` | Required | A message's status. You can use this field to mark a message as read. |
| `MessageId` | `string` | Required | Id of the incoming message. |

## Example (as JSON)

```json
{
  "messaging_product": "whatsapp",
  "status": "read",
  "message_id": "incoming-message-id"
}
```

