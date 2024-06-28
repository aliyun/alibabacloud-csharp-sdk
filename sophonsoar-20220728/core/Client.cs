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

        /**
         * @summary Modifies the statuses of playbooks at a time.
         *
         * @param request BatchModifyInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchModifyInstanceStatusResponse
         */
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

        /**
         * @summary Modifies the statuses of playbooks at a time.
         *
         * @param request BatchModifyInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchModifyInstanceStatusResponse
         */
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

        /**
         * @summary Modifies the statuses of playbooks at a time.
         *
         * @param request BatchModifyInstanceStatusRequest
         * @return BatchModifyInstanceStatusResponse
         */
        public BatchModifyInstanceStatusResponse BatchModifyInstanceStatus(BatchModifyInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchModifyInstanceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the statuses of playbooks at a time.
         *
         * @param request BatchModifyInstanceStatusRequest
         * @return BatchModifyInstanceStatusResponse
         */
        public async Task<BatchModifyInstanceStatusResponse> BatchModifyInstanceStatusAsync(BatchModifyInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchModifyInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Compares configurations between two versions of a published playbook.
         *
         * @param request ComparePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ComparePlaybooksResponse
         */
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

        /**
         * @summary Compares configurations between two versions of a published playbook.
         *
         * @param request ComparePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ComparePlaybooksResponse
         */
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

        /**
         * @summary Compares configurations between two versions of a published playbook.
         *
         * @param request ComparePlaybooksRequest
         * @return ComparePlaybooksResponse
         */
        public ComparePlaybooksResponse ComparePlaybooks(ComparePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ComparePlaybooksWithOptions(request, runtime);
        }

        /**
         * @summary Compares configurations between two versions of a published playbook.
         *
         * @param request ComparePlaybooksRequest
         * @return ComparePlaybooksResponse
         */
        public async Task<ComparePlaybooksResponse> ComparePlaybooksAsync(ComparePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ComparePlaybooksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a playbook.
         *
         * @param request CreatePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePlaybookResponse
         */
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

        /**
         * @summary Creates a playbook.
         *
         * @param request CreatePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePlaybookResponse
         */
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

        /**
         * @summary Creates a playbook.
         *
         * @param request CreatePlaybookRequest
         * @return CreatePlaybookResponse
         */
        public CreatePlaybookResponse CreatePlaybook(CreatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Creates a playbook.
         *
         * @param request CreatePlaybookRequest
         * @return CreatePlaybookResponse
         */
        public async Task<CreatePlaybookResponse> CreatePlaybookAsync(CreatePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Debugs a playbook.
         *
         * @param request DebugPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugPlaybookResponse
         */
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

        /**
         * @summary Debugs a playbook.
         *
         * @param request DebugPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DebugPlaybookResponse
         */
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

        /**
         * @summary Debugs a playbook.
         *
         * @param request DebugPlaybookRequest
         * @return DebugPlaybookResponse
         */
        public DebugPlaybookResponse DebugPlaybook(DebugPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DebugPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Debugs a playbook.
         *
         * @param request DebugPlaybookRequest
         * @return DebugPlaybookResponse
         */
        public async Task<DebugPlaybookResponse> DebugPlaybookAsync(DebugPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DebugPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes the assets in a component.
         *
         * @param request DeleteComponentAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteComponentAssetResponse
         */
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

        /**
         * @summary Deletes the assets in a component.
         *
         * @param request DeleteComponentAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteComponentAssetResponse
         */
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

        /**
         * @summary Deletes the assets in a component.
         *
         * @param request DeleteComponentAssetRequest
         * @return DeleteComponentAssetResponse
         */
        public DeleteComponentAssetResponse DeleteComponentAsset(DeleteComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteComponentAssetWithOptions(request, runtime);
        }

        /**
         * @summary Deletes the assets in a component.
         *
         * @param request DeleteComponentAssetRequest
         * @return DeleteComponentAssetResponse
         */
        public async Task<DeleteComponentAssetResponse> DeleteComponentAssetAsync(DeleteComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteComponentAssetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a custom playbook.
         *
         * @param request DeletePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlaybookResponse
         */
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

        /**
         * @summary Deletes a custom playbook.
         *
         * @param request DeletePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePlaybookResponse
         */
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

        /**
         * @summary Deletes a custom playbook.
         *
         * @param request DeletePlaybookRequest
         * @return DeletePlaybookResponse
         */
        public DeletePlaybookResponse DeletePlaybook(DeletePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a custom playbook.
         *
         * @param request DeletePlaybookRequest
         * @return DeletePlaybookResponse
         */
        public async Task<DeletePlaybookResponse> DeletePlaybookAsync(DeletePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the API operations of the cloud service.
         *
         * @param request DescribeApiListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApiListResponse
         */
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

        /**
         * @summary Queries the API operations of the cloud service.
         *
         * @param request DescribeApiListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApiListResponse
         */
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

        /**
         * @summary Queries the API operations of the cloud service.
         *
         * @param request DescribeApiListRequest
         * @return DescribeApiListResponse
         */
        public DescribeApiListResponse DescribeApiList(DescribeApiListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the API operations of the cloud service.
         *
         * @param request DescribeApiListRequest
         * @return DescribeApiListResponse
         */
        public async Task<DescribeApiListResponse> DescribeApiListAsync(DescribeApiListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.
         *
         * @param request DescribeComponentAssetFormRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentAssetFormResponse
         */
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

        /**
         * @summary Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.
         *
         * @param request DescribeComponentAssetFormRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentAssetFormResponse
         */
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

        /**
         * @summary Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.
         *
         * @param request DescribeComponentAssetFormRequest
         * @return DescribeComponentAssetFormResponse
         */
        public DescribeComponentAssetFormResponse DescribeComponentAssetForm(DescribeComponentAssetFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentAssetFormWithOptions(request, runtime);
        }

        /**
         * @summary Queries the metadata of assets in a component. The metadata of an asset refers to the fields that describe the asset.
         *
         * @param request DescribeComponentAssetFormRequest
         * @return DescribeComponentAssetFormResponse
         */
        public async Task<DescribeComponentAssetFormResponse> DescribeComponentAssetFormAsync(DescribeComponentAssetFormRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentAssetFormWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of assets in a component.
         *
         * @param request DescribeComponentAssetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentAssetsResponse
         */
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

        /**
         * @summary Queries a list of assets in a component.
         *
         * @param request DescribeComponentAssetsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentAssetsResponse
         */
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

        /**
         * @summary Queries a list of assets in a component.
         *
         * @param request DescribeComponentAssetsRequest
         * @return DescribeComponentAssetsResponse
         */
        public DescribeComponentAssetsResponse DescribeComponentAssets(DescribeComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentAssetsWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of assets in a component.
         *
         * @param request DescribeComponentAssetsRequest
         * @return DescribeComponentAssetsResponse
         */
        public async Task<DescribeComponentAssetsResponse> DescribeComponentAssetsAsync(DescribeComponentAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentAssetsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of common components that are available.
         *
         * @param request DescribeComponentListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentListResponse
         */
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

        /**
         * @summary Queries a list of common components that are available.
         *
         * @param request DescribeComponentListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentListResponse
         */
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

        /**
         * @summary Queries a list of common components that are available.
         *
         * @param request DescribeComponentListRequest
         * @return DescribeComponentListResponse
         */
        public DescribeComponentListResponse DescribeComponentList(DescribeComponentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentListWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of common components that are available.
         *
         * @param request DescribeComponentListRequest
         * @return DescribeComponentListResponse
         */
        public async Task<DescribeComponentListResponse> DescribeComponentListAsync(DescribeComponentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of predefined components that are available.
         *
         * @param request DescribeComponentPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentPlaybookResponse
         */
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

        /**
         * @summary Queries a list of predefined components that are available.
         *
         * @param request DescribeComponentPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentPlaybookResponse
         */
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

        /**
         * @summary Queries a list of predefined components that are available.
         *
         * @param request DescribeComponentPlaybookRequest
         * @return DescribeComponentPlaybookResponse
         */
        public DescribeComponentPlaybookResponse DescribeComponentPlaybook(DescribeComponentPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of predefined components that are available.
         *
         * @param request DescribeComponentPlaybookRequest
         * @return DescribeComponentPlaybookResponse
         */
        public async Task<DescribeComponentPlaybookResponse> DescribeComponentPlaybookAsync(DescribeComponentPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.
         *
         * @param request DescribeComponentsJsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentsJsResponse
         */
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

        /**
         * @summary Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.
         *
         * @param request DescribeComponentsJsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentsJsResponse
         */
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

        /**
         * @summary Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.
         *
         * @param request DescribeComponentsJsRequest
         * @return DescribeComponentsJsResponse
         */
        public DescribeComponentsJsResponse DescribeComponentsJs(DescribeComponentsJsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComponentsJsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the JavaScript file of a component. The component uses the returned JavaScript file for page rendering.
         *
         * @param request DescribeComponentsJsRequest
         * @return DescribeComponentsJsResponse
         */
        public async Task<DescribeComponentsJsResponse> DescribeComponentsJsAsync(DescribeComponentsJsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComponentsJsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the published versions of a playbook after deduplication.
         *
         * @param request DescribeDistinctReleasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDistinctReleasesResponse
         */
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

        /**
         * @summary Queries the information about the published versions of a playbook after deduplication.
         *
         * @param request DescribeDistinctReleasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDistinctReleasesResponse
         */
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

        /**
         * @summary Queries the information about the published versions of a playbook after deduplication.
         *
         * @param request DescribeDistinctReleasesRequest
         * @return DescribeDistinctReleasesResponse
         */
        public DescribeDistinctReleasesResponse DescribeDistinctReleases(DescribeDistinctReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDistinctReleasesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the published versions of a playbook after deduplication.
         *
         * @param request DescribeDistinctReleasesRequest
         * @return DescribeDistinctReleasesResponse
         */
        public async Task<DescribeDistinctReleasesResponse> DescribeDistinctReleasesAsync(DescribeDistinctReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDistinctReleasesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries enumeration items that are required by a cloud service.
         *
         * @param request DescribeEnumItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEnumItemsResponse
         */
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

        /**
         * @summary Queries enumeration items that are required by a cloud service.
         *
         * @param request DescribeEnumItemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEnumItemsResponse
         */
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

        /**
         * @summary Queries enumeration items that are required by a cloud service.
         *
         * @param request DescribeEnumItemsRequest
         * @return DescribeEnumItemsResponse
         */
        public DescribeEnumItemsResponse DescribeEnumItems(DescribeEnumItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEnumItemsWithOptions(request, runtime);
        }

        /**
         * @summary Queries enumeration items that are required by a cloud service.
         *
         * @param request DescribeEnumItemsRequest
         * @return DescribeEnumItemsResponse
         */
        public async Task<DescribeEnumItemsResponse> DescribeEnumItemsAsync(DescribeEnumItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEnumItemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the playbooks that are available for an automatic response plan.
         *
         * @param request DescribeExecutePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExecutePlaybooksResponse
         */
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

        /**
         * @summary Queries the playbooks that are available for an automatic response plan.
         *
         * @param request DescribeExecutePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExecutePlaybooksResponse
         */
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

        /**
         * @summary Queries the playbooks that are available for an automatic response plan.
         *
         * @param request DescribeExecutePlaybooksRequest
         * @return DescribeExecutePlaybooksResponse
         */
        public DescribeExecutePlaybooksResponse DescribeExecutePlaybooks(DescribeExecutePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutePlaybooksWithOptions(request, runtime);
        }

        /**
         * @summary Queries the playbooks that are available for an automatic response plan.
         *
         * @param request DescribeExecutePlaybooksRequest
         * @return DescribeExecutePlaybooksResponse
         */
        public async Task<DescribeExecutePlaybooksResponse> DescribeExecutePlaybooksAsync(DescribeExecutePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutePlaybooksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the global configuration information about a cloud service.
         *
         * @param request DescribeFieldRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFieldResponse
         */
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

        /**
         * @summary Queries the global configuration information about a cloud service.
         *
         * @param request DescribeFieldRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFieldResponse
         */
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

        /**
         * @summary Queries the global configuration information about a cloud service.
         *
         * @param request DescribeFieldRequest
         * @return DescribeFieldResponse
         */
        public DescribeFieldResponse DescribeField(DescribeFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFieldWithOptions(request, runtime);
        }

        /**
         * @summary Queries the global configuration information about a cloud service.
         *
         * @param request DescribeFieldRequest
         * @return DescribeFieldResponse
         */
        public async Task<DescribeFieldResponse> DescribeFieldAsync(DescribeFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFieldWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.
         *
         * @param request DescribeLatestRecordSchemaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLatestRecordSchemaResponse
         */
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

        /**
         * @summary Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.
         *
         * @param request DescribeLatestRecordSchemaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLatestRecordSchemaResponse
         */
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

        /**
         * @summary Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.
         *
         * @param request DescribeLatestRecordSchemaRequest
         * @return DescribeLatestRecordSchemaResponse
         */
        public DescribeLatestRecordSchemaResponse DescribeLatestRecordSchema(DescribeLatestRecordSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLatestRecordSchemaWithOptions(request, runtime);
        }

        /**
         * @summary Queries the output structure information of each node in a playbook based on the most recent running record of the playbook.
         *
         * @param request DescribeLatestRecordSchemaRequest
         * @return DescribeLatestRecordSchemaResponse
         */
        public async Task<DescribeLatestRecordSchemaResponse> DescribeLatestRecordSchemaAsync(DescribeLatestRecordSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLatestRecordSchemaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries recommended dynamic input parameters of a component for playbook orchestration.
         *
         * @param request DescribeNodeParamTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeParamTagsResponse
         */
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

        /**
         * @summary Queries recommended dynamic input parameters of a component for playbook orchestration.
         *
         * @param request DescribeNodeParamTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeParamTagsResponse
         */
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

        /**
         * @summary Queries recommended dynamic input parameters of a component for playbook orchestration.
         *
         * @param request DescribeNodeParamTagsRequest
         * @return DescribeNodeParamTagsResponse
         */
        public DescribeNodeParamTagsResponse DescribeNodeParamTags(DescribeNodeParamTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeParamTagsWithOptions(request, runtime);
        }

        /**
         * @summary Queries recommended dynamic input parameters of a component for playbook orchestration.
         *
         * @param request DescribeNodeParamTagsRequest
         * @return DescribeNodeParamTagsResponse
         */
        public async Task<DescribeNodeParamTagsResponse> DescribeNodeParamTagsAsync(DescribeNodeParamTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeParamTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the nodes that reference the same node in a playbook.
         *
         * @param request DescribeNodeUsedInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeUsedInfosResponse
         */
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

        /**
         * @summary Queries the nodes that reference the same node in a playbook.
         *
         * @param request DescribeNodeUsedInfosRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodeUsedInfosResponse
         */
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

        /**
         * @summary Queries the nodes that reference the same node in a playbook.
         *
         * @param request DescribeNodeUsedInfosRequest
         * @return DescribeNodeUsedInfosResponse
         */
        public DescribeNodeUsedInfosResponse DescribeNodeUsedInfos(DescribeNodeUsedInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNodeUsedInfosWithOptions(request, runtime);
        }

        /**
         * @summary Queries the nodes that reference the same node in a playbook.
         *
         * @param request DescribeNodeUsedInfosRequest
         * @return DescribeNodeUsedInfosResponse
         */
        public async Task<DescribeNodeUsedInfosResponse> DescribeNodeUsedInfosAsync(DescribeNodeUsedInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNodeUsedInfosWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the XML configuration of a playbook.
         *
         * @param request DescribePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookResponse
         */
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

        /**
         * @summary Queries the XML configuration of a playbook.
         *
         * @param request DescribePlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookResponse
         */
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

        /**
         * @summary Queries the XML configuration of a playbook.
         *
         * @param request DescribePlaybookRequest
         * @return DescribePlaybookResponse
         */
        public DescribePlaybookResponse DescribePlaybook(DescribePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Queries the XML configuration of a playbook.
         *
         * @param request DescribePlaybookRequest
         * @return DescribePlaybookResponse
         */
        public async Task<DescribePlaybookResponse> DescribePlaybookAsync(DescribePlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the input and output parameter configurations of a playbook.
         *
         * @param request DescribePlaybookInputOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookInputOutputResponse
         */
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

        /**
         * @summary Queries the input and output parameter configurations of a playbook.
         *
         * @param request DescribePlaybookInputOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookInputOutputResponse
         */
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

        /**
         * @summary Queries the input and output parameter configurations of a playbook.
         *
         * @param request DescribePlaybookInputOutputRequest
         * @return DescribePlaybookInputOutputResponse
         */
        public DescribePlaybookInputOutputResponse DescribePlaybookInputOutput(DescribePlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookInputOutputWithOptions(request, runtime);
        }

        /**
         * @summary Queries the input and output parameter configurations of a playbook.
         *
         * @param request DescribePlaybookInputOutputRequest
         * @return DescribePlaybookInputOutputResponse
         */
        public async Task<DescribePlaybookInputOutputResponse> DescribePlaybookInputOutputAsync(DescribePlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookInputOutputWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.
         *
         * @param request DescribePlaybookMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookMetricsResponse
         */
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

        /**
         * @summary Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.
         *
         * @param request DescribePlaybookMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookMetricsResponse
         */
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

        /**
         * @summary Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.
         *
         * @param request DescribePlaybookMetricsRequest
         * @return DescribePlaybookMetricsResponse
         */
        public DescribePlaybookMetricsResponse DescribePlaybookMetrics(DescribePlaybookMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookMetricsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the metrics of a playbook. The metrics include the playbook name, playbook description, the number of times that the playbook is run, and the failure rate of the playbook.
         *
         * @param request DescribePlaybookMetricsRequest
         * @return DescribePlaybookMetricsResponse
         */
        public async Task<DescribePlaybookMetricsResponse> DescribePlaybookMetricsAsync(DescribePlaybookMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the historical output data of a component node.
         *
         * @param request DescribePlaybookNodesOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookNodesOutputResponse
         */
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

        /**
         * @summary Queries the historical output data of a component node.
         *
         * @param request DescribePlaybookNodesOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookNodesOutputResponse
         */
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

        /**
         * @summary Queries the historical output data of a component node.
         *
         * @param request DescribePlaybookNodesOutputRequest
         * @return DescribePlaybookNodesOutputResponse
         */
        public DescribePlaybookNodesOutputResponse DescribePlaybookNodesOutput(DescribePlaybookNodesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookNodesOutputWithOptions(request, runtime);
        }

        /**
         * @summary Queries the historical output data of a component node.
         *
         * @param request DescribePlaybookNodesOutputRequest
         * @return DescribePlaybookNodesOutputResponse
         */
        public async Task<DescribePlaybookNodesOutputResponse> DescribePlaybookNodesOutputAsync(DescribePlaybookNodesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookNodesOutputWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.
         *
         * @param request DescribePlaybookNumberMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookNumberMetricsResponse
         */
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

        /**
         * @summary Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.
         *
         * @param request DescribePlaybookNumberMetricsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookNumberMetricsResponse
         */
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

        /**
         * @summary Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.
         *
         * @param request DescribePlaybookNumberMetricsRequest
         * @return DescribePlaybookNumberMetricsResponse
         */
        public DescribePlaybookNumberMetricsResponse DescribePlaybookNumberMetrics(DescribePlaybookNumberMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookNumberMetricsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statistics of Security Orchestration Automation Response (SOAR), such as the numbers of created and enabled playbooks.
         *
         * @param request DescribePlaybookNumberMetricsRequest
         * @return DescribePlaybookNumberMetricsResponse
         */
        public async Task<DescribePlaybookNumberMetricsResponse> DescribePlaybookNumberMetricsAsync(DescribePlaybookNumberMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookNumberMetricsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about the published versions of a playbook.
         *
         * @param request DescribePlaybookReleasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookReleasesResponse
         */
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

        /**
         * @summary Queries the information about the published versions of a playbook.
         *
         * @param request DescribePlaybookReleasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybookReleasesResponse
         */
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

        /**
         * @summary Queries the information about the published versions of a playbook.
         *
         * @param request DescribePlaybookReleasesRequest
         * @return DescribePlaybookReleasesResponse
         */
        public DescribePlaybookReleasesResponse DescribePlaybookReleases(DescribePlaybookReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybookReleasesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about the published versions of a playbook.
         *
         * @param request DescribePlaybookReleasesRequest
         * @return DescribePlaybookReleasesResponse
         */
        public async Task<DescribePlaybookReleasesResponse> DescribePlaybookReleasesAsync(DescribePlaybookReleasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybookReleasesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries playbooks.
         *
         * @param request DescribePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybooksResponse
         */
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

        /**
         * @summary Queries playbooks.
         *
         * @param request DescribePlaybooksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePlaybooksResponse
         */
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

        /**
         * @summary Queries playbooks.
         *
         * @param request DescribePlaybooksRequest
         * @return DescribePlaybooksResponse
         */
        public DescribePlaybooksResponse DescribePlaybooks(DescribePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePlaybooksWithOptions(request, runtime);
        }

        /**
         * @summary Queries playbooks.
         *
         * @param request DescribePlaybooksRequest
         * @return DescribePlaybooksResponse
         */
        public async Task<DescribePlaybooksResponse> DescribePlaybooksAsync(DescribePlaybooksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePlaybooksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of an API operation.
         *
         * @param request DescribePopApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiResponse
         */
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

        /**
         * @summary Queries the details of an API operation.
         *
         * @param request DescribePopApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiResponse
         */
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

        /**
         * @summary Queries the details of an API operation.
         *
         * @param request DescribePopApiRequest
         * @return DescribePopApiResponse
         */
        public DescribePopApiResponse DescribePopApi(DescribePopApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of an API operation.
         *
         * @param request DescribePopApiRequest
         * @return DescribePopApiResponse
         */
        public async Task<DescribePopApiResponse> DescribePopApiAsync(DescribePopApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiItemListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiItemListResponse
         */
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

        /**
         * @summary Queries a list of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiItemListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiItemListResponse
         */
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

        /**
         * @summary Queries a list of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiItemListRequest
         * @return DescribePopApiItemListResponse
         */
        public DescribePopApiItemListResponse DescribePopApiItemList(DescribePopApiItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiItemListWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiItemListRequest
         * @return DescribePopApiItemListResponse
         */
        public async Task<DescribePopApiItemListResponse> DescribePopApiItemListAsync(DescribePopApiItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiItemListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the version information of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiVersionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiVersionListResponse
         */
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

        /**
         * @summary Queries the version information of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiVersionListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePopApiVersionListResponse
         */
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

        /**
         * @summary Queries the version information of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiVersionListRequest
         * @return DescribePopApiVersionListResponse
         */
        public DescribePopApiVersionListResponse DescribePopApiVersionList(DescribePopApiVersionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePopApiVersionListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the version information of API operations for an Alibaba Cloud service.
         *
         * @param request DescribePopApiVersionListRequest
         * @return DescribePopApiVersionListResponse
         */
        public async Task<DescribePopApiVersionListResponse> DescribePopApiVersionListAsync(DescribePopApiVersionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePopApiVersionListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.
         *
         * @param request DescribeProcessTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProcessTasksResponse
         */
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

        /**
         * @summary Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.
         *
         * @param request DescribeProcessTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeProcessTasksResponse
         */
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

        /**
         * @summary Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.
         *
         * @param request DescribeProcessTasksRequest
         * @return DescribeProcessTasksResponse
         */
        public DescribeProcessTasksResponse DescribeProcessTasks(DescribeProcessTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProcessTasksWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about handling tasks. When you use Security Orchestration Automation Response (SOAR) to handle events, handling tasks are generated in the handling center.
         *
         * @param request DescribeProcessTasksRequest
         * @return DescribeProcessTasksResponse
         */
        public async Task<DescribeProcessTasksResponse> DescribeProcessTasksAsync(DescribeProcessTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProcessTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the data that is returned when a component initiates an action in a playbook task.
         *
         * @param request DescribeSoarRecordActionOutputListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordActionOutputListResponse
         */
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

        /**
         * @summary Queries the data that is returned when a component initiates an action in a playbook task.
         *
         * @param request DescribeSoarRecordActionOutputListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordActionOutputListResponse
         */
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

        /**
         * @summary Queries the data that is returned when a component initiates an action in a playbook task.
         *
         * @param request DescribeSoarRecordActionOutputListRequest
         * @return DescribeSoarRecordActionOutputListResponse
         */
        public DescribeSoarRecordActionOutputListResponse DescribeSoarRecordActionOutputList(DescribeSoarRecordActionOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordActionOutputListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the data that is returned when a component initiates an action in a playbook task.
         *
         * @param request DescribeSoarRecordActionOutputListRequest
         * @return DescribeSoarRecordActionOutputListResponse
         */
        public async Task<DescribeSoarRecordActionOutputListResponse> DescribeSoarRecordActionOutputListAsync(DescribeSoarRecordActionOutputListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordActionOutputListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the input and output data of a component action. You can call this operation after a playbook is run.
         *
         * @param request DescribeSoarRecordInOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordInOutputResponse
         */
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

        /**
         * @summary Queries the input and output data of a component action. You can call this operation after a playbook is run.
         *
         * @param request DescribeSoarRecordInOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordInOutputResponse
         */
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

        /**
         * @summary Queries the input and output data of a component action. You can call this operation after a playbook is run.
         *
         * @param request DescribeSoarRecordInOutputRequest
         * @return DescribeSoarRecordInOutputResponse
         */
        public DescribeSoarRecordInOutputResponse DescribeSoarRecordInOutput(DescribeSoarRecordInOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordInOutputWithOptions(request, runtime);
        }

        /**
         * @summary Queries the input and output data of a component action. You can call this operation after a playbook is run.
         *
         * @param request DescribeSoarRecordInOutputRequest
         * @return DescribeSoarRecordInOutputResponse
         */
        public async Task<DescribeSoarRecordInOutputResponse> DescribeSoarRecordInOutputAsync(DescribeSoarRecordInOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordInOutputWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution records of a playbook.
         *
         * @param request DescribeSoarRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordsResponse
         */
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

        /**
         * @summary Queries the execution records of a playbook.
         *
         * @param request DescribeSoarRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarRecordsResponse
         */
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

        /**
         * @summary Queries the execution records of a playbook.
         *
         * @param request DescribeSoarRecordsRequest
         * @return DescribeSoarRecordsResponse
         */
        public DescribeSoarRecordsResponse DescribeSoarRecords(DescribeSoarRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution records of a playbook.
         *
         * @param request DescribeSoarRecordsRequest
         * @return DescribeSoarRecordsResponse
         */
        public async Task<DescribeSoarRecordsResponse> DescribeSoarRecordsAsync(DescribeSoarRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the execution records of a component during the running of a playbook.
         *
         * @param request DescribeSoarTaskAndActionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarTaskAndActionsResponse
         */
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

        /**
         * @summary Queries the execution records of a component during the running of a playbook.
         *
         * @param request DescribeSoarTaskAndActionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSoarTaskAndActionsResponse
         */
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

        /**
         * @summary Queries the execution records of a component during the running of a playbook.
         *
         * @param request DescribeSoarTaskAndActionsRequest
         * @return DescribeSoarTaskAndActionsResponse
         */
        public DescribeSoarTaskAndActionsResponse DescribeSoarTaskAndActions(DescribeSoarTaskAndActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSoarTaskAndActionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the execution records of a component during the running of a playbook.
         *
         * @param request DescribeSoarTaskAndActionsRequest
         * @return DescribeSoarTaskAndActionsResponse
         */
        public async Task<DescribeSoarTaskAndActionsResponse> DescribeSoarTaskAndActionsAsync(DescribeSoarTaskAndActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSoarTaskAndActionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the commands that can be run to obtain objects.
         *
         * @param request DescribeSophonCommandsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSophonCommandsResponse
         */
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

        /**
         * @summary Queries the commands that can be run to obtain objects.
         *
         * @param request DescribeSophonCommandsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSophonCommandsResponse
         */
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

        /**
         * @summary Queries the commands that can be run to obtain objects.
         *
         * @param request DescribeSophonCommandsRequest
         * @return DescribeSophonCommandsResponse
         */
        public DescribeSophonCommandsResponse DescribeSophonCommands(DescribeSophonCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSophonCommandsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the commands that can be run to obtain objects.
         *
         * @param request DescribeSophonCommandsRequest
         * @return DescribeSophonCommandsResponse
         */
        public async Task<DescribeSophonCommandsResponse> DescribeSophonCommandsAsync(DescribeSophonCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSophonCommandsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.
         *
         * @param request DescriberPython3ScriptLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescriberPython3ScriptLogsResponse
         */
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

        /**
         * @summary Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.
         *
         * @param request DescriberPython3ScriptLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescriberPython3ScriptLogsResponse
         */
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

        /**
         * @summary Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.
         *
         * @param request DescriberPython3ScriptLogsRequest
         * @return DescriberPython3ScriptLogsResponse
         */
        public DescriberPython3ScriptLogsResponse DescriberPython3ScriptLogs(DescriberPython3ScriptLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescriberPython3ScriptLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the operational logs of a Python3 script by using the UUID that is returned when the script is run. The UUID is specified by requestUuid.
         *
         * @param request DescriberPython3ScriptLogsRequest
         * @return DescriberPython3ScriptLogsResponse
         */
        public async Task<DescriberPython3ScriptLogsResponse> DescriberPython3ScriptLogsAsync(DescriberPython3ScriptLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescriberPython3ScriptLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the information about the asset that is configured for a component.
         *
         * @param request ModifyComponentAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyComponentAssetResponse
         */
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

        /**
         * @summary Modifies the information about the asset that is configured for a component.
         *
         * @param request ModifyComponentAssetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyComponentAssetResponse
         */
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

        /**
         * @summary Modifies the information about the asset that is configured for a component.
         *
         * @param request ModifyComponentAssetRequest
         * @return ModifyComponentAssetResponse
         */
        public ModifyComponentAssetResponse ModifyComponentAsset(ModifyComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyComponentAssetWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the information about the asset that is configured for a component.
         *
         * @param request ModifyComponentAssetRequest
         * @return ModifyComponentAssetResponse
         */
        public async Task<ModifyComponentAssetResponse> ModifyComponentAssetAsync(ModifyComponentAssetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyComponentAssetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configuration of a playbook.
         *
         * @param request ModifyPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookResponse
         */
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

        /**
         * @summary Modifies the configuration of a playbook.
         *
         * @param request ModifyPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookResponse
         */
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

        /**
         * @summary Modifies the configuration of a playbook.
         *
         * @param request ModifyPlaybookRequest
         * @return ModifyPlaybookResponse
         */
        public ModifyPlaybookResponse ModifyPlaybook(ModifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configuration of a playbook.
         *
         * @param request ModifyPlaybookRequest
         * @return ModifyPlaybookResponse
         */
        public async Task<ModifyPlaybookResponse> ModifyPlaybookAsync(ModifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the input and output parameters of a playbook.
         *
         * @param request ModifyPlaybookInputOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookInputOutputResponse
         */
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

        /**
         * @summary Modifies the input and output parameters of a playbook.
         *
         * @param request ModifyPlaybookInputOutputRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookInputOutputResponse
         */
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

        /**
         * @summary Modifies the input and output parameters of a playbook.
         *
         * @param request ModifyPlaybookInputOutputRequest
         * @return ModifyPlaybookInputOutputResponse
         */
        public ModifyPlaybookInputOutputResponse ModifyPlaybookInputOutput(ModifyPlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookInputOutputWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the input and output parameters of a playbook.
         *
         * @param request ModifyPlaybookInputOutputRequest
         * @return ModifyPlaybookInputOutputResponse
         */
        public async Task<ModifyPlaybookInputOutputResponse> ModifyPlaybookInputOutputAsync(ModifyPlaybookInputOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookInputOutputWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the status of a playbook.
         *
         * @param request ModifyPlaybookInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookInstanceStatusResponse
         */
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

        /**
         * @summary Modifies the status of a playbook.
         *
         * @param request ModifyPlaybookInstanceStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPlaybookInstanceStatusResponse
         */
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

        /**
         * @summary Modifies the status of a playbook.
         *
         * @param request ModifyPlaybookInstanceStatusRequest
         * @return ModifyPlaybookInstanceStatusResponse
         */
        public ModifyPlaybookInstanceStatusResponse ModifyPlaybookInstanceStatus(ModifyPlaybookInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlaybookInstanceStatusWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the status of a playbook.
         *
         * @param request ModifyPlaybookInstanceStatusRequest
         * @return ModifyPlaybookInstanceStatusResponse
         */
        public async Task<ModifyPlaybookInstanceStatusResponse> ModifyPlaybookInstanceStatusAsync(ModifyPlaybookInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlaybookInstanceStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.
         *
         * @param request PublishPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishPlaybookResponse
         */
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

        /**
         * @summary Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.
         *
         * @param request PublishPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishPlaybookResponse
         */
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

        /**
         * @summary Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.
         *
         * @param request PublishPlaybookRequest
         * @return PublishPlaybookResponse
         */
        public PublishPlaybookResponse PublishPlaybook(PublishPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Publishes the playbook. After the playbook is published, the playbook runs based on the new logic.
         *
         * @param request PublishPlaybookRequest
         * @return PublishPlaybookResponse
         */
        public async Task<PublishPlaybookResponse> PublishPlaybookAsync(PublishPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all playbooks at a time.
         *
         * @param request QueryTreeDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTreeDataResponse
         */
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

        /**
         * @summary Queries all playbooks at a time.
         *
         * @param request QueryTreeDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTreeDataResponse
         */
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

        /**
         * @summary Queries all playbooks at a time.
         *
         * @param request QueryTreeDataRequest
         * @return QueryTreeDataResponse
         */
        public QueryTreeDataResponse QueryTreeData(QueryTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTreeDataWithOptions(request, runtime);
        }

        /**
         * @summary Queries all playbooks at a time.
         *
         * @param request QueryTreeDataRequest
         * @return QueryTreeDataResponse
         */
        public async Task<QueryTreeDataResponse> QueryTreeDataAsync(QueryTreeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTreeDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.
         *
         * @param request RenamePlaybookNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenamePlaybookNodeResponse
         */
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

        /**
         * @summary Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.
         *
         * @param request RenamePlaybookNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RenamePlaybookNodeResponse
         */
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

        /**
         * @summary Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.
         *
         * @param request RenamePlaybookNodeRequest
         * @return RenamePlaybookNodeResponse
         */
        public RenamePlaybookNodeResponse RenamePlaybookNode(RenamePlaybookNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenamePlaybookNodeWithOptions(request, runtime);
        }

        /**
         * @summary Changes the name of a node in a playbook. You can call this operation during playbook orchestration. After the name of the node is changed, the reference path of the node also changes.
         *
         * @param request RenamePlaybookNodeRequest
         * @return RenamePlaybookNodeResponse
         */
        public async Task<RenamePlaybookNodeResponse> RenamePlaybookNodeAsync(RenamePlaybookNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenamePlaybookNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.
         *
         * @param request RevertPlaybookReleaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertPlaybookReleaseResponse
         */
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

        /**
         * @summary Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.
         *
         * @param request RevertPlaybookReleaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertPlaybookReleaseResponse
         */
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

        /**
         * @summary Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.
         *
         * @param request RevertPlaybookReleaseRequest
         * @return RevertPlaybookReleaseResponse
         */
        public RevertPlaybookReleaseResponse RevertPlaybookRelease(RevertPlaybookReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertPlaybookReleaseWithOptions(request, runtime);
        }

        /**
         * @summary Rolls back a playbook to a specific version. You can determine whether to publish the new playbook version during the rollback.
         *
         * @param request RevertPlaybookReleaseRequest
         * @return RevertPlaybookReleaseResponse
         */
        public async Task<RevertPlaybookReleaseResponse> RevertPlaybookReleaseAsync(RevertPlaybookReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertPlaybookReleaseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Submits and runs a Python3 script. You can call this operation only for data processing.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request RunPython3ScriptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunPython3ScriptResponse
         */
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

        /**
         * @summary Submits and runs a Python3 script. You can call this operation only for data processing.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request RunPython3ScriptRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunPython3ScriptResponse
         */
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

        /**
         * @summary Submits and runs a Python3 script. You can call this operation only for data processing.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request RunPython3ScriptRequest
         * @return RunPython3ScriptResponse
         */
        public RunPython3ScriptResponse RunPython3Script(RunPython3ScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunPython3ScriptWithOptions(request, runtime);
        }

        /**
         * @summary Submits and runs a Python3 script. You can call this operation only for data processing.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request RunPython3ScriptRequest
         * @return RunPython3ScriptResponse
         */
        public async Task<RunPython3ScriptResponse> RunPython3ScriptAsync(RunPython3ScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunPython3ScriptWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Triggers an enabled custom playbook or a predefined playbook.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerPlaybookResponse
         */
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

        /**
         * @summary Triggers an enabled custom playbook or a predefined playbook.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerPlaybookResponse
         */
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

        /**
         * @summary Triggers an enabled custom playbook or a predefined playbook.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerPlaybookRequest
         * @return TriggerPlaybookResponse
         */
        public TriggerPlaybookResponse TriggerPlaybook(TriggerPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Triggers an enabled custom playbook or a predefined playbook.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerPlaybookRequest
         * @return TriggerPlaybookResponse
         */
        public async Task<TriggerPlaybookResponse> TriggerPlaybookAsync(TriggerPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.
         *
         * @param request TriggerProcessTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerProcessTaskResponse
         */
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

        /**
         * @summary Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.
         *
         * @param request TriggerProcessTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerProcessTaskResponse
         */
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

        /**
         * @summary Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.
         *
         * @param request TriggerProcessTaskRequest
         * @return TriggerProcessTaskResponse
         */
        public TriggerProcessTaskResponse TriggerProcessTask(TriggerProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerProcessTaskWithOptions(request, runtime);
        }

        /**
         * @summary Performs an action on a handling task that is generated by the handling center when an event is handled by using Security Orchestration Automation Response (SOAR). For example, you can call this operation to cancel blocking or isolation, or retry blocking.
         *
         * @param request TriggerProcessTaskRequest
         * @return TriggerProcessTaskResponse
         */
        public async Task<TriggerProcessTaskResponse> TriggerProcessTaskAsync(TriggerProcessTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerProcessTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Triggers a playbook or a command.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerSophonPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerSophonPlaybookResponse
         */
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

        /**
         * @summary Triggers a playbook or a command.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerSophonPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerSophonPlaybookResponse
         */
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

        /**
         * @summary Triggers a playbook or a command.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerSophonPlaybookRequest
         * @return TriggerSophonPlaybookResponse
         */
        public TriggerSophonPlaybookResponse TriggerSophonPlaybook(TriggerSophonPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerSophonPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Triggers a playbook or a command.
         *
         * @description Before you call this operation, make sure that you understand the billing methods and pricing of Security Orchestration Automation Response (SOAR). For more information, see [Pricing](https://www.aliyun.com/price/product#/sas/detail/sas).
         *
         * @param request TriggerSophonPlaybookRequest
         * @return TriggerSophonPlaybookResponse
         */
        public async Task<TriggerSophonPlaybookResponse> TriggerSophonPlaybookAsync(TriggerSophonPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerSophonPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.
         *
         * @param request VerifyPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyPlaybookResponse
         */
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

        /**
         * @summary Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.
         *
         * @param request VerifyPlaybookRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyPlaybookResponse
         */
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

        /**
         * @summary Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.
         *
         * @param request VerifyPlaybookRequest
         * @return VerifyPlaybookResponse
         */
        public VerifyPlaybookResponse VerifyPlaybook(VerifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPlaybookWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether the configuration of the playbook is correct and whether the logic of the orchestration is reasonable.
         *
         * @param request VerifyPlaybookRequest
         * @return VerifyPlaybookResponse
         */
        public async Task<VerifyPlaybookResponse> VerifyPlaybookAsync(VerifyPlaybookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPlaybookWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Checks whether the syntax of a Python code snippet is correct.
         *
         * @param request VerifyPythonFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyPythonFileResponse
         */
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

        /**
         * @summary Checks whether the syntax of a Python code snippet is correct.
         *
         * @param request VerifyPythonFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyPythonFileResponse
         */
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

        /**
         * @summary Checks whether the syntax of a Python code snippet is correct.
         *
         * @param request VerifyPythonFileRequest
         * @return VerifyPythonFileResponse
         */
        public VerifyPythonFileResponse VerifyPythonFile(VerifyPythonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPythonFileWithOptions(request, runtime);
        }

        /**
         * @summary Checks whether the syntax of a Python code snippet is correct.
         *
         * @param request VerifyPythonFileRequest
         * @return VerifyPythonFileResponse
         */
        public async Task<VerifyPythonFileResponse> VerifyPythonFileAsync(VerifyPythonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPythonFileWithOptionsAsync(request, runtime);
        }

    }
}
