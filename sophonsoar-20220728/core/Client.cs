// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sophonsoar20220728.Models;

namespace AlibabaCloud.SDK.Sophonsoar20220728
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
        /// <para>Modifies the statuses of playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchModifyInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchModifyInstanceStatusResponse
        /// </returns>
        public BatchModifyInstanceStatusResponse BatchModifyInstanceStatusWithOptions(BatchModifyInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchModifyInstanceStatus",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchModifyInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the statuses of playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchModifyInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchModifyInstanceStatusResponse
        /// </returns>
        public async Task<BatchModifyInstanceStatusResponse> BatchModifyInstanceStatusWithOptionsAsync(BatchModifyInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchModifyInstanceStatus",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchModifyInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the statuses of playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchModifyInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchModifyInstanceStatusResponse
        /// </returns>
        public BatchModifyInstanceStatusResponse BatchModifyInstanceStatus(BatchModifyInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchModifyInstanceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the statuses of playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchModifyInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchModifyInstanceStatusResponse
        /// </returns>
        public async Task<BatchModifyInstanceStatusResponse> BatchModifyInstanceStatusAsync(BatchModifyInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchModifyInstanceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compares configurations between two versions of a published playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ComparePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ComparePlaybooksResponse
        /// </returns>
        public ComparePlaybooksResponse ComparePlaybooksWithOptions(ComparePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPlaybookReleaseId))
            {
                query["NewPlaybookReleaseId"] = request.NewPlaybookReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPlaybookReleaseId))
            {
                query["OldPlaybookReleaseId"] = request.OldPlaybookReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                query["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComparePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComparePlaybooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compares configurations between two versions of a published playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ComparePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ComparePlaybooksResponse
        /// </returns>
        public async Task<ComparePlaybooksResponse> ComparePlaybooksWithOptionsAsync(ComparePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewPlaybookReleaseId))
            {
                query["NewPlaybookReleaseId"] = request.NewPlaybookReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldPlaybookReleaseId))
            {
                query["OldPlaybookReleaseId"] = request.OldPlaybookReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                query["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ComparePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ComparePlaybooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compares configurations between two versions of a published playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ComparePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ComparePlaybooksResponse
        /// </returns>
        public ComparePlaybooksResponse ComparePlaybooks(ComparePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ComparePlaybooksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Compares configurations between two versions of a published playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ComparePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// ComparePlaybooksResponse
        /// </returns>
        public async Task<ComparePlaybooksResponse> ComparePlaybooksAsync(ComparePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ComparePlaybooksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a playbook.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowType))
            {
                body["TaskflowType"] = request.TaskflowType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlaybook",
                Version = "2022-07-28",
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
        /// <para>Creates a playbook.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskflowType))
            {
                body["TaskflowType"] = request.TaskflowType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePlaybook",
                Version = "2022-07-28",
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
        /// <para>Creates a playbook.</para>
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
        /// <para>Creates a playbook.</para>
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
        /// <para>Debugs a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugPlaybookResponse
        /// </returns>
        public DebugPlaybookResponse DebugPlaybookWithOptions(DebugPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Record))
            {
                body["Record"] = request.Record;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taskflow))
            {
                body["Taskflow"] = request.Taskflow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DebugPlaybookResponse
        /// </returns>
        public async Task<DebugPlaybookResponse> DebugPlaybookWithOptionsAsync(DebugPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Record))
            {
                body["Record"] = request.Record;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taskflow))
            {
                body["Taskflow"] = request.Taskflow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DebugPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DebugPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugPlaybookResponse
        /// </returns>
        public DebugPlaybookResponse DebugPlaybook(DebugPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Debugs a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DebugPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DebugPlaybookResponse
        /// </returns>
        public async Task<DebugPlaybookResponse> DebugPlaybookAsync(DebugPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the assets in a component.</para>
        /// </summary>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                query["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComponentAsset",
                Version = "2022-07-28",
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
        /// <para>Deletes the assets in a component.</para>
        /// </summary>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetId))
            {
                query["AssetId"] = request.AssetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComponentAsset",
                Version = "2022-07-28",
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
        /// <para>Deletes the assets in a component.</para>
        /// </summary>
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
        /// <para>Deletes the assets in a component.</para>
        /// </summary>
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
        /// <para>Deletes a custom playbook.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePlaybook",
                Version = "2022-07-28",
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
        /// <para>Deletes a custom playbook.</para>
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePlaybook",
                Version = "2022-07-28",
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
        /// <para>Deletes a custom playbook.</para>
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
        /// <para>Deletes a custom playbook.</para>
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
        /// <para>Queries the API operations of the cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApiListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiListResponse
        /// </returns>
        public DescribeApiListResponse DescribeApiListWithOptions(DescribeApiListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApiList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApiListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the API operations of the cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApiListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiListResponse
        /// </returns>
        public async Task<DescribeApiListResponse> DescribeApiListWithOptionsAsync(DescribeApiListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApiList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApiListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the API operations of the cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApiListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiListResponse
        /// </returns>
        public DescribeApiListResponse DescribeApiList(DescribeApiListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the API operations of the cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApiListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApiListResponse
        /// </returns>
        public async Task<DescribeApiListResponse> DescribeApiListAsync(DescribeApiListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetFormRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetFormResponse
        /// </returns>
        public DescribeComponentAssetFormResponse DescribeComponentAssetFormWithOptions(DescribeComponentAssetFormRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentAssetForm",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentAssetFormResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetFormRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetFormResponse
        /// </returns>
        public async Task<DescribeComponentAssetFormResponse> DescribeComponentAssetFormWithOptionsAsync(DescribeComponentAssetFormRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentAssetForm",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentAssetFormResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetFormRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetFormResponse
        /// </returns>
        public DescribeComponentAssetFormResponse DescribeComponentAssetForm(DescribeComponentAssetFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentAssetFormWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetFormRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetFormResponse
        /// </returns>
        public async Task<DescribeComponentAssetFormResponse> DescribeComponentAssetFormAsync(DescribeComponentAssetFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentAssetFormWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of assets in a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetsResponse
        /// </returns>
        public DescribeComponentAssetsResponse DescribeComponentAssetsWithOptions(DescribeComponentAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentAssets",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentAssetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of assets in a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetsResponse
        /// </returns>
        public async Task<DescribeComponentAssetsResponse> DescribeComponentAssetsWithOptionsAsync(DescribeComponentAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentAssets",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentAssetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of assets in a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetsResponse
        /// </returns>
        public DescribeComponentAssetsResponse DescribeComponentAssets(DescribeComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentAssetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of assets in a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentAssetsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentAssetsResponse
        /// </returns>
        public async Task<DescribeComponentAssetsResponse> DescribeComponentAssetsAsync(DescribeComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentAssetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of common components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentListResponse
        /// </returns>
        public DescribeComponentListResponse DescribeComponentListWithOptions(DescribeComponentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of common components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentListResponse
        /// </returns>
        public async Task<DescribeComponentListResponse> DescribeComponentListWithOptionsAsync(DescribeComponentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of common components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentListResponse
        /// </returns>
        public DescribeComponentListResponse DescribeComponentList(DescribeComponentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of common components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentListResponse
        /// </returns>
        public async Task<DescribeComponentListResponse> DescribeComponentListAsync(DescribeComponentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of predefined components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentPlaybookResponse
        /// </returns>
        public DescribeComponentPlaybookResponse DescribeComponentPlaybookWithOptions(DescribeComponentPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of predefined components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentPlaybookResponse
        /// </returns>
        public async Task<DescribeComponentPlaybookResponse> DescribeComponentPlaybookWithOptionsAsync(DescribeComponentPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of predefined components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentPlaybookResponse
        /// </returns>
        public DescribeComponentPlaybookResponse DescribeComponentPlaybook(DescribeComponentPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of predefined components that are available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentPlaybookResponse
        /// </returns>
        public async Task<DescribeComponentPlaybookResponse> DescribeComponentPlaybookAsync(DescribeComponentPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsJsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsJsResponse
        /// </returns>
        public DescribeComponentsJsResponse DescribeComponentsJsWithOptions(DescribeComponentsJsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentsJs",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsJsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsJsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsJsResponse
        /// </returns>
        public async Task<DescribeComponentsJsResponse> DescribeComponentsJsWithOptionsAsync(DescribeComponentsJsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponentsJs",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsJsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsJsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsJsResponse
        /// </returns>
        public DescribeComponentsJsResponse DescribeComponentsJs(DescribeComponentsJsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentsJsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsJsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsJsResponse
        /// </returns>
        public async Task<DescribeComponentsJsResponse> DescribeComponentsJsAsync(DescribeComponentsJsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentsJsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook after deduplication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDistinctReleasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistinctReleasesResponse
        /// </returns>
        public DescribeDistinctReleasesResponse DescribeDistinctReleasesWithOptions(DescribeDistinctReleasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistinctReleases",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistinctReleasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook after deduplication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDistinctReleasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistinctReleasesResponse
        /// </returns>
        public async Task<DescribeDistinctReleasesResponse> DescribeDistinctReleasesWithOptionsAsync(DescribeDistinctReleasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDistinctReleases",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDistinctReleasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook after deduplication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDistinctReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistinctReleasesResponse
        /// </returns>
        public DescribeDistinctReleasesResponse DescribeDistinctReleases(DescribeDistinctReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDistinctReleasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook after deduplication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDistinctReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDistinctReleasesResponse
        /// </returns>
        public async Task<DescribeDistinctReleasesResponse> DescribeDistinctReleasesAsync(DescribeDistinctReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDistinctReleasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries enumeration items that are required by a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnumItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnumItemsResponse
        /// </returns>
        public DescribeEnumItemsResponse DescribeEnumItemsWithOptions(DescribeEnumItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnumItems",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnumItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries enumeration items that are required by a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnumItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnumItemsResponse
        /// </returns>
        public async Task<DescribeEnumItemsResponse> DescribeEnumItemsWithOptionsAsync(DescribeEnumItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEnumItems",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEnumItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries enumeration items that are required by a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnumItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnumItemsResponse
        /// </returns>
        public DescribeEnumItemsResponse DescribeEnumItems(DescribeEnumItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnumItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries enumeration items that are required by a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEnumItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEnumItemsResponse
        /// </returns>
        public async Task<DescribeEnumItemsResponse> DescribeEnumItemsAsync(DescribeEnumItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnumItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the playbooks that are available for an automatic response plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutePlaybooksResponse
        /// </returns>
        public DescribeExecutePlaybooksResponse DescribeExecutePlaybooksWithOptions(DescribeExecutePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecutePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutePlaybooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the playbooks that are available for an automatic response plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutePlaybooksResponse
        /// </returns>
        public async Task<DescribeExecutePlaybooksResponse> DescribeExecutePlaybooksWithOptionsAsync(DescribeExecutePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExecutePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExecutePlaybooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the playbooks that are available for an automatic response plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutePlaybooksResponse
        /// </returns>
        public DescribeExecutePlaybooksResponse DescribeExecutePlaybooks(DescribeExecutePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutePlaybooksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the playbooks that are available for an automatic response plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeExecutePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeExecutePlaybooksResponse
        /// </returns>
        public async Task<DescribeExecutePlaybooksResponse> DescribeExecutePlaybooksAsync(DescribeExecutePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutePlaybooksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configuration information about a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFieldResponse
        /// </returns>
        public DescribeFieldResponse DescribeFieldWithOptions(DescribeFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeField",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFieldResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configuration information about a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFieldResponse
        /// </returns>
        public async Task<DescribeFieldResponse> DescribeFieldWithOptionsAsync(DescribeFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeField",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configuration information about a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFieldResponse
        /// </returns>
        public DescribeFieldResponse DescribeField(DescribeFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFieldWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the global configuration information about a cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFieldResponse
        /// </returns>
        public async Task<DescribeFieldResponse> DescribeFieldAsync(DescribeFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFieldWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLatestRecordSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestRecordSchemaResponse
        /// </returns>
        public DescribeLatestRecordSchemaResponse DescribeLatestRecordSchemaWithOptions(DescribeLatestRecordSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLatestRecordSchema",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLatestRecordSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLatestRecordSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestRecordSchemaResponse
        /// </returns>
        public async Task<DescribeLatestRecordSchemaResponse> DescribeLatestRecordSchemaWithOptionsAsync(DescribeLatestRecordSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLatestRecordSchema",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLatestRecordSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLatestRecordSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestRecordSchemaResponse
        /// </returns>
        public DescribeLatestRecordSchemaResponse DescribeLatestRecordSchema(DescribeLatestRecordSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLatestRecordSchemaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeLatestRecordSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeLatestRecordSchemaResponse
        /// </returns>
        public async Task<DescribeLatestRecordSchemaResponse> DescribeLatestRecordSchemaAsync(DescribeLatestRecordSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLatestRecordSchemaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries recommended dynamic input parameters of a component for playbook orchestration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeParamTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeParamTagsResponse
        /// </returns>
        public DescribeNodeParamTagsResponse DescribeNodeParamTagsWithOptions(DescribeNodeParamTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeParamTags",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeParamTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries recommended dynamic input parameters of a component for playbook orchestration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeParamTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeParamTagsResponse
        /// </returns>
        public async Task<DescribeNodeParamTagsResponse> DescribeNodeParamTagsWithOptionsAsync(DescribeNodeParamTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeParamTags",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeParamTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries recommended dynamic input parameters of a component for playbook orchestration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeParamTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeParamTagsResponse
        /// </returns>
        public DescribeNodeParamTagsResponse DescribeNodeParamTags(DescribeNodeParamTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeParamTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries recommended dynamic input parameters of a component for playbook orchestration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeParamTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeParamTagsResponse
        /// </returns>
        public async Task<DescribeNodeParamTagsResponse> DescribeNodeParamTagsAsync(DescribeNodeParamTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeParamTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes that reference the same node in a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeUsedInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeUsedInfosResponse
        /// </returns>
        public DescribeNodeUsedInfosResponse DescribeNodeUsedInfosWithOptions(DescribeNodeUsedInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeUsedInfos",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeUsedInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes that reference the same node in a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeUsedInfosRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeUsedInfosResponse
        /// </returns>
        public async Task<DescribeNodeUsedInfosResponse> DescribeNodeUsedInfosWithOptionsAsync(DescribeNodeUsedInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodeUsedInfos",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodeUsedInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes that reference the same node in a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeUsedInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeUsedInfosResponse
        /// </returns>
        public DescribeNodeUsedInfosResponse DescribeNodeUsedInfos(DescribeNodeUsedInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeUsedInfosWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes that reference the same node in a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNodeUsedInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNodeUsedInfosResponse
        /// </returns>
        public async Task<DescribeNodeUsedInfosResponse> DescribeNodeUsedInfosAsync(DescribeNodeUsedInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeUsedInfosWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the XML configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookResponse
        /// </returns>
        public DescribePlaybookResponse DescribePlaybookWithOptions(DescribePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the XML configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookResponse
        /// </returns>
        public async Task<DescribePlaybookResponse> DescribePlaybookWithOptionsAsync(DescribePlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the XML configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookResponse
        /// </returns>
        public DescribePlaybookResponse DescribePlaybook(DescribePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the XML configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookResponse
        /// </returns>
        public async Task<DescribePlaybookResponse> DescribePlaybookAsync(DescribePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output parameter configurations of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookInputOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookInputOutputResponse
        /// </returns>
        public DescribePlaybookInputOutputResponse DescribePlaybookInputOutputWithOptions(DescribePlaybookInputOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookInputOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookInputOutputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output parameter configurations of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookInputOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookInputOutputResponse
        /// </returns>
        public async Task<DescribePlaybookInputOutputResponse> DescribePlaybookInputOutputWithOptionsAsync(DescribePlaybookInputOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookInputOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookInputOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output parameter configurations of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookInputOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookInputOutputResponse
        /// </returns>
        public DescribePlaybookInputOutputResponse DescribePlaybookInputOutput(DescribePlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookInputOutputWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output parameter configurations of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookInputOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookInputOutputResponse
        /// </returns>
        public async Task<DescribePlaybookInputOutputResponse> DescribePlaybookInputOutputAsync(DescribePlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookInputOutputWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookMetricsResponse
        /// </returns>
        public DescribePlaybookMetricsResponse DescribePlaybookMetricsWithOptions(DescribePlaybookMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookMetrics",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookMetricsResponse
        /// </returns>
        public async Task<DescribePlaybookMetricsResponse> DescribePlaybookMetricsWithOptionsAsync(DescribePlaybookMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookMetrics",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookMetricsResponse
        /// </returns>
        public DescribePlaybookMetricsResponse DescribePlaybookMetrics(DescribePlaybookMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookMetricsResponse
        /// </returns>
        public async Task<DescribePlaybookMetricsResponse> DescribePlaybookMetricsAsync(DescribePlaybookMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookMetricsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical output data of a component node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNodesOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNodesOutputResponse
        /// </returns>
        public DescribePlaybookNodesOutputResponse DescribePlaybookNodesOutputWithOptions(DescribePlaybookNodesOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookNodesOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookNodesOutputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical output data of a component node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNodesOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNodesOutputResponse
        /// </returns>
        public async Task<DescribePlaybookNodesOutputResponse> DescribePlaybookNodesOutputWithOptionsAsync(DescribePlaybookNodesOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookNodesOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookNodesOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical output data of a component node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNodesOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNodesOutputResponse
        /// </returns>
        public DescribePlaybookNodesOutputResponse DescribePlaybookNodesOutput(DescribePlaybookNodesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookNodesOutputWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical output data of a component node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNodesOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNodesOutputResponse
        /// </returns>
        public async Task<DescribePlaybookNodesOutputResponse> DescribePlaybookNodesOutputAsync(DescribePlaybookNodesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookNodesOutputWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNumberMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNumberMetricsResponse
        /// </returns>
        public DescribePlaybookNumberMetricsResponse DescribePlaybookNumberMetricsWithOptions(DescribePlaybookNumberMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookNumberMetrics",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookNumberMetricsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNumberMetricsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNumberMetricsResponse
        /// </returns>
        public async Task<DescribePlaybookNumberMetricsResponse> DescribePlaybookNumberMetricsWithOptionsAsync(DescribePlaybookNumberMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookNumberMetrics",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookNumberMetricsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNumberMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNumberMetricsResponse
        /// </returns>
        public DescribePlaybookNumberMetricsResponse DescribePlaybookNumberMetrics(DescribePlaybookNumberMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookNumberMetricsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookNumberMetricsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookNumberMetricsResponse
        /// </returns>
        public async Task<DescribePlaybookNumberMetricsResponse> DescribePlaybookNumberMetricsAsync(DescribePlaybookNumberMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookNumberMetricsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookReleasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookReleasesResponse
        /// </returns>
        public DescribePlaybookReleasesResponse DescribePlaybookReleasesWithOptions(DescribePlaybookReleasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookReleases",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookReleasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookReleasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookReleasesResponse
        /// </returns>
        public async Task<DescribePlaybookReleasesResponse> DescribePlaybookReleasesWithOptionsAsync(DescribePlaybookReleasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybookReleases",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybookReleasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookReleasesResponse
        /// </returns>
        public DescribePlaybookReleasesResponse DescribePlaybookReleases(DescribePlaybookReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookReleasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the published versions of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybookReleasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybookReleasesResponse
        /// </returns>
        public async Task<DescribePlaybookReleasesResponse> DescribePlaybookReleasesAsync(DescribePlaybookReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookReleasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybooksResponse
        /// </returns>
        public DescribePlaybooksResponse DescribePlaybooksWithOptions(DescribePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybooksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybooksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybooksResponse
        /// </returns>
        public async Task<DescribePlaybooksResponse> DescribePlaybooksWithOptionsAsync(DescribePlaybooksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePlaybooks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePlaybooksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybooksResponse
        /// </returns>
        public DescribePlaybooksResponse DescribePlaybooks(DescribePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybooksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries playbooks.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePlaybooksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePlaybooksResponse
        /// </returns>
        public async Task<DescribePlaybooksResponse> DescribePlaybooksAsync(DescribePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybooksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an API operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiResponse
        /// </returns>
        public DescribePopApiResponse DescribePopApiWithOptions(DescribePopApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApi",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an API operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiResponse
        /// </returns>
        public async Task<DescribePopApiResponse> DescribePopApiWithOptionsAsync(DescribePopApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApi",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an API operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiResponse
        /// </returns>
        public DescribePopApiResponse DescribePopApi(DescribePopApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an API operation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiResponse
        /// </returns>
        public async Task<DescribePopApiResponse> DescribePopApiAsync(DescribePopApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiItemListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiItemListResponse
        /// </returns>
        public DescribePopApiItemListResponse DescribePopApiItemListWithOptions(DescribePopApiItemListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApiItemList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiItemListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiItemListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiItemListResponse
        /// </returns>
        public async Task<DescribePopApiItemListResponse> DescribePopApiItemListWithOptionsAsync(DescribePopApiItemListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApiItemList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiItemListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiItemListResponse
        /// </returns>
        public DescribePopApiItemListResponse DescribePopApiItemList(DescribePopApiItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiItemListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiItemListResponse
        /// </returns>
        public async Task<DescribePopApiItemListResponse> DescribePopApiItemListAsync(DescribePopApiItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiItemListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version information of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiVersionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiVersionListResponse
        /// </returns>
        public DescribePopApiVersionListResponse DescribePopApiVersionListWithOptions(DescribePopApiVersionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApiVersionList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiVersionListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version information of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiVersionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiVersionListResponse
        /// </returns>
        public async Task<DescribePopApiVersionListResponse> DescribePopApiVersionListWithOptionsAsync(DescribePopApiVersionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePopApiVersionList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePopApiVersionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version information of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiVersionListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiVersionListResponse
        /// </returns>
        public DescribePopApiVersionListResponse DescribePopApiVersionList(DescribePopApiVersionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiVersionListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version information of API operations for an Alibaba Cloud service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePopApiVersionListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePopApiVersionListResponse
        /// </returns>
        public async Task<DescribePopApiVersionListResponse> DescribePopApiVersionListAsync(DescribePopApiVersionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiVersionListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProcessTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProcessTasksResponse
        /// </returns>
        public DescribeProcessTasksResponse DescribeProcessTasksWithOptions(DescribeProcessTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProcessTasks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProcessTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProcessTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeProcessTasksResponse
        /// </returns>
        public async Task<DescribeProcessTasksResponse> DescribeProcessTasksWithOptionsAsync(DescribeProcessTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeProcessTasks",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeProcessTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProcessTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProcessTasksResponse
        /// </returns>
        public DescribeProcessTasksResponse DescribeProcessTasks(DescribeProcessTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProcessTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeProcessTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeProcessTasksResponse
        /// </returns>
        public async Task<DescribeProcessTasksResponse> DescribeProcessTasksAsync(DescribeProcessTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProcessTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data that is returned when a component initiates an action in a playbook task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordActionOutputListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordActionOutputListResponse
        /// </returns>
        public DescribeSoarRecordActionOutputListResponse DescribeSoarRecordActionOutputListWithOptions(DescribeSoarRecordActionOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecordActionOutputList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordActionOutputListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data that is returned when a component initiates an action in a playbook task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordActionOutputListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordActionOutputListResponse
        /// </returns>
        public async Task<DescribeSoarRecordActionOutputListResponse> DescribeSoarRecordActionOutputListWithOptionsAsync(DescribeSoarRecordActionOutputListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecordActionOutputList",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordActionOutputListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data that is returned when a component initiates an action in a playbook task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordActionOutputListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordActionOutputListResponse
        /// </returns>
        public DescribeSoarRecordActionOutputListResponse DescribeSoarRecordActionOutputList(DescribeSoarRecordActionOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordActionOutputListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the data that is returned when a component initiates an action in a playbook task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordActionOutputListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordActionOutputListResponse
        /// </returns>
        public async Task<DescribeSoarRecordActionOutputListResponse> DescribeSoarRecordActionOutputListAsync(DescribeSoarRecordActionOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordActionOutputListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output data of a component action. You can call this operation after a playbook is run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordInOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordInOutputResponse
        /// </returns>
        public DescribeSoarRecordInOutputResponse DescribeSoarRecordInOutputWithOptions(DescribeSoarRecordInOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecordInOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordInOutputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output data of a component action. You can call this operation after a playbook is run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordInOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordInOutputResponse
        /// </returns>
        public async Task<DescribeSoarRecordInOutputResponse> DescribeSoarRecordInOutputWithOptionsAsync(DescribeSoarRecordInOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecordInOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordInOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output data of a component action. You can call this operation after a playbook is run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordInOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordInOutputResponse
        /// </returns>
        public DescribeSoarRecordInOutputResponse DescribeSoarRecordInOutput(DescribeSoarRecordInOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordInOutputWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the input and output data of a component action. You can call this operation after a playbook is run.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordInOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordInOutputResponse
        /// </returns>
        public async Task<DescribeSoarRecordInOutputResponse> DescribeSoarRecordInOutputAsync(DescribeSoarRecordInOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordInOutputWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordsResponse
        /// </returns>
        public DescribeSoarRecordsResponse DescribeSoarRecordsWithOptions(DescribeSoarRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecords",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordsResponse
        /// </returns>
        public async Task<DescribeSoarRecordsResponse> DescribeSoarRecordsWithOptionsAsync(DescribeSoarRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarRecords",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordsResponse
        /// </returns>
        public DescribeSoarRecordsResponse DescribeSoarRecords(DescribeSoarRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarRecordsResponse
        /// </returns>
        public async Task<DescribeSoarRecordsResponse> DescribeSoarRecordsAsync(DescribeSoarRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a component during the running of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarTaskAndActionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarTaskAndActionsResponse
        /// </returns>
        public DescribeSoarTaskAndActionsResponse DescribeSoarTaskAndActionsWithOptions(DescribeSoarTaskAndActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarTaskAndActions",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarTaskAndActionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a component during the running of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarTaskAndActionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarTaskAndActionsResponse
        /// </returns>
        public async Task<DescribeSoarTaskAndActionsResponse> DescribeSoarTaskAndActionsWithOptionsAsync(DescribeSoarTaskAndActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSoarTaskAndActions",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSoarTaskAndActionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a component during the running of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarTaskAndActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarTaskAndActionsResponse
        /// </returns>
        public DescribeSoarTaskAndActionsResponse DescribeSoarTaskAndActions(DescribeSoarTaskAndActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarTaskAndActionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution records of a component during the running of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSoarTaskAndActionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSoarTaskAndActionsResponse
        /// </returns>
        public async Task<DescribeSoarTaskAndActionsResponse> DescribeSoarTaskAndActionsAsync(DescribeSoarTaskAndActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarTaskAndActionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that can be run to obtain objects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSophonCommandsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSophonCommandsResponse
        /// </returns>
        public DescribeSophonCommandsResponse DescribeSophonCommandsWithOptions(DescribeSophonCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSophonCommands",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSophonCommandsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that can be run to obtain objects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSophonCommandsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSophonCommandsResponse
        /// </returns>
        public async Task<DescribeSophonCommandsResponse> DescribeSophonCommandsWithOptionsAsync(DescribeSophonCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSophonCommands",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSophonCommandsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that can be run to obtain objects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSophonCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSophonCommandsResponse
        /// </returns>
        public DescribeSophonCommandsResponse DescribeSophonCommands(DescribeSophonCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSophonCommandsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that can be run to obtain objects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSophonCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSophonCommandsResponse
        /// </returns>
        public async Task<DescribeSophonCommandsResponse> DescribeSophonCommandsAsync(DescribeSophonCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSophonCommandsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescriberPython3ScriptLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescriberPython3ScriptLogsResponse
        /// </returns>
        public DescriberPython3ScriptLogsResponse DescriberPython3ScriptLogsWithOptions(DescriberPython3ScriptLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescriberPython3ScriptLogs",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescriberPython3ScriptLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescriberPython3ScriptLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescriberPython3ScriptLogsResponse
        /// </returns>
        public async Task<DescriberPython3ScriptLogsResponse> DescriberPython3ScriptLogsWithOptionsAsync(DescriberPython3ScriptLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescriberPython3ScriptLogs",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescriberPython3ScriptLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescriberPython3ScriptLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescriberPython3ScriptLogsResponse
        /// </returns>
        public DescriberPython3ScriptLogsResponse DescriberPython3ScriptLogs(DescriberPython3ScriptLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescriberPython3ScriptLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescriberPython3ScriptLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescriberPython3ScriptLogsResponse
        /// </returns>
        public async Task<DescriberPython3ScriptLogsResponse> DescriberPython3ScriptLogsAsync(DescriberPython3ScriptLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescriberPython3ScriptLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about the asset that is configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyComponentAssetResponse
        /// </returns>
        public ModifyComponentAssetResponse ModifyComponentAssetWithOptions(ModifyComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetConfig))
            {
                query["AssetConfig"] = request.AssetConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyComponentAsset",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyComponentAssetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about the asset that is configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyComponentAssetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyComponentAssetResponse
        /// </returns>
        public async Task<ModifyComponentAssetResponse> ModifyComponentAssetWithOptionsAsync(ModifyComponentAssetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetConfig))
            {
                query["AssetConfig"] = request.AssetConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyComponentAsset",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyComponentAssetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about the asset that is configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyComponentAssetResponse
        /// </returns>
        public ModifyComponentAssetResponse ModifyComponentAsset(ModifyComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyComponentAssetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information about the asset that is configured for a component.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyComponentAssetRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyComponentAssetResponse
        /// </returns>
        public async Task<ModifyComponentAssetResponse> ModifyComponentAssetAsync(ModifyComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyComponentAssetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookResponse
        /// </returns>
        public ModifyPlaybookResponse ModifyPlaybookWithOptions(ModifyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taskflow))
            {
                body["Taskflow"] = request.Taskflow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookResponse
        /// </returns>
        public async Task<ModifyPlaybookResponse> ModifyPlaybookWithOptionsAsync(ModifyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taskflow))
            {
                body["Taskflow"] = request.Taskflow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookResponse
        /// </returns>
        public ModifyPlaybookResponse ModifyPlaybook(ModifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configuration of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookResponse
        /// </returns>
        public async Task<ModifyPlaybookResponse> ModifyPlaybookAsync(ModifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the input and output parameters of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInputOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInputOutputResponse
        /// </returns>
        public ModifyPlaybookInputOutputResponse ModifyPlaybookInputOutputWithOptions(ModifyPlaybookInputOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExeConfig))
            {
                body["ExeConfig"] = request.ExeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParams))
            {
                body["InputParams"] = request.InputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputParams))
            {
                body["OutputParams"] = request.OutputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybookInputOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookInputOutputResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the input and output parameters of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInputOutputRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInputOutputResponse
        /// </returns>
        public async Task<ModifyPlaybookInputOutputResponse> ModifyPlaybookInputOutputWithOptionsAsync(ModifyPlaybookInputOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExeConfig))
            {
                body["ExeConfig"] = request.ExeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParams))
            {
                body["InputParams"] = request.InputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                body["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputParams))
            {
                body["OutputParams"] = request.OutputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                body["ParamType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybookInputOutput",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookInputOutputResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the input and output parameters of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInputOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInputOutputResponse
        /// </returns>
        public ModifyPlaybookInputOutputResponse ModifyPlaybookInputOutput(ModifyPlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookInputOutputWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the input and output parameters of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInputOutputRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInputOutputResponse
        /// </returns>
        public async Task<ModifyPlaybookInputOutputResponse> ModifyPlaybookInputOutputAsync(ModifyPlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookInputOutputWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInstanceStatusResponse
        /// </returns>
        public ModifyPlaybookInstanceStatusResponse ModifyPlaybookInstanceStatusWithOptions(ModifyPlaybookInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybookInstanceStatus",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookInstanceStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInstanceStatusResponse
        /// </returns>
        public async Task<ModifyPlaybookInstanceStatusResponse> ModifyPlaybookInstanceStatusWithOptionsAsync(ModifyPlaybookInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Active))
            {
                body["Active"] = request.Active;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPlaybookInstanceStatus",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPlaybookInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInstanceStatusResponse
        /// </returns>
        public ModifyPlaybookInstanceStatusResponse ModifyPlaybookInstanceStatus(ModifyPlaybookInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookInstanceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the status of a playbook.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyPlaybookInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyPlaybookInstanceStatusResponse
        /// </returns>
        public async Task<ModifyPlaybookInstanceStatusResponse> ModifyPlaybookInstanceStatusAsync(ModifyPlaybookInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookInstanceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishPlaybookResponse
        /// </returns>
        public PublishPlaybookResponse PublishPlaybookWithOptions(PublishPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishPlaybookResponse
        /// </returns>
        public async Task<PublishPlaybookResponse> PublishPlaybookWithOptionsAsync(PublishPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishPlaybookResponse
        /// </returns>
        public PublishPlaybookResponse PublishPlaybook(PublishPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PublishPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishPlaybookResponse
        /// </returns>
        public async Task<PublishPlaybookResponse> PublishPlaybookAsync(PublishPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTreeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTreeDataResponse
        /// </returns>
        public QueryTreeDataResponse QueryTreeDataWithOptions(QueryTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTreeData",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTreeDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTreeDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTreeDataResponse
        /// </returns>
        public async Task<QueryTreeDataResponse> QueryTreeDataWithOptionsAsync(QueryTreeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTreeData",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTreeDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTreeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTreeDataResponse
        /// </returns>
        public QueryTreeDataResponse QueryTreeData(QueryTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTreeDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all playbooks at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTreeDataRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTreeDataResponse
        /// </returns>
        public async Task<QueryTreeDataResponse> QueryTreeDataAsync(QueryTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTreeDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenamePlaybookNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenamePlaybookNodeResponse
        /// </returns>
        public RenamePlaybookNodeResponse RenamePlaybookNodeWithOptions(RenamePlaybookNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewNodeName))
            {
                query["NewNodeName"] = request.NewNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldNodeName))
            {
                query["OldNodeName"] = request.OldNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                query["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenamePlaybookNode",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenamePlaybookNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenamePlaybookNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenamePlaybookNodeResponse
        /// </returns>
        public async Task<RenamePlaybookNodeResponse> RenamePlaybookNodeWithOptionsAsync(RenamePlaybookNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewNodeName))
            {
                query["NewNodeName"] = request.NewNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldNodeName))
            {
                query["OldNodeName"] = request.OldNodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                query["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenamePlaybookNode",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenamePlaybookNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenamePlaybookNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RenamePlaybookNodeResponse
        /// </returns>
        public RenamePlaybookNodeResponse RenamePlaybookNode(RenamePlaybookNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenamePlaybookNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RenamePlaybookNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// RenamePlaybookNodeResponse
        /// </returns>
        public async Task<RenamePlaybookNodeResponse> RenamePlaybookNodeAsync(RenamePlaybookNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenamePlaybookNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertPlaybookReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertPlaybookReleaseResponse
        /// </returns>
        public RevertPlaybookReleaseResponse RevertPlaybookReleaseWithOptions(RevertPlaybookReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublish))
            {
                body["IsPublish"] = request.IsPublish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayReleaseId))
            {
                body["PlayReleaseId"] = request.PlayReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertPlaybookRelease",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertPlaybookReleaseResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertPlaybookReleaseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertPlaybookReleaseResponse
        /// </returns>
        public async Task<RevertPlaybookReleaseResponse> RevertPlaybookReleaseWithOptionsAsync(RevertPlaybookReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPublish))
            {
                body["IsPublish"] = request.IsPublish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlayReleaseId))
            {
                body["PlayReleaseId"] = request.PlayReleaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertPlaybookRelease",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertPlaybookReleaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertPlaybookReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertPlaybookReleaseResponse
        /// </returns>
        public RevertPlaybookReleaseResponse RevertPlaybookRelease(RevertPlaybookReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertPlaybookReleaseWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertPlaybookReleaseRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertPlaybookReleaseResponse
        /// </returns>
        public async Task<RevertPlaybookReleaseResponse> RevertPlaybookReleaseAsync(RevertPlaybookReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertPlaybookReleaseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits and runs a Python3 script. You can call this operation only for data processing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.4c41281fWhbdPa#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunPython3ScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunPython3ScriptResponse
        /// </returns>
        public RunPython3ScriptResponse RunPython3ScriptWithOptions(RunPython3ScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                body["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonScript))
            {
                body["PythonScript"] = request.PythonScript;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunPython3Script",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunPython3ScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits and runs a Python3 script. You can call this operation only for data processing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.4c41281fWhbdPa#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunPython3ScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunPython3ScriptResponse
        /// </returns>
        public async Task<RunPython3ScriptResponse> RunPython3ScriptWithOptionsAsync(RunPython3ScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeName))
            {
                body["NodeName"] = request.NodeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Params))
            {
                body["Params"] = request.Params;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonScript))
            {
                body["PythonScript"] = request.PythonScript;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunPython3Script",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunPython3ScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits and runs a Python3 script. You can call this operation only for data processing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.4c41281fWhbdPa#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunPython3ScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// RunPython3ScriptResponse
        /// </returns>
        public RunPython3ScriptResponse RunPython3Script(RunPython3ScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunPython3ScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits and runs a Python3 script. You can call this operation only for data processing.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=openapi-amp.newDocPublishment.0.0.4c41281fWhbdPa#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RunPython3ScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// RunPython3ScriptResponse
        /// </returns>
        public async Task<RunPython3ScriptResponse> RunPython3ScriptAsync(RunPython3ScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunPython3ScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an enabled custom playbook or a predefined playbook.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerPlaybookResponse
        /// </returns>
        public TriggerPlaybookResponse TriggerPlaybookWithOptions(TriggerPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParam))
            {
                body["InputParam"] = request.InputParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an enabled custom playbook or a predefined playbook.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerPlaybookResponse
        /// </returns>
        public async Task<TriggerPlaybookResponse> TriggerPlaybookWithOptionsAsync(TriggerPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParam))
            {
                body["InputParam"] = request.InputParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an enabled custom playbook or a predefined playbook.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerPlaybookResponse
        /// </returns>
        public TriggerPlaybookResponse TriggerPlaybook(TriggerPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an enabled custom playbook or a predefined playbook.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerPlaybookResponse
        /// </returns>
        public async Task<TriggerPlaybookResponse> TriggerPlaybookAsync(TriggerPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerProcessTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerProcessTaskResponse
        /// </returns>
        public TriggerProcessTaskResponse TriggerProcessTaskWithOptions(TriggerProcessTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerProcessTask",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerProcessTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerProcessTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerProcessTaskResponse
        /// </returns>
        public async Task<TriggerProcessTaskResponse> TriggerProcessTaskWithOptionsAsync(TriggerProcessTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerProcessTask",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerProcessTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerProcessTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerProcessTaskResponse
        /// </returns>
        public TriggerProcessTaskResponse TriggerProcessTask(TriggerProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerProcessTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TriggerProcessTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerProcessTaskResponse
        /// </returns>
        public async Task<TriggerProcessTaskResponse> TriggerProcessTaskAsync(TriggerProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerProcessTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a playbook or a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerSophonPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerSophonPlaybookResponse
        /// </returns>
        public TriggerSophonPlaybookResponse TriggerSophonPlaybookWithOptions(TriggerSophonPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandName))
            {
                query["CommandName"] = request.CommandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParams))
            {
                query["InputParams"] = request.InputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                query["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerSophonPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerSophonPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a playbook or a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerSophonPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TriggerSophonPlaybookResponse
        /// </returns>
        public async Task<TriggerSophonPlaybookResponse> TriggerSophonPlaybookWithOptionsAsync(TriggerSophonPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandName))
            {
                query["CommandName"] = request.CommandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputParams))
            {
                query["InputParams"] = request.InputParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SophonTaskId))
            {
                query["SophonTaskId"] = request.SophonTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerType))
            {
                query["TriggerType"] = request.TriggerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                query["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerSophonPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerSophonPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a playbook or a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerSophonPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerSophonPlaybookResponse
        /// </returns>
        public TriggerSophonPlaybookResponse TriggerSophonPlaybook(TriggerSophonPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerSophonPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers a playbook or a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see <a href="https://www.alibabacloud.com/en/pricing-calculator?_p_lc=1&spm=a2796.7960336.3034855210.1.7adab91arMeIx2#/commodity/vm_intl">Pricing</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TriggerSophonPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// TriggerSophonPlaybookResponse
        /// </returns>
        public async Task<TriggerSophonPlaybookResponse> TriggerSophonPlaybookAsync(TriggerSophonPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerSophonPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPlaybookResponse
        /// </returns>
        public VerifyPlaybookResponse VerifyPlaybookWithOptions(VerifyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskFlow))
            {
                body["TaskFlow"] = request.TaskFlow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPlaybookResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPlaybookRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPlaybookResponse
        /// </returns>
        public async Task<VerifyPlaybookResponse> VerifyPlaybookWithOptionsAsync(VerifyPlaybookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlaybookUuid))
            {
                body["PlaybookUuid"] = request.PlaybookUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskFlow))
            {
                body["TaskFlow"] = request.TaskFlow;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPlaybook",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPlaybookResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPlaybookResponse
        /// </returns>
        public VerifyPlaybookResponse VerifyPlaybook(VerifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPlaybookWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPlaybookRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPlaybookResponse
        /// </returns>
        public async Task<VerifyPlaybookResponse> VerifyPlaybookAsync(VerifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPlaybookWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the syntax of a Python code snippet is correct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPythonFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPythonFileResponse
        /// </returns>
        public VerifyPythonFileResponse VerifyPythonFileWithOptions(VerifyPythonFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPythonFile",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPythonFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the syntax of a Python code snippet is correct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPythonFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyPythonFileResponse
        /// </returns>
        public async Task<VerifyPythonFileResponse> VerifyPythonFileWithOptionsAsync(VerifyPythonFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyPythonFile",
                Version = "2022-07-28",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyPythonFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the syntax of a Python code snippet is correct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPythonFileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPythonFileResponse
        /// </returns>
        public VerifyPythonFileResponse VerifyPythonFile(VerifyPythonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPythonFileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the syntax of a Python code snippet is correct.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyPythonFileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyPythonFileResponse
        /// </returns>
        public async Task<VerifyPythonFileResponse> VerifyPythonFileAsync(VerifyPythonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPythonFileWithOptionsAsync(request, runtime);
        }

    }
}
