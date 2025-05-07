// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WuyingSolutionFramework20230810.Models;

namespace AlibabaCloud.SDK.WuyingSolutionFramework20230810
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wuyingsolutionframework", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送运维消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalResponse
        /// </returns>
        public SendOpsMessageToTerminalResponse SendOpsMessageToTerminalWithOptions(SendOpsMessageToTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                query["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeRegionId))
            {
                query["OfficeRegionId"] = request.OfficeRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                query["OpsAction"] = request.OpsAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                query["WaitForAck"] = request.WaitForAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForMsg))
            {
                query["WaitForMsg"] = request.WaitForMsg;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminal",
                Version = "2023-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送运维消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalResponse> SendOpsMessageToTerminalWithOptionsAsync(SendOpsMessageToTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                query["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OfficeRegionId))
            {
                query["OfficeRegionId"] = request.OfficeRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                query["OpsAction"] = request.OpsAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                query["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                query["WaitForAck"] = request.WaitForAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForMsg))
            {
                query["WaitForMsg"] = request.WaitForMsg;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminal",
                Version = "2023-08-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送运维消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalResponse
        /// </returns>
        public SendOpsMessageToTerminalResponse SendOpsMessageToTerminal(SendOpsMessageToTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendOpsMessageToTerminalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送运维消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendOpsMessageToTerminalRequest
        /// </param>
        /// 
        /// <returns>
        /// SendOpsMessageToTerminalResponse
        /// </returns>
        public async Task<SendOpsMessageToTerminalResponse> SendOpsMessageToTerminalAsync(SendOpsMessageToTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendOpsMessageToTerminalWithOptionsAsync(request, runtime);
        }

    }
}
