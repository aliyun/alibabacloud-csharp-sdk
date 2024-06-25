// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Acm20200206.Models;

namespace AlibabaCloud.SDK.Acm20200206
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("acm", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request BatchExportConfigurationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchExportConfigurationsResponse
         */
        public BatchExportConfigurationsResponse BatchExportConfigurationsWithOptions(BatchExportConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchExportConfigurations",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExportConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BatchExportConfigurationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchExportConfigurationsResponse
         */
        public async Task<BatchExportConfigurationsResponse> BatchExportConfigurationsWithOptionsAsync(BatchExportConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchExportConfigurations",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/export",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchExportConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BatchExportConfigurationsRequest
         * @return BatchExportConfigurationsResponse
         */
        public BatchExportConfigurationsResponse BatchExportConfigurations(BatchExportConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchExportConfigurationsWithOptions(request, headers, runtime);
        }

        /**
         * @param request BatchExportConfigurationsRequest
         * @return BatchExportConfigurationsResponse
         */
        public async Task<BatchExportConfigurationsResponse> BatchExportConfigurationsAsync(BatchExportConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchExportConfigurationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request BatchImportConfigurationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchImportConfigurationsResponse
         */
        public BatchImportConfigurationsResponse BatchImportConfigurationsWithOptions(BatchImportConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchImportConfigurations",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchImportConfigurationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request BatchImportConfigurationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchImportConfigurationsResponse
         */
        public async Task<BatchImportConfigurationsResponse> BatchImportConfigurationsWithOptionsAsync(BatchImportConfigurationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchImportConfigurations",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchImportConfigurationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request BatchImportConfigurationsRequest
         * @return BatchImportConfigurationsResponse
         */
        public BatchImportConfigurationsResponse BatchImportConfigurations(BatchImportConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchImportConfigurationsWithOptions(request, headers, runtime);
        }

        /**
         * @param request BatchImportConfigurationsRequest
         * @return BatchImportConfigurationsResponse
         */
        public async Task<BatchImportConfigurationsResponse> BatchImportConfigurationsAsync(BatchImportConfigurationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchImportConfigurationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CheckConfigurationCloneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckConfigurationCloneResponse
         */
        public CheckConfigurationCloneResponse CheckConfigurationCloneWithOptions(CheckConfigurationCloneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceFrom))
            {
                body["NamespaceFrom"] = request.NamespaceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceTo))
            {
                body["NamespaceTo"] = request.NamespaceTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckConfigurationClone",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/checkForClone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckConfigurationCloneResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckConfigurationCloneRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckConfigurationCloneResponse
         */
        public async Task<CheckConfigurationCloneResponse> CheckConfigurationCloneWithOptionsAsync(CheckConfigurationCloneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceFrom))
            {
                body["NamespaceFrom"] = request.NamespaceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceTo))
            {
                body["NamespaceTo"] = request.NamespaceTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckConfigurationClone",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/checkForClone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckConfigurationCloneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckConfigurationCloneRequest
         * @return CheckConfigurationCloneResponse
         */
        public CheckConfigurationCloneResponse CheckConfigurationClone(CheckConfigurationCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckConfigurationCloneWithOptions(request, headers, runtime);
        }

        /**
         * @param request CheckConfigurationCloneRequest
         * @return CheckConfigurationCloneResponse
         */
        public async Task<CheckConfigurationCloneResponse> CheckConfigurationCloneAsync(CheckConfigurationCloneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckConfigurationCloneWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CheckConfigurationExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckConfigurationExportResponse
         */
        public CheckConfigurationExportResponse CheckConfigurationExportWithOptions(CheckConfigurationExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckConfigurationExport",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/checkForExport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckConfigurationExportResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckConfigurationExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckConfigurationExportResponse
         */
        public async Task<CheckConfigurationExportResponse> CheckConfigurationExportWithOptionsAsync(CheckConfigurationExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckConfigurationExport",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/checkForExport",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckConfigurationExportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckConfigurationExportRequest
         * @return CheckConfigurationExportResponse
         */
        public CheckConfigurationExportResponse CheckConfigurationExport(CheckConfigurationExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckConfigurationExportWithOptions(request, headers, runtime);
        }

        /**
         * @param request CheckConfigurationExportRequest
         * @return CheckConfigurationExportResponse
         */
        public async Task<CheckConfigurationExportResponse> CheckConfigurationExportAsync(CheckConfigurationExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckConfigurationExportWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CloneConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneConfigurationResponse
         */
        public CloneConfigurationResponse CloneConfigurationWithOptions(CloneConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceFrom))
            {
                body["NamespaceFrom"] = request.NamespaceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceTo))
            {
                body["NamespaceTo"] = request.NamespaceTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CloneConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneConfigurationResponse
         */
        public async Task<CloneConfigurationResponse> CloneConfigurationWithOptionsAsync(CloneConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceFrom))
            {
                body["NamespaceFrom"] = request.NamespaceFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceTo))
            {
                body["NamespaceTo"] = request.NamespaceTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["Policy"] = request.Policy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CloneConfigurationRequest
         * @return CloneConfigurationResponse
         */
        public CloneConfigurationResponse CloneConfiguration(CloneConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request CloneConfigurationRequest
         * @return CloneConfigurationResponse
         */
        public async Task<CloneConfigurationResponse> CloneConfigurationAsync(CloneConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CreateConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigurationResponse
         */
        public CreateConfigurationResponse CreateConfigurationWithOptions(CreateConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigurationResponse
         */
        public async Task<CreateConfigurationResponse> CreateConfigurationWithOptionsAsync(CreateConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateConfigurationRequest
         * @return CreateConfigurationResponse
         */
        public CreateConfigurationResponse CreateConfiguration(CreateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request CreateConfigurationRequest
         * @return CreateConfigurationResponse
         */
        public async Task<CreateConfigurationResponse> CreateConfigurationAsync(CreateConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CreateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigurationResponse
         */
        public DeleteConfigurationResponse DeleteConfigurationWithOptions(DeleteConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigurationResponse
         */
        public async Task<DeleteConfigurationResponse> DeleteConfigurationWithOptionsAsync(DeleteConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteConfigurationRequest
         * @return DeleteConfigurationResponse
         */
        public DeleteConfigurationResponse DeleteConfiguration(DeleteConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteConfigurationRequest
         * @return DeleteConfigurationResponse
         */
        public async Task<DeleteConfigurationResponse> DeleteConfigurationAsync(DeleteConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNamespaceResponse
         */
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNamespaceResponse
         */
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteNamespaceRequest
         * @return DeleteNamespaceResponse
         */
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteNamespaceRequest
         * @return DeleteNamespaceResponse
         */
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeployConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployConfigurationResponse
         */
        public DeployConfigurationResponse DeployConfigurationWithOptions(DeployConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BetaIps))
            {
                body["BetaIps"] = request.BetaIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeployConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployConfigurationResponse
         */
        public async Task<DeployConfigurationResponse> DeployConfigurationWithOptionsAsync(DeployConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BetaIps))
            {
                body["BetaIps"] = request.BetaIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["Desc"] = request.Desc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeployConfigurationRequest
         * @return DeployConfigurationResponse
         */
        public DeployConfigurationResponse DeployConfiguration(DeployConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeployConfigurationRequest
         * @return DeployConfigurationResponse
         */
        public async Task<DeployConfigurationResponse> DeployConfigurationAsync(DeployConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigurationResponse
         */
        public DescribeConfigurationResponse DescribeConfigurationWithOptions(DescribeConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigurationResponse
         */
        public async Task<DescribeConfigurationResponse> DescribeConfigurationWithOptionsAsync(DescribeConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/configuration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeConfigurationRequest
         * @return DescribeConfigurationResponse
         */
        public DescribeConfigurationResponse DescribeConfiguration(DescribeConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigurationRequest
         * @return DescribeConfigurationResponse
         */
        public async Task<DescribeConfigurationResponse> DescribeConfigurationAsync(DescribeConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeImportFileUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImportFileUrlResponse
         */
        public DescribeImportFileUrlResponse DescribeImportFileUrlWithOptions(DescribeImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportFileUrl",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/importFileUrl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportFileUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeImportFileUrlRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImportFileUrlResponse
         */
        public async Task<DescribeImportFileUrlResponse> DescribeImportFileUrlWithOptionsAsync(DescribeImportFileUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImportFileUrl",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/batch/importFileUrl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImportFileUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeImportFileUrlRequest
         * @return DescribeImportFileUrlResponse
         */
        public DescribeImportFileUrlResponse DescribeImportFileUrl(DescribeImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeImportFileUrlWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeImportFileUrlRequest
         * @return DescribeImportFileUrlResponse
         */
        public async Task<DescribeImportFileUrlResponse> DescribeImportFileUrlAsync(DescribeImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeImportFileUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResponse
         */
        public DescribeNamespaceResponse DescribeNamespaceWithOptions(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResponse
         */
        public async Task<DescribeNamespaceResponse> DescribeNamespaceWithOptionsAsync(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeNamespaceRequest
         * @return DescribeNamespaceResponse
         */
        public DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeNamespaceRequest
         * @return DescribeNamespaceResponse
         */
        public async Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesResponse
         */
        public DescribeNamespacesResponse DescribeNamespacesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesResponse
         */
        public async Task<DescribeNamespacesResponse> DescribeNamespacesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeNamespacesResponse
         */
        public DescribeNamespacesResponse DescribeNamespaces()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespacesWithOptions(headers, runtime);
        }

        /**
         * @return DescribeNamespacesResponse
         */
        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespacesWithOptionsAsync(headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesWithCreateResponse
         */
        public DescribeNamespacesWithCreateResponse DescribeNamespacesWithCreateWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespacesWithCreate",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace/listWithCreate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesWithCreateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesWithCreateResponse
         */
        public async Task<DescribeNamespacesWithCreateResponse> DescribeNamespacesWithCreateWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespacesWithCreate",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace/listWithCreate",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesWithCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return DescribeNamespacesWithCreateResponse
         */
        public DescribeNamespacesWithCreateResponse DescribeNamespacesWithCreate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespacesWithCreateWithOptions(headers, runtime);
        }

        /**
         * @return DescribeNamespacesWithCreateResponse
         */
        public async Task<DescribeNamespacesWithCreateResponse> DescribeNamespacesWithCreateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespacesWithCreateWithOptionsAsync(headers, runtime);
        }

        /**
         * @param request DescribeTraceByConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTraceByConfigurationResponse
         */
        public DescribeTraceByConfigurationResponse DescribeTraceByConfigurationWithOptions(DescribeTraceByConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTraceByConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/trace/getByConfiguration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTraceByConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeTraceByConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTraceByConfigurationResponse
         */
        public async Task<DescribeTraceByConfigurationResponse> DescribeTraceByConfigurationWithOptionsAsync(DescribeTraceByConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                query["DataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTraceByConfiguration",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/trace/getByConfiguration",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTraceByConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeTraceByConfigurationRequest
         * @return DescribeTraceByConfigurationResponse
         */
        public DescribeTraceByConfigurationResponse DescribeTraceByConfiguration(DescribeTraceByConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTraceByConfigurationWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeTraceByConfigurationRequest
         * @return DescribeTraceByConfigurationResponse
         */
        public async Task<DescribeTraceByConfigurationResponse> DescribeTraceByConfigurationAsync(DescribeTraceByConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTraceByConfigurationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request UpdateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceResponse
         */
        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                body["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceResponse
         */
        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                body["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                body["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2020-02-06",
                Protocol = "HTTPS",
                Pathname = "/diamond-ops/pop/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateNamespaceRequest
         * @return UpdateNamespaceResponse
         */
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @param request UpdateNamespaceRequest
         * @return UpdateNamespaceResponse
         */
        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceWithOptionsAsync(request, headers, runtime);
        }

    }
}
