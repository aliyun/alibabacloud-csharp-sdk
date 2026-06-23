// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SMQProxy20260409.Models;

namespace AlibabaCloud.SDK.SMQProxy20260409
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "SMQProxy";
            AlibabaCloud.GatewayMns.Client gatewayClient = new AlibabaCloud.GatewayMns.Client();
            this._spi = gatewayClient;
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "mns.cn-hangzhou.aliyuncs.com"},
            };
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteMessageResponse
        /// </returns>
        public BatchDeleteMessageResponse BatchDeleteMessageWithOptions(string queueName, BatchDeleteMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandles))
            {
                body["ReceiptHandles"] = request.ReceiptHandles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteMessageResponse
        /// </returns>
        public async Task<BatchDeleteMessageResponse> BatchDeleteMessageWithOptionsAsync(string queueName, BatchDeleteMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandles))
            {
                body["ReceiptHandles"] = request.ReceiptHandles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteMessageResponse
        /// </returns>
        public BatchDeleteMessageResponse BatchDeleteMessage(string queueName, BatchDeleteMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteMessageResponse
        /// </returns>
        public async Task<BatchDeleteMessageResponse> BatchDeleteMessageAsync(string queueName, BatchDeleteMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPeekMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPeekMessageResponse
        /// </returns>
        public BatchPeekMessageResponse BatchPeekMessageWithOptions(string queueName, BatchPeekMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfMessages))
            {
                query["numOfMessages"] = request.NumOfMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Peekonly))
            {
                query["peekonly"] = request.Peekonly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPeekMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPeekMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPeekMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchPeekMessageResponse
        /// </returns>
        public async Task<BatchPeekMessageResponse> BatchPeekMessageWithOptionsAsync(string queueName, BatchPeekMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfMessages))
            {
                query["numOfMessages"] = request.NumOfMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Peekonly))
            {
                query["peekonly"] = request.Peekonly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchPeekMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchPeekMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPeekMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPeekMessageResponse
        /// </returns>
        public BatchPeekMessageResponse BatchPeekMessage(string queueName, BatchPeekMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchPeekMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchPeekMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchPeekMessageResponse
        /// </returns>
        public async Task<BatchPeekMessageResponse> BatchPeekMessageAsync(string queueName, BatchPeekMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchPeekMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchReceiveMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchReceiveMessageResponse
        /// </returns>
        public BatchReceiveMessageResponse BatchReceiveMessageWithOptions(string queueName, BatchReceiveMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfMessages))
            {
                query["numOfMessages"] = request.NumOfMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Waitseconds))
            {
                query["waitseconds"] = request.Waitseconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchReceiveMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchReceiveMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchReceiveMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchReceiveMessageResponse
        /// </returns>
        public async Task<BatchReceiveMessageResponse> BatchReceiveMessageWithOptionsAsync(string queueName, BatchReceiveMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfMessages))
            {
                query["numOfMessages"] = request.NumOfMessages;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Waitseconds))
            {
                query["waitseconds"] = request.Waitseconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchReceiveMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchReceiveMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchReceiveMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchReceiveMessageResponse
        /// </returns>
        public BatchReceiveMessageResponse BatchReceiveMessage(string queueName, BatchReceiveMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchReceiveMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchReceiveMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchReceiveMessageResponse
        /// </returns>
        public async Task<BatchReceiveMessageResponse> BatchReceiveMessageAsync(string queueName, BatchReceiveMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchReceiveMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>一次 Batch 请求的消息总大小不得超过 64 KB。</description></item>
        /// <item><description><c>BatchSendMessage</c> 与 <c>SendMessage</c> 使用相同的 URL 路径，通过 Body 结构区分：包含 <c>Messages</c> 数组即为批量发送，否则为单条发送。</description></item>
        /// <item><description>批量操作的返回结果可能同时包含成功和失败的子消息。</description></item>
        /// <item><description>每次请求中可以包含多个消息对象，每个消息对象可以设置不同的延迟时间和优先级。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 参数来指定消息分组 ID。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageResponse
        /// </returns>
        public BatchSendMessageResponse BatchSendMessageWithOptions(string queueName, BatchSendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["Messages"] = request.Messages;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSendMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>一次 Batch 请求的消息总大小不得超过 64 KB。</description></item>
        /// <item><description><c>BatchSendMessage</c> 与 <c>SendMessage</c> 使用相同的 URL 路径，通过 Body 结构区分：包含 <c>Messages</c> 数组即为批量发送，否则为单条发送。</description></item>
        /// <item><description>批量操作的返回结果可能同时包含成功和失败的子消息。</description></item>
        /// <item><description>每次请求中可以包含多个消息对象，每个消息对象可以设置不同的延迟时间和优先级。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 参数来指定消息分组 ID。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageResponse
        /// </returns>
        public async Task<BatchSendMessageResponse> BatchSendMessageWithOptionsAsync(string queueName, BatchSendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Messages))
            {
                body["Messages"] = request.Messages;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSendMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>一次 Batch 请求的消息总大小不得超过 64 KB。</description></item>
        /// <item><description><c>BatchSendMessage</c> 与 <c>SendMessage</c> 使用相同的 URL 路径，通过 Body 结构区分：包含 <c>Messages</c> 数组即为批量发送，否则为单条发送。</description></item>
        /// <item><description>批量操作的返回结果可能同时包含成功和失败的子消息。</description></item>
        /// <item><description>每次请求中可以包含多个消息对象，每个消息对象可以设置不同的延迟时间和优先级。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 参数来指定消息分组 ID。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageResponse
        /// </returns>
        public BatchSendMessageResponse BatchSendMessage(string queueName, BatchSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchSendMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>一次 Batch 请求的消息总大小不得超过 64 KB。</description></item>
        /// <item><description><c>BatchSendMessage</c> 与 <c>SendMessage</c> 使用相同的 URL 路径，通过 Body 结构区分：包含 <c>Messages</c> 数组即为批量发送，否则为单条发送。</description></item>
        /// <item><description>批量操作的返回结果可能同时包含成功和失败的子消息。</description></item>
        /// <item><description>每次请求中可以包含多个消息对象，每个消息对象可以设置不同的延迟时间和优先级。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 参数来指定消息分组 ID。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageResponse
        /// </returns>
        public async Task<BatchSendMessageResponse> BatchSendMessageAsync(string queueName, BatchSendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchSendMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改消息下次可消费时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMessageVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMessageVisibilityResponse
        /// </returns>
        public ChangeMessageVisibilityResponse ChangeMessageVisibilityWithOptions(string queueName, ChangeMessageVisibilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandle))
            {
                query["receiptHandle"] = request.ReceiptHandle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["visibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMessageVisibility",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMessageVisibilityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改消息下次可消费时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMessageVisibilityRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeMessageVisibilityResponse
        /// </returns>
        public async Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityWithOptionsAsync(string queueName, ChangeMessageVisibilityRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandle))
            {
                query["receiptHandle"] = request.ReceiptHandle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["visibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeMessageVisibility",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeMessageVisibilityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改消息下次可消费时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMessageVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMessageVisibilityResponse
        /// </returns>
        public ChangeMessageVisibilityResponse ChangeMessageVisibility(string queueName, ChangeMessageVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeMessageVisibilityWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改消息下次可消费时间</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeMessageVisibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeMessageVisibilityResponse
        /// </returns>
        public async Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(string queueName, ChangeMessageVisibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeMessageVisibilityWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除已消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageResponse
        /// </returns>
        public DeleteMessageResponse DeleteMessageWithOptions(string queueName, DeleteMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandle))
            {
                query["ReceiptHandle"] = request.ReceiptHandle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除已消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageResponse
        /// </returns>
        public async Task<DeleteMessageResponse> DeleteMessageWithOptionsAsync(string queueName, DeleteMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptHandle))
            {
                query["ReceiptHandle"] = request.ReceiptHandle;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除已消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageResponse
        /// </returns>
        public DeleteMessageResponse DeleteMessage(string queueName, DeleteMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除已消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteMessageResponse
        /// </returns>
        public async Task<DeleteMessageResponse> DeleteMessageAsync(string queueName, DeleteMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PeekMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PeekMessageResponse
        /// </returns>
        public PeekMessageResponse PeekMessageWithOptions(string queueName, PeekMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Peekonly))
            {
                query["peekonly"] = request.Peekonly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PeekMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PeekMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PeekMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PeekMessageResponse
        /// </returns>
        public async Task<PeekMessageResponse> PeekMessageWithOptionsAsync(string queueName, PeekMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Peekonly))
            {
                query["peekonly"] = request.Peekonly;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PeekMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PeekMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PeekMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PeekMessageResponse
        /// </returns>
        public PeekMessageResponse PeekMessage(string queueName, PeekMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PeekMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查看消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PeekMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PeekMessageResponse
        /// </returns>
        public async Task<PeekMessageResponse> PeekMessageAsync(string queueName, PeekMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PeekMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>消息发布后会被推送到该 Topic 下所有 Subscription 的 Endpoint。</description></item>
        /// <item><description>推送到 Queue 和 HTTP Endpoint 时不需要设置 <c>MessageAttributes</c>。</description></item>
        /// <item><description>推送到邮件、短信或移动推送时需要设置对应的 <c>MessageAttributes</c> 子属性。</description></item>
        /// <item><description>消息内容建议事先进行 Base64 编码以避免特殊字符问题。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishMessageResponse
        /// </returns>
        public PublishMessageResponse PublishMessageWithOptions(string topicName, PublishMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageAttributes))
            {
                body["MessageAttributes"] = request.MessageAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                body["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                body["MessageTag"] = request.MessageTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/topics/" + topicName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>消息发布后会被推送到该 Topic 下所有 Subscription 的 Endpoint。</description></item>
        /// <item><description>推送到 Queue 和 HTTP Endpoint 时不需要设置 <c>MessageAttributes</c>。</description></item>
        /// <item><description>推送到邮件、短信或移动推送时需要设置对应的 <c>MessageAttributes</c> 子属性。</description></item>
        /// <item><description>消息内容建议事先进行 Base64 编码以避免特殊字符问题。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishMessageResponse
        /// </returns>
        public async Task<PublishMessageResponse> PublishMessageWithOptionsAsync(string topicName, PublishMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageAttributes))
            {
                body["MessageAttributes"] = request.MessageAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                body["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                body["MessageTag"] = request.MessageTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/topics/" + topicName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>消息发布后会被推送到该 Topic 下所有 Subscription 的 Endpoint。</description></item>
        /// <item><description>推送到 Queue 和 HTTP Endpoint 时不需要设置 <c>MessageAttributes</c>。</description></item>
        /// <item><description>推送到邮件、短信或移动推送时需要设置对应的 <c>MessageAttributes</c> 子属性。</description></item>
        /// <item><description>消息内容建议事先进行 Base64 编码以避免特殊字符问题。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishMessageResponse
        /// </returns>
        public PublishMessageResponse PublishMessage(string topicName, PublishMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishMessageWithOptions(topicName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>消息发布后会被推送到该 Topic 下所有 Subscription 的 Endpoint。</description></item>
        /// <item><description>推送到 Queue 和 HTTP Endpoint 时不需要设置 <c>MessageAttributes</c>。</description></item>
        /// <item><description>推送到邮件、短信或移动推送时需要设置对应的 <c>MessageAttributes</c> 子属性。</description></item>
        /// <item><description>消息内容建议事先进行 Base64 编码以避免特殊字符问题。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishMessageResponse
        /// </returns>
        public async Task<PublishMessageResponse> PublishMessageAsync(string topicName, PublishMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishMessageWithOptionsAsync(topicName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReceiveMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReceiveMessageResponse
        /// </returns>
        public ReceiveMessageResponse ReceiveMessageWithOptions(string queueName, ReceiveMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Waitseconds))
            {
                query["waitseconds"] = request.Waitseconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReceiveMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReceiveMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReceiveMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReceiveMessageResponse
        /// </returns>
        public async Task<ReceiveMessageResponse> ReceiveMessageWithOptionsAsync(string queueName, ReceiveMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Waitseconds))
            {
                query["waitseconds"] = request.Waitseconds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReceiveMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReceiveMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReceiveMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReceiveMessageResponse
        /// </returns>
        public ReceiveMessageResponse ReceiveMessage(string queueName, ReceiveMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReceiveMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>消费消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReceiveMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// ReceiveMessageResponse
        /// </returns>
        public async Task<ReceiveMessageResponse> ReceiveMessageAsync(string queueName, ReceiveMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReceiveMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>SendMessage</b> 接口用于将消息发送至指定队列。</description></item>
        /// <item><description>消息可以立即被消费或通过设置 <c>DelaySeconds</c> 参数来延迟消费。</description></item>
        /// <item><description>发送的消息可以指定优先级，数值越小表示优先级越高。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 来保证同一分组内消息的顺序投递。</description></item>
        /// <item><description>用户还可以自定义属性 <c>UserProperties</c>，以 JSON 格式字符串形式提供额外信息。</description></item>
        /// <item><description>当 <c>DelaySeconds</c> 大于 0 时，API 返回的 <c>ReceiptHandle</c> 可用来在消息变为 Active 状态前删除该延迟消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessageWithOptions(string queueName, SendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                body["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                body["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageGroupId))
            {
                body["MessageGroupId"] = request.MessageGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProperties))
            {
                body["UserProperties"] = request.UserProperties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>SendMessage</b> 接口用于将消息发送至指定队列。</description></item>
        /// <item><description>消息可以立即被消费或通过设置 <c>DelaySeconds</c> 参数来延迟消费。</description></item>
        /// <item><description>发送的消息可以指定优先级，数值越小表示优先级越高。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 来保证同一分组内消息的顺序投递。</description></item>
        /// <item><description>用户还可以自定义属性 <c>UserProperties</c>，以 JSON 格式字符串形式提供额外信息。</description></item>
        /// <item><description>当 <c>DelaySeconds</c> 大于 0 时，API 返回的 <c>ReceiptHandle</c> 可用来在消息变为 Active 状态前删除该延迟消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(string queueName, SendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                body["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                body["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageGroupId))
            {
                body["MessageGroupId"] = request.MessageGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProperties))
            {
                body["UserProperties"] = request.UserProperties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2026-04-09",
                Protocol = "HTTPS",
                Pathname = "/queues/" + queueName + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>SendMessage</b> 接口用于将消息发送至指定队列。</description></item>
        /// <item><description>消息可以立即被消费或通过设置 <c>DelaySeconds</c> 参数来延迟消费。</description></item>
        /// <item><description>发送的消息可以指定优先级，数值越小表示优先级越高。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 来保证同一分组内消息的顺序投递。</description></item>
        /// <item><description>用户还可以自定义属性 <c>UserProperties</c>，以 JSON 格式字符串形式提供额外信息。</description></item>
        /// <item><description>当 <c>DelaySeconds</c> 大于 0 时，API 返回的 <c>ReceiptHandle</c> 可用来在消息变为 Active 状态前删除该延迟消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessage(string queueName, SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendMessageWithOptions(queueName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送消息</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description><b>SendMessage</b> 接口用于将消息发送至指定队列。</description></item>
        /// <item><description>消息可以立即被消费或通过设置 <c>DelaySeconds</c> 参数来延迟消费。</description></item>
        /// <item><description>发送的消息可以指定优先级，数值越小表示优先级越高。</description></item>
        /// <item><description>对于 FIFO 队列，可以通过 <c>MessageGroupId</c> 来保证同一分组内消息的顺序投递。</description></item>
        /// <item><description>用户还可以自定义属性 <c>UserProperties</c>，以 JSON 格式字符串形式提供额外信息。</description></item>
        /// <item><description>当 <c>DelaySeconds</c> 大于 0 时，API 返回的 <c>ReceiptHandle</c> 可用来在消息变为 Active 状态前删除该延迟消息。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageAsync(string queueName, SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendMessageWithOptionsAsync(queueName, request, headers, runtime);
        }

    }
}
