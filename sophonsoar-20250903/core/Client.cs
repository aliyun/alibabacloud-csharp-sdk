// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sophonsoar20250903.Models;

namespace AlibabaCloud.SDK.Sophonsoar20250903
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sophonsoar", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Create Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Ingress Traffic) before using this interface.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComponentAssetResponse
        /// </returns>
        public CreateComponentAssetResponse CreateComponentAssetWithOptions(CreateComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetName))
            {
                body["ComponentAssetName"] = request.ComponentAssetName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetValues))
            {
                bodyFlat["ComponentAssetValues"] = request.ComponentAssetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComponentAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Ingress Traffic) before using this interface.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComponentAssetResponse
        /// </returns>
        public async Task<CreateComponentAssetResponse> CreateComponentAssetWithOptionsAsync(CreateComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetName))
            {
                body["ComponentAssetName"] = request.ComponentAssetName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetValues))
            {
                bodyFlat["ComponentAssetValues"] = request.ComponentAssetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComponentAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Ingress Traffic) before using this interface.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComponentAssetResponse
        /// </returns>
        public CreateComponentAssetResponse CreateComponentAsset(CreateComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateComponentAssetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that you fully understand the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Ingress Traffic) before using this interface.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComponentAssetResponse
        /// </returns>
        public async Task<CreateComponentAssetResponse> CreateComponentAssetAsync(CreateComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateComponentAssetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlaybookResponse
        /// </returns>
        public CreatePlaybookResponse CreatePlaybookWithOptions(CreatePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookDescription))
            {
                body["PlaybookDescription"] = request.PlaybookDescription;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookInputConfigs))
            {
                bodyFlat["PlaybookInputConfigs"] = request.PlaybookInputConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookOutputConfigs))
            {
                bodyFlat["PlaybookOutputConfigs"] = request.PlaybookOutputConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamType))
            {
                body["PlaybookParamType"] = request.PlaybookParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTaskFlow))
            {
                body["PlaybookTaskFlow"] = request.PlaybookTaskFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPlaybookUuid))
            {
                body["SrcPlaybookUuid"] = request.SrcPlaybookUuid;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePlaybookResponse
        /// </returns>
        public async Task<CreatePlaybookResponse> CreatePlaybookWithOptionsAsync(CreatePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookDescription))
            {
                body["PlaybookDescription"] = request.PlaybookDescription;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookInputConfigs))
            {
                bodyFlat["PlaybookInputConfigs"] = request.PlaybookInputConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookOutputConfigs))
            {
                bodyFlat["PlaybookOutputConfigs"] = request.PlaybookOutputConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamType))
            {
                body["PlaybookParamType"] = request.PlaybookParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTaskFlow))
            {
                body["PlaybookTaskFlow"] = request.PlaybookTaskFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcPlaybookUuid))
            {
                body["SrcPlaybookUuid"] = request.SrcPlaybookUuid;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePlaybookResponse
        /// </returns>
        public CreatePlaybookResponse CreatePlaybook(CreatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePlaybookResponse
        /// </returns>
        public async Task<CreatePlaybookResponse> CreatePlaybookAsync(CreatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Access Traffic).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComponentAssetResponse
        /// </returns>
        public DeleteComponentAssetResponse DeleteComponentAssetWithOptions(DeleteComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComponentAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Access Traffic).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComponentAssetResponse
        /// </returns>
        public async Task<DeleteComponentAssetResponse> DeleteComponentAssetWithOptionsAsync(DeleteComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComponentAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Access Traffic).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComponentAssetResponse
        /// </returns>
        public DeleteComponentAssetResponse DeleteComponentAsset(DeleteComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteComponentAssetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Component Asset.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the billing method and <a href="https://www.aliyun.com/price/product#/sas/detail/sas">pricing</a> of the response orchestration product (i.e., Threat Analysis and Response Log Access Traffic).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteComponentAssetResponse
        /// </returns>
        public async Task<DeleteComponentAssetResponse> DeleteComponentAssetAsync(DeleteComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteComponentAssetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePlaybookResponse
        /// </returns>
        public DeletePlaybookResponse DeletePlaybookWithOptions(DeletePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePlaybookResponse
        /// </returns>
        public async Task<DeletePlaybookResponse> DeletePlaybookWithOptionsAsync(DeletePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePlaybookResponse
        /// </returns>
        public DeletePlaybookResponse DeletePlaybook(DeletePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePlaybookResponse
        /// </returns>
        public async Task<DeletePlaybookResponse> DeletePlaybookAsync(DeletePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get playbook details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPlaybookResponse
        /// </returns>
        public GetPlaybookResponse GetPlaybookWithOptions(GetPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookVersion))
            {
                body["PlaybookVersion"] = request.PlaybookVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookVersionType))
            {
                body["PlaybookVersionType"] = request.PlaybookVersionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get playbook details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPlaybookResponse
        /// </returns>
        public async Task<GetPlaybookResponse> GetPlaybookWithOptionsAsync(GetPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookVersion))
            {
                body["PlaybookVersion"] = request.PlaybookVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookVersionType))
            {
                body["PlaybookVersionType"] = request.PlaybookVersionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get playbook details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPlaybookResponse
        /// </returns>
        public GetPlaybookResponse GetPlaybook(GetPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get playbook details.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPlaybookResponse
        /// </returns>
        public async Task<GetPlaybookResponse> GetPlaybookAsync(GetPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of assets configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComponentAssetsResponse
        /// </returns>
        public ListComponentAssetsResponse ListComponentAssetsWithOptions(ListComponentAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentAssets",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentAssetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of assets configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComponentAssetsResponse
        /// </returns>
        public async Task<ListComponentAssetsResponse> ListComponentAssetsWithOptionsAsync(ListComponentAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentAssets",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of assets configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComponentAssetsResponse
        /// </returns>
        public ListComponentAssetsResponse ListComponentAssets(ListComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComponentAssetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get the list of assets configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComponentAssetsResponse
        /// </returns>
        public async Task<ListComponentAssetsResponse> ListComponentAssetsAsync(ListComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComponentAssetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Component List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComponentsResponse
        /// </returns>
        public ListComponentsResponse ListComponentsWithOptions(ListComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Component List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComponentsResponse
        /// </returns>
        public async Task<ListComponentsResponse> ListComponentsWithOptionsAsync(ListComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["ComponentName"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Component List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComponentsResponse
        /// </returns>
        public ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComponentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Component List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComponentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComponentsResponse
        /// </returns>
        public async Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComponentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Playbook List.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlaybooksResponse
        /// </returns>
        public ListPlaybooksResponse ListPlaybooksWithOptions(ListPlaybooksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlaybooksShrinkRequest request = new ListPlaybooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookParamTypes))
            {
                request.PlaybookParamTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookParamTypes, "PlaybookParamTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookUuids))
            {
                request.PlaybookUuidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookUuids, "PlaybookUuids", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookExecutionEndTime))
            {
                body["PlaybookExecutionEndTime"] = request.PlaybookExecutionEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookExecutionStartTime))
            {
                body["PlaybookExecutionStartTime"] = request.PlaybookExecutionStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamTypesShrink))
            {
                body["PlaybookParamTypes"] = request.PlaybookParamTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookStatus))
            {
                body["PlaybookStatus"] = request.PlaybookStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookType))
            {
                body["PlaybookType"] = request.PlaybookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuidsShrink))
            {
                body["PlaybookUuids"] = request.PlaybookUuidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlaybooks",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlaybooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Playbook List.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListPlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlaybooksResponse
        /// </returns>
        public async Task<ListPlaybooksResponse> ListPlaybooksWithOptionsAsync(ListPlaybooksRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListPlaybooksShrinkRequest request = new ListPlaybooksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookParamTypes))
            {
                request.PlaybookParamTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookParamTypes, "PlaybookParamTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookUuids))
            {
                request.PlaybookUuidsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookUuids, "PlaybookUuids", "simple");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderField))
            {
                body["OrderField"] = request.OrderField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookExecutionEndTime))
            {
                body["PlaybookExecutionEndTime"] = request.PlaybookExecutionEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookExecutionStartTime))
            {
                body["PlaybookExecutionStartTime"] = request.PlaybookExecutionStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamTypesShrink))
            {
                body["PlaybookParamTypes"] = request.PlaybookParamTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookStatus))
            {
                body["PlaybookStatus"] = request.PlaybookStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookType))
            {
                body["PlaybookType"] = request.PlaybookType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuidsShrink))
            {
                body["PlaybookUuids"] = request.PlaybookUuidsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPlaybooks",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPlaybooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Playbook List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlaybooksResponse
        /// </returns>
        public ListPlaybooksResponse ListPlaybooks(ListPlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlaybooksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get Playbook List.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlaybooksResponse
        /// </returns>
        public async Task<ListPlaybooksResponse> ListPlaybooksAsync(ListPlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlaybooksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Component Asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComponentAssetResponse
        /// </returns>
        public UpdateComponentAssetResponse UpdateComponentAssetWithOptions(UpdateComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetName))
            {
                body["ComponentAssetName"] = request.ComponentAssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetValues))
            {
                bodyFlat["ComponentAssetValues"] = request.ComponentAssetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComponentAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Component Asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComponentAssetResponse
        /// </returns>
        public async Task<UpdateComponentAssetResponse> UpdateComponentAssetWithOptionsAsync(UpdateComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetName))
            {
                body["ComponentAssetName"] = request.ComponentAssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetUuid))
            {
                body["ComponentAssetUuid"] = request.ComponentAssetUuid;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentAssetValues))
            {
                bodyFlat["ComponentAssetValues"] = request.ComponentAssetValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComponentAsset",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComponentAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Component Asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComponentAssetResponse
        /// </returns>
        public UpdateComponentAssetResponse UpdateComponentAsset(UpdateComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateComponentAssetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Component Asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComponentAssetResponse
        /// </returns>
        public async Task<UpdateComponentAssetResponse> UpdateComponentAssetAsync(UpdateComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateComponentAssetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Playbook.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePlaybookResponse
        /// </returns>
        public UpdatePlaybookResponse UpdatePlaybookWithOptions(UpdatePlaybookRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePlaybookShrinkRequest request = new UpdatePlaybookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookInputConfigs))
            {
                request.PlaybookInputConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookInputConfigs, "PlaybookInputConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookOutputConfigs))
            {
                request.PlaybookOutputConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookOutputConfigs, "PlaybookOutputConfigs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookDescription))
            {
                body["PlaybookDescription"] = request.PlaybookDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookInputConfigsShrink))
            {
                body["PlaybookInputConfigs"] = request.PlaybookInputConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookOutputConfigsShrink))
            {
                body["PlaybookOutputConfigs"] = request.PlaybookOutputConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamType))
            {
                body["PlaybookParamType"] = request.PlaybookParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTaskFlow))
            {
                body["PlaybookTaskFlow"] = request.PlaybookTaskFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Playbook.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePlaybookResponse
        /// </returns>
        public async Task<UpdatePlaybookResponse> UpdatePlaybookWithOptionsAsync(UpdatePlaybookRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePlaybookShrinkRequest request = new UpdatePlaybookShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookInputConfigs))
            {
                request.PlaybookInputConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookInputConfigs, "PlaybookInputConfigs", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlaybookOutputConfigs))
            {
                request.PlaybookOutputConfigsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlaybookOutputConfigs, "PlaybookOutputConfigs", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookDescription))
            {
                body["PlaybookDescription"] = request.PlaybookDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookInputConfigsShrink))
            {
                body["PlaybookInputConfigs"] = request.PlaybookInputConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookName))
            {
                body["PlaybookName"] = request.PlaybookName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookOutputConfigsShrink))
            {
                body["PlaybookOutputConfigs"] = request.PlaybookOutputConfigsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookParamType))
            {
                body["PlaybookParamType"] = request.PlaybookParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookTaskFlow))
            {
                body["PlaybookTaskFlow"] = request.PlaybookTaskFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleFor))
            {
                body["RoleFor"] = request.RoleFor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePlaybook",
                Version = "2025-09-03",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePlaybookResponse
        /// </returns>
        public UpdatePlaybookResponse UpdatePlaybook(UpdatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePlaybookResponse
        /// </returns>
        public async Task<UpdatePlaybookResponse> UpdatePlaybookAsync(UpdatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePlaybookWithOptionsAsync(request, runtime);
        }

    }
}
