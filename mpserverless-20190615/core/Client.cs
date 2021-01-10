// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MPServerless20190615.Models;

namespace AlibabaCloud.SDK.MPServerless20190615
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("mpserverless", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddCorsDomainResponse AddCorsDomainWithOptions(AddCorsDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCorsDomainResponse>(DoRPCRequest("AddCorsDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCorsDomainResponse> AddCorsDomainWithOptionsAsync(AddCorsDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCorsDomainResponse>(await DoRPCRequestAsync("AddCorsDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCorsDomainResponse AddCorsDomain(AddCorsDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCorsDomainWithOptions(request, runtime);
        }

        public async Task<AddCorsDomainResponse> AddCorsDomainAsync(AddCorsDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCorsDomainWithOptionsAsync(request, runtime);
        }

        public AddDingtalkOpenPlatformConfigResponse AddDingtalkOpenPlatformConfigWithOptions(AddDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDingtalkOpenPlatformConfigResponse>(DoRPCRequest("AddDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDingtalkOpenPlatformConfigResponse> AddDingtalkOpenPlatformConfigWithOptionsAsync(AddDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDingtalkOpenPlatformConfigResponse>(await DoRPCRequestAsync("AddDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDingtalkOpenPlatformConfigResponse AddDingtalkOpenPlatformConfig(AddDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDingtalkOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<AddDingtalkOpenPlatformConfigResponse> AddDingtalkOpenPlatformConfigAsync(AddDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDingtalkOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public AttachSmsSignResponse AttachSmsSignWithOptions(AttachSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachSmsSignResponse>(DoRPCRequest("AttachSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachSmsSignResponse> AttachSmsSignWithOptionsAsync(AttachSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachSmsSignResponse>(await DoRPCRequestAsync("AttachSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachSmsSignResponse AttachSmsSign(AttachSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachSmsSignWithOptions(request, runtime);
        }

        public async Task<AttachSmsSignResponse> AttachSmsSignAsync(AttachSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachSmsSignWithOptionsAsync(request, runtime);
        }

        public AttachWebHostingCertificateResponse AttachWebHostingCertificateWithOptions(AttachWebHostingCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachWebHostingCertificateResponse>(DoRPCRequest("AttachWebHostingCertificate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachWebHostingCertificateResponse> AttachWebHostingCertificateWithOptionsAsync(AttachWebHostingCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachWebHostingCertificateResponse>(await DoRPCRequestAsync("AttachWebHostingCertificate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachWebHostingCertificateResponse AttachWebHostingCertificate(AttachWebHostingCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachWebHostingCertificateWithOptions(request, runtime);
        }

        public async Task<AttachWebHostingCertificateResponse> AttachWebHostingCertificateAsync(AttachWebHostingCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachWebHostingCertificateWithOptionsAsync(request, runtime);
        }

        public BatchDeleteWebHostingFilesResponse BatchDeleteWebHostingFilesWithOptions(BatchDeleteWebHostingFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteWebHostingFilesResponse>(DoRPCRequest("BatchDeleteWebHostingFiles", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteWebHostingFilesResponse> BatchDeleteWebHostingFilesWithOptionsAsync(BatchDeleteWebHostingFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteWebHostingFilesResponse>(await DoRPCRequestAsync("BatchDeleteWebHostingFiles", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteWebHostingFilesResponse BatchDeleteWebHostingFiles(BatchDeleteWebHostingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteWebHostingFilesWithOptions(request, runtime);
        }

        public async Task<BatchDeleteWebHostingFilesResponse> BatchDeleteWebHostingFilesAsync(BatchDeleteWebHostingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteWebHostingFilesWithOptionsAsync(request, runtime);
        }

        public BindWebHostingCustomDomainResponse BindWebHostingCustomDomainWithOptions(BindWebHostingCustomDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindWebHostingCustomDomainResponse>(DoRPCRequest("BindWebHostingCustomDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindWebHostingCustomDomainResponse> BindWebHostingCustomDomainWithOptionsAsync(BindWebHostingCustomDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindWebHostingCustomDomainResponse>(await DoRPCRequestAsync("BindWebHostingCustomDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindWebHostingCustomDomainResponse BindWebHostingCustomDomain(BindWebHostingCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindWebHostingCustomDomainWithOptions(request, runtime);
        }

        public async Task<BindWebHostingCustomDomainResponse> BindWebHostingCustomDomainAsync(BindWebHostingCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindWebHostingCustomDomainWithOptionsAsync(request, runtime);
        }

        public CheckMpServerlessRoleExistsResponse CheckMpServerlessRoleExistsWithOptions(CheckMpServerlessRoleExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMpServerlessRoleExistsResponse>(DoRPCRequest("CheckMpServerlessRoleExists", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMpServerlessRoleExistsResponse> CheckMpServerlessRoleExistsWithOptionsAsync(CheckMpServerlessRoleExistsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMpServerlessRoleExistsResponse>(await DoRPCRequestAsync("CheckMpServerlessRoleExists", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMpServerlessRoleExistsResponse CheckMpServerlessRoleExists(CheckMpServerlessRoleExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMpServerlessRoleExistsWithOptions(request, runtime);
        }

        public async Task<CheckMpServerlessRoleExistsResponse> CheckMpServerlessRoleExistsAsync(CheckMpServerlessRoleExistsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMpServerlessRoleExistsWithOptionsAsync(request, runtime);
        }

        public CheckSmsHasAuthorizedToMPSResponse CheckSmsHasAuthorizedToMPSWithOptions(CheckSmsHasAuthorizedToMPSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckSmsHasAuthorizedToMPSResponse>(DoRPCRequest("CheckSmsHasAuthorizedToMPS", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckSmsHasAuthorizedToMPSResponse> CheckSmsHasAuthorizedToMPSWithOptionsAsync(CheckSmsHasAuthorizedToMPSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckSmsHasAuthorizedToMPSResponse>(await DoRPCRequestAsync("CheckSmsHasAuthorizedToMPS", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckSmsHasAuthorizedToMPSResponse CheckSmsHasAuthorizedToMPS(CheckSmsHasAuthorizedToMPSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSmsHasAuthorizedToMPSWithOptions(request, runtime);
        }

        public async Task<CheckSmsHasAuthorizedToMPSResponse> CheckSmsHasAuthorizedToMPSAsync(CheckSmsHasAuthorizedToMPSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSmsHasAuthorizedToMPSWithOptionsAsync(request, runtime);
        }

        public CreateBuiltinFunctionTemplateResponse CreateBuiltinFunctionTemplateWithOptions(CreateBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBuiltinFunctionTemplateResponse>(DoRPCRequest("CreateBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBuiltinFunctionTemplateResponse> CreateBuiltinFunctionTemplateWithOptionsAsync(CreateBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBuiltinFunctionTemplateResponse>(await DoRPCRequestAsync("CreateBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBuiltinFunctionTemplateResponse CreateBuiltinFunctionTemplate(CreateBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBuiltinFunctionTemplateWithOptions(request, runtime);
        }

        public async Task<CreateBuiltinFunctionTemplateResponse> CreateBuiltinFunctionTemplateAsync(CreateBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBuiltinFunctionTemplateWithOptionsAsync(request, runtime);
        }

        public CreateDBExportTaskResponse CreateDBExportTaskWithOptions(CreateDBExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBExportTaskResponse>(DoRPCRequest("CreateDBExportTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBExportTaskResponse> CreateDBExportTaskWithOptionsAsync(CreateDBExportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBExportTaskResponse>(await DoRPCRequestAsync("CreateDBExportTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBExportTaskResponse CreateDBExportTask(CreateDBExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBExportTaskWithOptions(request, runtime);
        }

        public async Task<CreateDBExportTaskResponse> CreateDBExportTaskAsync(CreateDBExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBExportTaskWithOptionsAsync(request, runtime);
        }

        public CreateDBImportTaskResponse CreateDBImportTaskWithOptions(CreateDBImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBImportTaskResponse>(DoRPCRequest("CreateDBImportTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBImportTaskResponse> CreateDBImportTaskWithOptionsAsync(CreateDBImportTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBImportTaskResponse>(await DoRPCRequestAsync("CreateDBImportTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBImportTaskResponse CreateDBImportTask(CreateDBImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBImportTaskWithOptions(request, runtime);
        }

        public async Task<CreateDBImportTaskResponse> CreateDBImportTaskAsync(CreateDBImportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBImportTaskWithOptionsAsync(request, runtime);
        }

        public CreateDBRestoreTaskResponse CreateDBRestoreTaskWithOptions(CreateDBRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBRestoreTaskResponse>(DoRPCRequest("CreateDBRestoreTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDBRestoreTaskResponse> CreateDBRestoreTaskWithOptionsAsync(CreateDBRestoreTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDBRestoreTaskResponse>(await DoRPCRequestAsync("CreateDBRestoreTask", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDBRestoreTaskResponse CreateDBRestoreTask(CreateDBRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDBRestoreTaskWithOptions(request, runtime);
        }

        public async Task<CreateDBRestoreTaskResponse> CreateDBRestoreTaskAsync(CreateDBRestoreTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDBRestoreTaskWithOptionsAsync(request, runtime);
        }

        public CreateFunctionResponse CreateFunctionWithOptions(CreateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFunctionResponse>(DoRPCRequest("CreateFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFunctionResponse> CreateFunctionWithOptionsAsync(CreateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFunctionResponse>(await DoRPCRequestAsync("CreateFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFunctionResponse CreateFunction(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFunctionWithOptions(request, runtime);
        }

        public async Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFunctionWithOptionsAsync(request, runtime);
        }

        public CreateFunctionDeploymentResponse CreateFunctionDeploymentWithOptions(CreateFunctionDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFunctionDeploymentResponse>(DoRPCRequest("CreateFunctionDeployment", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFunctionDeploymentResponse> CreateFunctionDeploymentWithOptionsAsync(CreateFunctionDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFunctionDeploymentResponse>(await DoRPCRequestAsync("CreateFunctionDeployment", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFunctionDeploymentResponse CreateFunctionDeployment(CreateFunctionDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFunctionDeploymentWithOptions(request, runtime);
        }

        public async Task<CreateFunctionDeploymentResponse> CreateFunctionDeploymentAsync(CreateFunctionDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFunctionDeploymentWithOptionsAsync(request, runtime);
        }

        public CreateSmsSignResponse CreateSmsSignWithOptions(CreateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmsSignResponse>(DoRPCRequest("CreateSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSmsSignResponse> CreateSmsSignWithOptionsAsync(CreateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmsSignResponse>(await DoRPCRequestAsync("CreateSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSmsSignResponse CreateSmsSign(CreateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsSignWithOptions(request, runtime);
        }

        public async Task<CreateSmsSignResponse> CreateSmsSignAsync(CreateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsSignWithOptionsAsync(request, runtime);
        }

        public CreateSmsTemplateResponse CreateSmsTemplateWithOptions(CreateSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmsTemplateResponse>(DoRPCRequest("CreateSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSmsTemplateResponse> CreateSmsTemplateWithOptionsAsync(CreateSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmsTemplateResponse>(await DoRPCRequestAsync("CreateSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSmsTemplateResponse CreateSmsTemplate(CreateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmsTemplateWithOptions(request, runtime);
        }

        public async Task<CreateSmsTemplateResponse> CreateSmsTemplateAsync(CreateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmsTemplateWithOptionsAsync(request, runtime);
        }

        public CreateSpaceResponse CreateSpaceWithOptions(CreateSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSpaceResponse>(DoRPCRequest("CreateSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSpaceResponse> CreateSpaceWithOptionsAsync(CreateSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSpaceResponse>(await DoRPCRequestAsync("CreateSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSpaceResponse CreateSpace(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSpaceWithOptions(request, runtime);
        }

        public async Task<CreateSpaceResponse> CreateSpaceAsync(CreateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSpaceWithOptionsAsync(request, runtime);
        }

        public DeleteAntOpenPlatformConfigResponse DeleteAntOpenPlatformConfigWithOptions(DeleteAntOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntOpenPlatformConfigResponse>(DoRPCRequest("DeleteAntOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAntOpenPlatformConfigResponse> DeleteAntOpenPlatformConfigWithOptionsAsync(DeleteAntOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAntOpenPlatformConfigResponse>(await DoRPCRequestAsync("DeleteAntOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAntOpenPlatformConfigResponse DeleteAntOpenPlatformConfig(DeleteAntOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAntOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<DeleteAntOpenPlatformConfigResponse> DeleteAntOpenPlatformConfigAsync(DeleteAntOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAntOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public DeleteCorsDomainResponse DeleteCorsDomainWithOptions(DeleteCorsDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCorsDomainResponse>(DoRPCRequest("DeleteCorsDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCorsDomainResponse> DeleteCorsDomainWithOptionsAsync(DeleteCorsDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCorsDomainResponse>(await DoRPCRequestAsync("DeleteCorsDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCorsDomainResponse DeleteCorsDomain(DeleteCorsDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCorsDomainWithOptions(request, runtime);
        }

        public async Task<DeleteCorsDomainResponse> DeleteCorsDomainAsync(DeleteCorsDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCorsDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDBCollectionResponse DeleteDBCollectionWithOptions(DeleteDBCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBCollectionResponse>(DoRPCRequest("DeleteDBCollection", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDBCollectionResponse> DeleteDBCollectionWithOptionsAsync(DeleteDBCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDBCollectionResponse>(await DoRPCRequestAsync("DeleteDBCollection", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDBCollectionResponse DeleteDBCollection(DeleteDBCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDBCollectionWithOptions(request, runtime);
        }

        public async Task<DeleteDBCollectionResponse> DeleteDBCollectionAsync(DeleteDBCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDBCollectionWithOptionsAsync(request, runtime);
        }

        public DeleteDingtalkOpenPlatformConfigResponse DeleteDingtalkOpenPlatformConfigWithOptions(DeleteDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDingtalkOpenPlatformConfigResponse>(DoRPCRequest("DeleteDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDingtalkOpenPlatformConfigResponse> DeleteDingtalkOpenPlatformConfigWithOptionsAsync(DeleteDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDingtalkOpenPlatformConfigResponse>(await DoRPCRequestAsync("DeleteDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDingtalkOpenPlatformConfigResponse DeleteDingtalkOpenPlatformConfig(DeleteDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDingtalkOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDingtalkOpenPlatformConfigResponse> DeleteDingtalkOpenPlatformConfigAsync(DeleteDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDingtalkOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(DoRPCRequest("DeleteFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFileResponse>(await DoRPCRequestAsync("DeleteFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileWithOptions(request, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileWithOptionsAsync(request, runtime);
        }

        public DeleteFunctionResponse DeleteFunctionWithOptions(DeleteFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(DoRPCRequest("DeleteFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionWithOptionsAsync(DeleteFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFunctionResponse>(await DoRPCRequestAsync("DeleteFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFunctionWithOptions(request, runtime);
        }

        public async Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFunctionWithOptionsAsync(request, runtime);
        }

        public DeleteSmsSignResponse DeleteSmsSignWithOptions(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(DoRPCRequest("DeleteSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmsSignResponse> DeleteSmsSignWithOptionsAsync(DeleteSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsSignResponse>(await DoRPCRequestAsync("DeleteSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmsSignResponse DeleteSmsSign(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsSignWithOptions(request, runtime);
        }

        public async Task<DeleteSmsSignResponse> DeleteSmsSignAsync(DeleteSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsSignWithOptionsAsync(request, runtime);
        }

        public DeleteSmsTemplateResponse DeleteSmsTemplateWithOptions(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(DoRPCRequest("DeleteSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateWithOptionsAsync(DeleteSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmsTemplateResponse>(await DoRPCRequestAsync("DeleteSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmsTemplateResponse DeleteSmsTemplate(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmsTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteSmsTemplateResponse> DeleteSmsTemplateAsync(DeleteSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmsTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteSpaceResponse DeleteSpaceWithOptions(DeleteSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(DoRPCRequest("DeleteSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceWithOptionsAsync(DeleteSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSpaceResponse>(await DoRPCRequestAsync("DeleteSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSpaceResponse DeleteSpace(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpaceWithOptions(request, runtime);
        }

        public async Task<DeleteSpaceResponse> DeleteSpaceAsync(DeleteSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpaceWithOptionsAsync(request, runtime);
        }

        public DeleteWebHostingCertificateResponse DeleteWebHostingCertificateWithOptions(DeleteWebHostingCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebHostingCertificateResponse>(DoRPCRequest("DeleteWebHostingCertificate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebHostingCertificateResponse> DeleteWebHostingCertificateWithOptionsAsync(DeleteWebHostingCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebHostingCertificateResponse>(await DoRPCRequestAsync("DeleteWebHostingCertificate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebHostingCertificateResponse DeleteWebHostingCertificate(DeleteWebHostingCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebHostingCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteWebHostingCertificateResponse> DeleteWebHostingCertificateAsync(DeleteWebHostingCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebHostingCertificateWithOptionsAsync(request, runtime);
        }

        public DeleteWebHostingFileResponse DeleteWebHostingFileWithOptions(DeleteWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebHostingFileResponse>(DoRPCRequest("DeleteWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWebHostingFileResponse> DeleteWebHostingFileWithOptionsAsync(DeleteWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWebHostingFileResponse>(await DoRPCRequestAsync("DeleteWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWebHostingFileResponse DeleteWebHostingFile(DeleteWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWebHostingFileWithOptions(request, runtime);
        }

        public async Task<DeleteWebHostingFileResponse> DeleteWebHostingFileAsync(DeleteWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWebHostingFileWithOptionsAsync(request, runtime);
        }

        public DeleteWechatOpenPlatformConfigResponse DeleteWechatOpenPlatformConfigWithOptions(DeleteWechatOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWechatOpenPlatformConfigResponse>(DoRPCRequest("DeleteWechatOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWechatOpenPlatformConfigResponse> DeleteWechatOpenPlatformConfigWithOptionsAsync(DeleteWechatOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWechatOpenPlatformConfigResponse>(await DoRPCRequestAsync("DeleteWechatOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWechatOpenPlatformConfigResponse DeleteWechatOpenPlatformConfig(DeleteWechatOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWechatOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<DeleteWechatOpenPlatformConfigResponse> DeleteWechatOpenPlatformConfigAsync(DeleteWechatOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWechatOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public DeployFunctionResponse DeployFunctionWithOptions(DeployFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFunctionResponse>(DoRPCRequest("DeployFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployFunctionResponse> DeployFunctionWithOptionsAsync(DeployFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployFunctionResponse>(await DoRPCRequestAsync("DeployFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployFunctionResponse DeployFunction(DeployFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployFunctionWithOptions(request, runtime);
        }

        public async Task<DeployFunctionResponse> DeployFunctionAsync(DeployFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployFunctionWithOptionsAsync(request, runtime);
        }

        public DescribeFCOpenStatusResponse DescribeFCOpenStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFCOpenStatusResponse>(DoRPCRequest("DescribeFCOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFCOpenStatusResponse> DescribeFCOpenStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeFCOpenStatusResponse>(await DoRPCRequestAsync("DescribeFCOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFCOpenStatusResponse DescribeFCOpenStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFCOpenStatusWithOptions(runtime);
        }

        public async Task<DescribeFCOpenStatusResponse> DescribeFCOpenStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFCOpenStatusWithOptionsAsync(runtime);
        }

        public DescribeFileResponse DescribeFileWithOptions(DescribeFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFileResponse>(DoRPCRequest("DescribeFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFileResponse> DescribeFileWithOptionsAsync(DescribeFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFileResponse>(await DoRPCRequestAsync("DescribeFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFileResponse DescribeFile(DescribeFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileWithOptions(request, runtime);
        }

        public async Task<DescribeFileResponse> DescribeFileAsync(DescribeFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileWithOptionsAsync(request, runtime);
        }

        public DescribeFileUploadSignedUrlResponse DescribeFileUploadSignedUrlWithOptions(DescribeFileUploadSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFileUploadSignedUrlResponse>(DoRPCRequest("DescribeFileUploadSignedUrl", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFileUploadSignedUrlResponse> DescribeFileUploadSignedUrlWithOptionsAsync(DescribeFileUploadSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFileUploadSignedUrlResponse>(await DoRPCRequestAsync("DescribeFileUploadSignedUrl", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFileUploadSignedUrlResponse DescribeFileUploadSignedUrl(DescribeFileUploadSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileUploadSignedUrlWithOptions(request, runtime);
        }

        public async Task<DescribeFileUploadSignedUrlResponse> DescribeFileUploadSignedUrlAsync(DescribeFileUploadSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileUploadSignedUrlWithOptionsAsync(request, runtime);
        }

        public DescribeFunctionResponse DescribeFunctionWithOptions(DescribeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFunctionResponse>(DoRPCRequest("DescribeFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFunctionResponse> DescribeFunctionWithOptionsAsync(DescribeFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFunctionResponse>(await DoRPCRequestAsync("DescribeFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFunctionResponse DescribeFunction(DescribeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFunctionWithOptions(request, runtime);
        }

        public async Task<DescribeFunctionResponse> DescribeFunctionAsync(DescribeFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFunctionWithOptionsAsync(request, runtime);
        }

        public DescribeHttpTriggerConfigResponse DescribeHttpTriggerConfigWithOptions(DescribeHttpTriggerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHttpTriggerConfigResponse>(DoRPCRequest("DescribeHttpTriggerConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHttpTriggerConfigResponse> DescribeHttpTriggerConfigWithOptionsAsync(DescribeHttpTriggerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHttpTriggerConfigResponse>(await DoRPCRequestAsync("DescribeHttpTriggerConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHttpTriggerConfigResponse DescribeHttpTriggerConfig(DescribeHttpTriggerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHttpTriggerConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHttpTriggerConfigResponse> DescribeHttpTriggerConfigAsync(DescribeHttpTriggerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHttpTriggerConfigWithOptionsAsync(request, runtime);
        }

        public DescribeISVFileUploadSignedUrlResponse DescribeISVFileUploadSignedUrlWithOptions(DescribeISVFileUploadSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeISVFileUploadSignedUrlResponse>(DoRPCRequest("DescribeISVFileUploadSignedUrl", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeISVFileUploadSignedUrlResponse> DescribeISVFileUploadSignedUrlWithOptionsAsync(DescribeISVFileUploadSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeISVFileUploadSignedUrlResponse>(await DoRPCRequestAsync("DescribeISVFileUploadSignedUrl", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeISVFileUploadSignedUrlResponse DescribeISVFileUploadSignedUrl(DescribeISVFileUploadSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeISVFileUploadSignedUrlWithOptions(request, runtime);
        }

        public async Task<DescribeISVFileUploadSignedUrlResponse> DescribeISVFileUploadSignedUrlAsync(DescribeISVFileUploadSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeISVFileUploadSignedUrlWithOptionsAsync(request, runtime);
        }

        public DescribeProductOpenStatusResponse DescribeProductOpenStatusWithOptions(DescribeProductOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductOpenStatusResponse>(DoRPCRequest("DescribeProductOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProductOpenStatusResponse> DescribeProductOpenStatusWithOptionsAsync(DescribeProductOpenStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductOpenStatusResponse>(await DoRPCRequestAsync("DescribeProductOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProductOpenStatusResponse DescribeProductOpenStatus(DescribeProductOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductOpenStatusWithOptions(request, runtime);
        }

        public async Task<DescribeProductOpenStatusResponse> DescribeProductOpenStatusAsync(DescribeProductOpenStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductOpenStatusWithOptionsAsync(request, runtime);
        }

        public DescribeServicePolicyResponse DescribeServicePolicyWithOptions(DescribeServicePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServicePolicyResponse>(DoRPCRequest("DescribeServicePolicy", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServicePolicyResponse> DescribeServicePolicyWithOptionsAsync(DescribeServicePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServicePolicyResponse>(await DoRPCRequestAsync("DescribeServicePolicy", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServicePolicyResponse DescribeServicePolicy(DescribeServicePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServicePolicyWithOptions(request, runtime);
        }

        public async Task<DescribeServicePolicyResponse> DescribeServicePolicyAsync(DescribeServicePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServicePolicyWithOptionsAsync(request, runtime);
        }

        public DescribeSmsOpenStatusResponse DescribeSmsOpenStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeSmsOpenStatusResponse>(DoRPCRequest("DescribeSmsOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmsOpenStatusResponse> DescribeSmsOpenStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeSmsOpenStatusResponse>(await DoRPCRequestAsync("DescribeSmsOpenStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmsOpenStatusResponse DescribeSmsOpenStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsOpenStatusWithOptions(runtime);
        }

        public async Task<DescribeSmsOpenStatusResponse> DescribeSmsOpenStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsOpenStatusWithOptionsAsync(runtime);
        }

        public DescribeSmsSignResponse DescribeSmsSignWithOptions(DescribeSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsSignResponse>(DoRPCRequest("DescribeSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmsSignResponse> DescribeSmsSignWithOptionsAsync(DescribeSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsSignResponse>(await DoRPCRequestAsync("DescribeSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmsSignResponse DescribeSmsSign(DescribeSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsSignWithOptions(request, runtime);
        }

        public async Task<DescribeSmsSignResponse> DescribeSmsSignAsync(DescribeSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsSignWithOptionsAsync(request, runtime);
        }

        public DescribeSmsSignStatusResponse DescribeSmsSignStatusWithOptions(DescribeSmsSignStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsSignStatusResponse>(DoRPCRequest("DescribeSmsSignStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmsSignStatusResponse> DescribeSmsSignStatusWithOptionsAsync(DescribeSmsSignStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsSignStatusResponse>(await DoRPCRequestAsync("DescribeSmsSignStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmsSignStatusResponse DescribeSmsSignStatus(DescribeSmsSignStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsSignStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSmsSignStatusResponse> DescribeSmsSignStatusAsync(DescribeSmsSignStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsSignStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSmsTemplateResponse DescribeSmsTemplateWithOptions(DescribeSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsTemplateResponse>(DoRPCRequest("DescribeSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmsTemplateResponse> DescribeSmsTemplateWithOptionsAsync(DescribeSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsTemplateResponse>(await DoRPCRequestAsync("DescribeSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmsTemplateResponse DescribeSmsTemplate(DescribeSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsTemplateWithOptions(request, runtime);
        }

        public async Task<DescribeSmsTemplateResponse> DescribeSmsTemplateAsync(DescribeSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeSmsTemplateStatusResponse DescribeSmsTemplateStatusWithOptions(DescribeSmsTemplateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsTemplateStatusResponse>(DoRPCRequest("DescribeSmsTemplateStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmsTemplateStatusResponse> DescribeSmsTemplateStatusWithOptionsAsync(DescribeSmsTemplateStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmsTemplateStatusResponse>(await DoRPCRequestAsync("DescribeSmsTemplateStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmsTemplateStatusResponse DescribeSmsTemplateStatus(DescribeSmsTemplateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmsTemplateStatusWithOptions(request, runtime);
        }

        public async Task<DescribeSmsTemplateStatusResponse> DescribeSmsTemplateStatusAsync(DescribeSmsTemplateStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmsTemplateStatusWithOptionsAsync(request, runtime);
        }

        public DescribeSpaceResponse DescribeSpaceWithOptions(DescribeSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpaceResponse>(DoRPCRequest("DescribeSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSpaceResponse> DescribeSpaceWithOptionsAsync(DescribeSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpaceResponse>(await DoRPCRequestAsync("DescribeSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSpaceResponse DescribeSpace(DescribeSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpaceWithOptions(request, runtime);
        }

        public async Task<DescribeSpaceResponse> DescribeSpaceAsync(DescribeSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpaceWithOptionsAsync(request, runtime);
        }

        public DescribeSpaceClientConfigResponse DescribeSpaceClientConfigWithOptions(DescribeSpaceClientConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpaceClientConfigResponse>(DoRPCRequest("DescribeSpaceClientConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSpaceClientConfigResponse> DescribeSpaceClientConfigWithOptionsAsync(DescribeSpaceClientConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpaceClientConfigResponse>(await DoRPCRequestAsync("DescribeSpaceClientConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSpaceClientConfigResponse DescribeSpaceClientConfig(DescribeSpaceClientConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpaceClientConfigWithOptions(request, runtime);
        }

        public async Task<DescribeSpaceClientConfigResponse> DescribeSpaceClientConfigAsync(DescribeSpaceClientConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpaceClientConfigWithOptionsAsync(request, runtime);
        }

        public DescribeWebHostingFileResponse DescribeWebHostingFileWithOptions(DescribeWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebHostingFileResponse>(DoRPCRequest("DescribeWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebHostingFileResponse> DescribeWebHostingFileWithOptionsAsync(DescribeWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebHostingFileResponse>(await DoRPCRequestAsync("DescribeWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebHostingFileResponse DescribeWebHostingFile(DescribeWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebHostingFileWithOptions(request, runtime);
        }

        public async Task<DescribeWebHostingFileResponse> DescribeWebHostingFileAsync(DescribeWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebHostingFileWithOptionsAsync(request, runtime);
        }

        public EnableExtensionResponse EnableExtensionWithOptions(EnableExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableExtensionResponse>(DoRPCRequest("EnableExtension", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableExtensionResponse> EnableExtensionWithOptionsAsync(EnableExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableExtensionResponse>(await DoRPCRequestAsync("EnableExtension", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableExtensionResponse EnableExtension(EnableExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableExtensionWithOptions(request, runtime);
        }

        public async Task<EnableExtensionResponse> EnableExtensionAsync(EnableExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableExtensionWithOptionsAsync(request, runtime);
        }

        public EnableSmsServiceResponse EnableSmsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<EnableSmsServiceResponse>(DoRPCRequest("EnableSmsService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSmsServiceResponse> EnableSmsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<EnableSmsServiceResponse>(await DoRPCRequestAsync("EnableSmsService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSmsServiceResponse EnableSmsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSmsServiceWithOptions(runtime);
        }

        public async Task<EnableSmsServiceResponse> EnableSmsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSmsServiceWithOptionsAsync(runtime);
        }

        public GetWebHostingCertificateDetailResponse GetWebHostingCertificateDetailWithOptions(GetWebHostingCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingCertificateDetailResponse>(DoRPCRequest("GetWebHostingCertificateDetail", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebHostingCertificateDetailResponse> GetWebHostingCertificateDetailWithOptionsAsync(GetWebHostingCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingCertificateDetailResponse>(await DoRPCRequestAsync("GetWebHostingCertificateDetail", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebHostingCertificateDetailResponse GetWebHostingCertificateDetail(GetWebHostingCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebHostingCertificateDetailWithOptions(request, runtime);
        }

        public async Task<GetWebHostingCertificateDetailResponse> GetWebHostingCertificateDetailAsync(GetWebHostingCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebHostingCertificateDetailWithOptionsAsync(request, runtime);
        }

        public GetWebHostingConfigResponse GetWebHostingConfigWithOptions(GetWebHostingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingConfigResponse>(DoRPCRequest("GetWebHostingConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebHostingConfigResponse> GetWebHostingConfigWithOptionsAsync(GetWebHostingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingConfigResponse>(await DoRPCRequestAsync("GetWebHostingConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebHostingConfigResponse GetWebHostingConfig(GetWebHostingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebHostingConfigWithOptions(request, runtime);
        }

        public async Task<GetWebHostingConfigResponse> GetWebHostingConfigAsync(GetWebHostingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebHostingConfigWithOptionsAsync(request, runtime);
        }

        public GetWebHostingDomainVerificationContentResponse GetWebHostingDomainVerificationContentWithOptions(GetWebHostingDomainVerificationContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingDomainVerificationContentResponse>(DoRPCRequest("GetWebHostingDomainVerificationContent", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebHostingDomainVerificationContentResponse> GetWebHostingDomainVerificationContentWithOptionsAsync(GetWebHostingDomainVerificationContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingDomainVerificationContentResponse>(await DoRPCRequestAsync("GetWebHostingDomainVerificationContent", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebHostingDomainVerificationContentResponse GetWebHostingDomainVerificationContent(GetWebHostingDomainVerificationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebHostingDomainVerificationContentWithOptions(request, runtime);
        }

        public async Task<GetWebHostingDomainVerificationContentResponse> GetWebHostingDomainVerificationContentAsync(GetWebHostingDomainVerificationContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebHostingDomainVerificationContentWithOptionsAsync(request, runtime);
        }

        public GetWebHostingStatusResponse GetWebHostingStatusWithOptions(GetWebHostingStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingStatusResponse>(DoRPCRequest("GetWebHostingStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebHostingStatusResponse> GetWebHostingStatusWithOptionsAsync(GetWebHostingStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingStatusResponse>(await DoRPCRequestAsync("GetWebHostingStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebHostingStatusResponse GetWebHostingStatus(GetWebHostingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebHostingStatusWithOptions(request, runtime);
        }

        public async Task<GetWebHostingStatusResponse> GetWebHostingStatusAsync(GetWebHostingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebHostingStatusWithOptionsAsync(request, runtime);
        }

        public GetWebHostingUploadCredentialResponse GetWebHostingUploadCredentialWithOptions(GetWebHostingUploadCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingUploadCredentialResponse>(DoRPCRequest("GetWebHostingUploadCredential", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetWebHostingUploadCredentialResponse> GetWebHostingUploadCredentialWithOptionsAsync(GetWebHostingUploadCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetWebHostingUploadCredentialResponse>(await DoRPCRequestAsync("GetWebHostingUploadCredential", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetWebHostingUploadCredentialResponse GetWebHostingUploadCredential(GetWebHostingUploadCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWebHostingUploadCredentialWithOptions(request, runtime);
        }

        public async Task<GetWebHostingUploadCredentialResponse> GetWebHostingUploadCredentialAsync(GetWebHostingUploadCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWebHostingUploadCredentialWithOptionsAsync(request, runtime);
        }

        public ListAvailableCertificatesResponse ListAvailableCertificatesWithOptions(ListAvailableCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableCertificatesResponse>(DoRPCRequest("ListAvailableCertificates", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAvailableCertificatesResponse> ListAvailableCertificatesWithOptionsAsync(ListAvailableCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableCertificatesResponse>(await DoRPCRequestAsync("ListAvailableCertificates", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAvailableCertificatesResponse ListAvailableCertificates(ListAvailableCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableCertificatesWithOptions(request, runtime);
        }

        public async Task<ListAvailableCertificatesResponse> ListAvailableCertificatesAsync(ListAvailableCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableCertificatesWithOptionsAsync(request, runtime);
        }

        public ListCorsDomainsResponse ListCorsDomainsWithOptions(ListCorsDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorsDomainsResponse>(DoRPCRequest("ListCorsDomains", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorsDomainsResponse> ListCorsDomainsWithOptionsAsync(ListCorsDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorsDomainsResponse>(await DoRPCRequestAsync("ListCorsDomains", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCorsDomainsResponse ListCorsDomains(ListCorsDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorsDomainsWithOptions(request, runtime);
        }

        public async Task<ListCorsDomainsResponse> ListCorsDomainsAsync(ListCorsDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorsDomainsWithOptionsAsync(request, runtime);
        }

        public ListDingtalkOpenPlatformConfigsResponse ListDingtalkOpenPlatformConfigsWithOptions(ListDingtalkOpenPlatformConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDingtalkOpenPlatformConfigsResponse>(DoRPCRequest("ListDingtalkOpenPlatformConfigs", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDingtalkOpenPlatformConfigsResponse> ListDingtalkOpenPlatformConfigsWithOptionsAsync(ListDingtalkOpenPlatformConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDingtalkOpenPlatformConfigsResponse>(await DoRPCRequestAsync("ListDingtalkOpenPlatformConfigs", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDingtalkOpenPlatformConfigsResponse ListDingtalkOpenPlatformConfigs(ListDingtalkOpenPlatformConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDingtalkOpenPlatformConfigsWithOptions(request, runtime);
        }

        public async Task<ListDingtalkOpenPlatformConfigsResponse> ListDingtalkOpenPlatformConfigsAsync(ListDingtalkOpenPlatformConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDingtalkOpenPlatformConfigsWithOptionsAsync(request, runtime);
        }

        public ListExtensionsResponse ListExtensionsWithOptions(ListExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExtensionsResponse>(DoRPCRequest("ListExtensions", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExtensionsResponse> ListExtensionsWithOptionsAsync(ListExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExtensionsResponse>(await DoRPCRequestAsync("ListExtensions", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExtensionsResponse ListExtensions(ListExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExtensionsWithOptions(request, runtime);
        }

        public async Task<ListExtensionsResponse> ListExtensionsAsync(ListExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExtensionsWithOptionsAsync(request, runtime);
        }

        public ListFileResponse ListFileWithOptions(ListFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileResponse>(DoRPCRequest("ListFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFileResponse> ListFileWithOptionsAsync(ListFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFileResponse>(await DoRPCRequestAsync("ListFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFileResponse ListFile(ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileWithOptions(request, runtime);
        }

        public async Task<ListFileResponse> ListFileAsync(ListFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileWithOptionsAsync(request, runtime);
        }

        public ListFunctionResponse ListFunctionWithOptions(ListFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionResponse>(DoRPCRequest("ListFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionResponse> ListFunctionWithOptionsAsync(ListFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionResponse>(await DoRPCRequestAsync("ListFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionResponse ListFunction(ListFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionWithOptions(request, runtime);
        }

        public async Task<ListFunctionResponse> ListFunctionAsync(ListFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionWithOptionsAsync(request, runtime);
        }

        public ListFunctionDeploymentResponse ListFunctionDeploymentWithOptions(ListFunctionDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionDeploymentResponse>(DoRPCRequest("ListFunctionDeployment", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionDeploymentResponse> ListFunctionDeploymentWithOptionsAsync(ListFunctionDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionDeploymentResponse>(await DoRPCRequestAsync("ListFunctionDeployment", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionDeploymentResponse ListFunctionDeployment(ListFunctionDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionDeploymentWithOptions(request, runtime);
        }

        public async Task<ListFunctionDeploymentResponse> ListFunctionDeploymentAsync(ListFunctionDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionDeploymentWithOptionsAsync(request, runtime);
        }

        public ListFunctionLogResponse ListFunctionLogWithOptions(ListFunctionLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionLogResponse>(DoRPCRequest("ListFunctionLog", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionLogResponse> ListFunctionLogWithOptionsAsync(ListFunctionLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFunctionLogResponse>(await DoRPCRequestAsync("ListFunctionLog", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionLogResponse ListFunctionLog(ListFunctionLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionLogWithOptions(request, runtime);
        }

        public async Task<ListFunctionLogResponse> ListFunctionLogAsync(ListFunctionLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionLogWithOptionsAsync(request, runtime);
        }

        public ListFunctionSpecResponse ListFunctionSpecWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListFunctionSpecResponse>(DoRPCRequest("ListFunctionSpec", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFunctionSpecResponse> ListFunctionSpecWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListFunctionSpecResponse>(await DoRPCRequestAsync("ListFunctionSpec", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFunctionSpecResponse ListFunctionSpec()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFunctionSpecWithOptions(runtime);
        }

        public async Task<ListFunctionSpecResponse> ListFunctionSpecAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFunctionSpecWithOptionsAsync(runtime);
        }

        public ListOpenPlatformConfigResponse ListOpenPlatformConfigWithOptions(ListOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOpenPlatformConfigResponse>(DoRPCRequest("ListOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOpenPlatformConfigResponse> ListOpenPlatformConfigWithOptionsAsync(ListOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOpenPlatformConfigResponse>(await DoRPCRequestAsync("ListOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOpenPlatformConfigResponse ListOpenPlatformConfig(ListOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<ListOpenPlatformConfigResponse> ListOpenPlatformConfigAsync(ListOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public ListSmsSignsResponse ListSmsSignsWithOptions(ListSmsSignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsSignsResponse>(DoRPCRequest("ListSmsSigns", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmsSignsResponse> ListSmsSignsWithOptionsAsync(ListSmsSignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsSignsResponse>(await DoRPCRequestAsync("ListSmsSigns", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmsSignsResponse ListSmsSigns(ListSmsSignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmsSignsWithOptions(request, runtime);
        }

        public async Task<ListSmsSignsResponse> ListSmsSignsAsync(ListSmsSignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmsSignsWithOptionsAsync(request, runtime);
        }

        public ListSmsSignsForAccountResponse ListSmsSignsForAccountWithOptions(ListSmsSignsForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsSignsForAccountResponse>(DoRPCRequest("ListSmsSignsForAccount", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmsSignsForAccountResponse> ListSmsSignsForAccountWithOptionsAsync(ListSmsSignsForAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsSignsForAccountResponse>(await DoRPCRequestAsync("ListSmsSignsForAccount", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmsSignsForAccountResponse ListSmsSignsForAccount(ListSmsSignsForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmsSignsForAccountWithOptions(request, runtime);
        }

        public async Task<ListSmsSignsForAccountResponse> ListSmsSignsForAccountAsync(ListSmsSignsForAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmsSignsForAccountWithOptionsAsync(request, runtime);
        }

        public ListSmsTemplatesResponse ListSmsTemplatesWithOptions(ListSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsTemplatesResponse>(DoRPCRequest("ListSmsTemplates", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmsTemplatesResponse> ListSmsTemplatesWithOptionsAsync(ListSmsTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmsTemplatesResponse>(await DoRPCRequestAsync("ListSmsTemplates", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmsTemplatesResponse ListSmsTemplates(ListSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmsTemplatesWithOptions(request, runtime);
        }

        public async Task<ListSmsTemplatesResponse> ListSmsTemplatesAsync(ListSmsTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmsTemplatesWithOptionsAsync(request, runtime);
        }

        public ListSpaceResponse ListSpaceWithOptions(ListSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSpaceResponse>(DoRPCRequest("ListSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSpaceResponse> ListSpaceWithOptionsAsync(ListSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSpaceResponse>(await DoRPCRequestAsync("ListSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSpaceResponse ListSpace(ListSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSpaceWithOptions(request, runtime);
        }

        public async Task<ListSpaceResponse> ListSpaceAsync(ListSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSpaceWithOptionsAsync(request, runtime);
        }

        public ListWebHostingCustomDomainsResponse ListWebHostingCustomDomainsWithOptions(ListWebHostingCustomDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWebHostingCustomDomainsResponse>(DoRPCRequest("ListWebHostingCustomDomains", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListWebHostingCustomDomainsResponse> ListWebHostingCustomDomainsWithOptionsAsync(ListWebHostingCustomDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWebHostingCustomDomainsResponse>(await DoRPCRequestAsync("ListWebHostingCustomDomains", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListWebHostingCustomDomainsResponse ListWebHostingCustomDomains(ListWebHostingCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWebHostingCustomDomainsWithOptions(request, runtime);
        }

        public async Task<ListWebHostingCustomDomainsResponse> ListWebHostingCustomDomainsAsync(ListWebHostingCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWebHostingCustomDomainsWithOptionsAsync(request, runtime);
        }

        public ListWebHostingFilesResponse ListWebHostingFilesWithOptions(ListWebHostingFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWebHostingFilesResponse>(DoRPCRequest("ListWebHostingFiles", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListWebHostingFilesResponse> ListWebHostingFilesWithOptionsAsync(ListWebHostingFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListWebHostingFilesResponse>(await DoRPCRequestAsync("ListWebHostingFiles", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListWebHostingFilesResponse ListWebHostingFiles(ListWebHostingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWebHostingFilesWithOptions(request, runtime);
        }

        public async Task<ListWebHostingFilesResponse> ListWebHostingFilesAsync(ListWebHostingFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWebHostingFilesWithOptionsAsync(request, runtime);
        }

        public ModifyWebHostingConfigResponse ModifyWebHostingConfigWithOptions(ModifyWebHostingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebHostingConfigResponse>(DoRPCRequest("ModifyWebHostingConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWebHostingConfigResponse> ModifyWebHostingConfigWithOptionsAsync(ModifyWebHostingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWebHostingConfigResponse>(await DoRPCRequestAsync("ModifyWebHostingConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWebHostingConfigResponse ModifyWebHostingConfig(ModifyWebHostingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWebHostingConfigWithOptions(request, runtime);
        }

        public async Task<ModifyWebHostingConfigResponse> ModifyWebHostingConfigAsync(ModifyWebHostingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWebHostingConfigWithOptionsAsync(request, runtime);
        }

        public MoveWebHostingFileResponse MoveWebHostingFileWithOptions(MoveWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveWebHostingFileResponse>(DoRPCRequest("MoveWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveWebHostingFileResponse> MoveWebHostingFileWithOptionsAsync(MoveWebHostingFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveWebHostingFileResponse>(await DoRPCRequestAsync("MoveWebHostingFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveWebHostingFileResponse MoveWebHostingFile(MoveWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveWebHostingFileWithOptions(request, runtime);
        }

        public async Task<MoveWebHostingFileResponse> MoveWebHostingFileAsync(MoveWebHostingFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveWebHostingFileWithOptionsAsync(request, runtime);
        }

        public OpenProductResponse OpenProductWithOptions(OpenProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenProductResponse>(DoRPCRequest("OpenProduct", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenProductResponse> OpenProductWithOptionsAsync(OpenProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenProductResponse>(await DoRPCRequestAsync("OpenProduct", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenProductResponse OpenProduct(OpenProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenProductWithOptions(request, runtime);
        }

        public async Task<OpenProductResponse> OpenProductAsync(OpenProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenProductWithOptionsAsync(request, runtime);
        }

        public OpenServiceResponse OpenServiceWithOptions(OpenServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenServiceResponse>(DoRPCRequest("OpenService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenServiceResponse> OpenServiceWithOptionsAsync(OpenServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenServiceResponse>(await DoRPCRequestAsync("OpenService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenServiceResponse OpenService(OpenServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenServiceWithOptions(request, runtime);
        }

        public async Task<OpenServiceResponse> OpenServiceAsync(OpenServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenServiceWithOptionsAsync(request, runtime);
        }

        public OpenWebHostingServiceResponse OpenWebHostingServiceWithOptions(OpenWebHostingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenWebHostingServiceResponse>(DoRPCRequest("OpenWebHostingService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenWebHostingServiceResponse> OpenWebHostingServiceWithOptionsAsync(OpenWebHostingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenWebHostingServiceResponse>(await DoRPCRequestAsync("OpenWebHostingService", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenWebHostingServiceResponse OpenWebHostingService(OpenWebHostingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenWebHostingServiceWithOptions(request, runtime);
        }

        public async Task<OpenWebHostingServiceResponse> OpenWebHostingServiceAsync(OpenWebHostingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenWebHostingServiceWithOptionsAsync(request, runtime);
        }

        public QueryDBBackupCollectionsResponse QueryDBBackupCollectionsWithOptions(QueryDBBackupCollectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBBackupCollectionsResponse>(DoRPCRequest("QueryDBBackupCollections", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDBBackupCollectionsResponse> QueryDBBackupCollectionsWithOptionsAsync(QueryDBBackupCollectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBBackupCollectionsResponse>(await DoRPCRequestAsync("QueryDBBackupCollections", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDBBackupCollectionsResponse QueryDBBackupCollections(QueryDBBackupCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDBBackupCollectionsWithOptions(request, runtime);
        }

        public async Task<QueryDBBackupCollectionsResponse> QueryDBBackupCollectionsAsync(QueryDBBackupCollectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDBBackupCollectionsWithOptionsAsync(request, runtime);
        }

        public QueryDBBackupDumpTimesResponse QueryDBBackupDumpTimesWithOptions(QueryDBBackupDumpTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBBackupDumpTimesResponse>(DoRPCRequest("QueryDBBackupDumpTimes", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDBBackupDumpTimesResponse> QueryDBBackupDumpTimesWithOptionsAsync(QueryDBBackupDumpTimesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBBackupDumpTimesResponse>(await DoRPCRequestAsync("QueryDBBackupDumpTimes", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDBBackupDumpTimesResponse QueryDBBackupDumpTimes(QueryDBBackupDumpTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDBBackupDumpTimesWithOptions(request, runtime);
        }

        public async Task<QueryDBBackupDumpTimesResponse> QueryDBBackupDumpTimesAsync(QueryDBBackupDumpTimesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDBBackupDumpTimesWithOptionsAsync(request, runtime);
        }

        public QueryDBExportTaskStatusResponse QueryDBExportTaskStatusWithOptions(QueryDBExportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBExportTaskStatusResponse>(DoRPCRequest("QueryDBExportTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDBExportTaskStatusResponse> QueryDBExportTaskStatusWithOptionsAsync(QueryDBExportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBExportTaskStatusResponse>(await DoRPCRequestAsync("QueryDBExportTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDBExportTaskStatusResponse QueryDBExportTaskStatus(QueryDBExportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDBExportTaskStatusWithOptions(request, runtime);
        }

        public async Task<QueryDBExportTaskStatusResponse> QueryDBExportTaskStatusAsync(QueryDBExportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDBExportTaskStatusWithOptionsAsync(request, runtime);
        }

        public QueryDBImportTaskStatusResponse QueryDBImportTaskStatusWithOptions(QueryDBImportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBImportTaskStatusResponse>(DoRPCRequest("QueryDBImportTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDBImportTaskStatusResponse> QueryDBImportTaskStatusWithOptionsAsync(QueryDBImportTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBImportTaskStatusResponse>(await DoRPCRequestAsync("QueryDBImportTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDBImportTaskStatusResponse QueryDBImportTaskStatus(QueryDBImportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDBImportTaskStatusWithOptions(request, runtime);
        }

        public async Task<QueryDBImportTaskStatusResponse> QueryDBImportTaskStatusAsync(QueryDBImportTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDBImportTaskStatusWithOptionsAsync(request, runtime);
        }

        public QueryDBRestoreTaskStatusResponse QueryDBRestoreTaskStatusWithOptions(QueryDBRestoreTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBRestoreTaskStatusResponse>(DoRPCRequest("QueryDBRestoreTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDBRestoreTaskStatusResponse> QueryDBRestoreTaskStatusWithOptionsAsync(QueryDBRestoreTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDBRestoreTaskStatusResponse>(await DoRPCRequestAsync("QueryDBRestoreTaskStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDBRestoreTaskStatusResponse QueryDBRestoreTaskStatus(QueryDBRestoreTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDBRestoreTaskStatusWithOptions(request, runtime);
        }

        public async Task<QueryDBRestoreTaskStatusResponse> QueryDBRestoreTaskStatusAsync(QueryDBRestoreTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDBRestoreTaskStatusWithOptionsAsync(request, runtime);
        }

        public QueryServiceStatusResponse QueryServiceStatusWithOptions(QueryServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryServiceStatusResponse>(DoRPCRequest("QueryServiceStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryServiceStatusResponse> QueryServiceStatusWithOptionsAsync(QueryServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryServiceStatusResponse>(await DoRPCRequestAsync("QueryServiceStatus", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryServiceStatusResponse QueryServiceStatus(QueryServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryServiceStatusWithOptions(request, runtime);
        }

        public async Task<QueryServiceStatusResponse> QueryServiceStatusAsync(QueryServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryServiceStatusWithOptionsAsync(request, runtime);
        }

        public RegisterFileResponse RegisterFileWithOptions(RegisterFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterFileResponse>(DoRPCRequest("RegisterFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterFileResponse> RegisterFileWithOptionsAsync(RegisterFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterFileResponse>(await DoRPCRequestAsync("RegisterFile", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterFileResponse RegisterFile(RegisterFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterFileWithOptions(request, runtime);
        }

        public async Task<RegisterFileResponse> RegisterFileAsync(RegisterFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterFileWithOptionsAsync(request, runtime);
        }

        public ReleaseBuiltinFunctionTemplateResponse ReleaseBuiltinFunctionTemplateWithOptions(ReleaseBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseBuiltinFunctionTemplateResponse>(DoRPCRequest("ReleaseBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseBuiltinFunctionTemplateResponse> ReleaseBuiltinFunctionTemplateWithOptionsAsync(ReleaseBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseBuiltinFunctionTemplateResponse>(await DoRPCRequestAsync("ReleaseBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseBuiltinFunctionTemplateResponse ReleaseBuiltinFunctionTemplate(ReleaseBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseBuiltinFunctionTemplateWithOptions(request, runtime);
        }

        public async Task<ReleaseBuiltinFunctionTemplateResponse> ReleaseBuiltinFunctionTemplateAsync(ReleaseBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseBuiltinFunctionTemplateWithOptionsAsync(request, runtime);
        }

        public RenameDBCollectionResponse RenameDBCollectionWithOptions(RenameDBCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDBCollectionResponse>(DoRPCRequest("RenameDBCollection", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameDBCollectionResponse> RenameDBCollectionWithOptionsAsync(RenameDBCollectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDBCollectionResponse>(await DoRPCRequestAsync("RenameDBCollection", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameDBCollectionResponse RenameDBCollection(RenameDBCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameDBCollectionWithOptions(request, runtime);
        }

        public async Task<RenameDBCollectionResponse> RenameDBCollectionAsync(RenameDBCollectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameDBCollectionWithOptionsAsync(request, runtime);
        }

        public ResetServerSecretResponse ResetServerSecretWithOptions(ResetServerSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetServerSecretResponse>(DoRPCRequest("ResetServerSecret", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetServerSecretResponse> ResetServerSecretWithOptionsAsync(ResetServerSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetServerSecretResponse>(await DoRPCRequestAsync("ResetServerSecret", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetServerSecretResponse ResetServerSecret(ResetServerSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetServerSecretWithOptions(request, runtime);
        }

        public async Task<ResetServerSecretResponse> ResetServerSecretAsync(ResetServerSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetServerSecretWithOptionsAsync(request, runtime);
        }

        public RunDBCommandResponse RunDBCommandWithOptions(RunDBCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunDBCommandResponse>(DoRPCRequest("RunDBCommand", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunDBCommandResponse> RunDBCommandWithOptionsAsync(RunDBCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunDBCommandResponse>(await DoRPCRequestAsync("RunDBCommand", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunDBCommandResponse RunDBCommand(RunDBCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunDBCommandWithOptions(request, runtime);
        }

        public async Task<RunDBCommandResponse> RunDBCommandAsync(RunDBCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunDBCommandWithOptionsAsync(request, runtime);
        }

        public RunFunctionResponse RunFunctionWithOptions(RunFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunFunctionResponse>(DoRPCRequest("RunFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunFunctionResponse> RunFunctionWithOptionsAsync(RunFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunFunctionResponse>(await DoRPCRequestAsync("RunFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunFunctionResponse RunFunction(RunFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunFunctionWithOptions(request, runtime);
        }

        public async Task<RunFunctionResponse> RunFunctionAsync(RunFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunFunctionWithOptionsAsync(request, runtime);
        }

        public SaveAntOpenPlatformConfigResponse SaveAntOpenPlatformConfigWithOptions(SaveAntOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveAntOpenPlatformConfigResponse>(DoRPCRequest("SaveAntOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveAntOpenPlatformConfigResponse> SaveAntOpenPlatformConfigWithOptionsAsync(SaveAntOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveAntOpenPlatformConfigResponse>(await DoRPCRequestAsync("SaveAntOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveAntOpenPlatformConfigResponse SaveAntOpenPlatformConfig(SaveAntOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAntOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<SaveAntOpenPlatformConfigResponse> SaveAntOpenPlatformConfigAsync(SaveAntOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAntOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public SaveAppAuthTokenResponse SaveAppAuthTokenWithOptions(SaveAppAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveAppAuthTokenResponse>(DoRPCRequest("SaveAppAuthToken", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveAppAuthTokenResponse> SaveAppAuthTokenWithOptionsAsync(SaveAppAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveAppAuthTokenResponse>(await DoRPCRequestAsync("SaveAppAuthToken", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveAppAuthTokenResponse SaveAppAuthToken(SaveAppAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveAppAuthTokenWithOptions(request, runtime);
        }

        public async Task<SaveAppAuthTokenResponse> SaveAppAuthTokenAsync(SaveAppAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveAppAuthTokenWithOptionsAsync(request, runtime);
        }

        public SaveBuiltinFunctionTemplateResponse SaveBuiltinFunctionTemplateWithOptions(SaveBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBuiltinFunctionTemplateResponse>(DoRPCRequest("SaveBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBuiltinFunctionTemplateResponse> SaveBuiltinFunctionTemplateWithOptionsAsync(SaveBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBuiltinFunctionTemplateResponse>(await DoRPCRequestAsync("SaveBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveBuiltinFunctionTemplateResponse SaveBuiltinFunctionTemplate(SaveBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBuiltinFunctionTemplateWithOptions(request, runtime);
        }

        public async Task<SaveBuiltinFunctionTemplateResponse> SaveBuiltinFunctionTemplateAsync(SaveBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBuiltinFunctionTemplateWithOptionsAsync(request, runtime);
        }

        public SaveWebHostingCustomDomainConfigResponse SaveWebHostingCustomDomainConfigWithOptions(SaveWebHostingCustomDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebHostingCustomDomainConfigResponse>(DoRPCRequest("SaveWebHostingCustomDomainConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveWebHostingCustomDomainConfigResponse> SaveWebHostingCustomDomainConfigWithOptionsAsync(SaveWebHostingCustomDomainConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWebHostingCustomDomainConfigResponse>(await DoRPCRequestAsync("SaveWebHostingCustomDomainConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveWebHostingCustomDomainConfigResponse SaveWebHostingCustomDomainConfig(SaveWebHostingCustomDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebHostingCustomDomainConfigWithOptions(request, runtime);
        }

        public async Task<SaveWebHostingCustomDomainConfigResponse> SaveWebHostingCustomDomainConfigAsync(SaveWebHostingCustomDomainConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebHostingCustomDomainConfigWithOptionsAsync(request, runtime);
        }

        public SaveWechatOpenPlatformConfigResponse SaveWechatOpenPlatformConfigWithOptions(SaveWechatOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWechatOpenPlatformConfigResponse>(DoRPCRequest("SaveWechatOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveWechatOpenPlatformConfigResponse> SaveWechatOpenPlatformConfigWithOptionsAsync(SaveWechatOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveWechatOpenPlatformConfigResponse>(await DoRPCRequestAsync("SaveWechatOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveWechatOpenPlatformConfigResponse SaveWechatOpenPlatformConfig(SaveWechatOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWechatOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<SaveWechatOpenPlatformConfigResponse> SaveWechatOpenPlatformConfigAsync(SaveWechatOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWechatOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public UnbindWebHostingCustomDomainResponse UnbindWebHostingCustomDomainWithOptions(UnbindWebHostingCustomDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindWebHostingCustomDomainResponse>(DoRPCRequest("UnbindWebHostingCustomDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindWebHostingCustomDomainResponse> UnbindWebHostingCustomDomainWithOptionsAsync(UnbindWebHostingCustomDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindWebHostingCustomDomainResponse>(await DoRPCRequestAsync("UnbindWebHostingCustomDomain", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindWebHostingCustomDomainResponse UnbindWebHostingCustomDomain(UnbindWebHostingCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindWebHostingCustomDomainWithOptions(request, runtime);
        }

        public async Task<UnbindWebHostingCustomDomainResponse> UnbindWebHostingCustomDomainAsync(UnbindWebHostingCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindWebHostingCustomDomainWithOptionsAsync(request, runtime);
        }

        public UpdateDingtalkOpenPlatformConfigResponse UpdateDingtalkOpenPlatformConfigWithOptions(UpdateDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDingtalkOpenPlatformConfigResponse>(DoRPCRequest("UpdateDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDingtalkOpenPlatformConfigResponse> UpdateDingtalkOpenPlatformConfigWithOptionsAsync(UpdateDingtalkOpenPlatformConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDingtalkOpenPlatformConfigResponse>(await DoRPCRequestAsync("UpdateDingtalkOpenPlatformConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDingtalkOpenPlatformConfigResponse UpdateDingtalkOpenPlatformConfig(UpdateDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDingtalkOpenPlatformConfigWithOptions(request, runtime);
        }

        public async Task<UpdateDingtalkOpenPlatformConfigResponse> UpdateDingtalkOpenPlatformConfigAsync(UpdateDingtalkOpenPlatformConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDingtalkOpenPlatformConfigWithOptionsAsync(request, runtime);
        }

        public UpdateFunctionResponse UpdateFunctionWithOptions(UpdateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(DoRPCRequest("UpdateFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionWithOptionsAsync(UpdateFunctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFunctionResponse>(await DoRPCRequestAsync("UpdateFunction", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFunctionWithOptions(request, runtime);
        }

        public async Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFunctionWithOptionsAsync(request, runtime);
        }

        public UpdateHttpTriggerConfigResponse UpdateHttpTriggerConfigWithOptions(UpdateHttpTriggerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateHttpTriggerConfigResponse>(DoRPCRequest("UpdateHttpTriggerConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateHttpTriggerConfigResponse> UpdateHttpTriggerConfigWithOptionsAsync(UpdateHttpTriggerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateHttpTriggerConfigResponse>(await DoRPCRequestAsync("UpdateHttpTriggerConfig", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateHttpTriggerConfigResponse UpdateHttpTriggerConfig(UpdateHttpTriggerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHttpTriggerConfigWithOptions(request, runtime);
        }

        public async Task<UpdateHttpTriggerConfigResponse> UpdateHttpTriggerConfigAsync(UpdateHttpTriggerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHttpTriggerConfigWithOptionsAsync(request, runtime);
        }

        public UpdateServicePolicyResponse UpdateServicePolicyWithOptions(UpdateServicePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServicePolicyResponse>(DoRPCRequest("UpdateServicePolicy", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateServicePolicyResponse> UpdateServicePolicyWithOptionsAsync(UpdateServicePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServicePolicyResponse>(await DoRPCRequestAsync("UpdateServicePolicy", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateServicePolicyResponse UpdateServicePolicy(UpdateServicePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServicePolicyWithOptions(request, runtime);
        }

        public async Task<UpdateServicePolicyResponse> UpdateServicePolicyAsync(UpdateServicePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServicePolicyWithOptionsAsync(request, runtime);
        }

        public UpdateSmsSignResponse UpdateSmsSignWithOptions(UpdateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmsSignResponse>(DoRPCRequest("UpdateSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmsSignResponse> UpdateSmsSignWithOptionsAsync(UpdateSmsSignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmsSignResponse>(await DoRPCRequestAsync("UpdateSmsSign", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmsSignResponse UpdateSmsSign(UpdateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmsSignWithOptions(request, runtime);
        }

        public async Task<UpdateSmsSignResponse> UpdateSmsSignAsync(UpdateSmsSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmsSignWithOptionsAsync(request, runtime);
        }

        public UpdateSmsTemplateResponse UpdateSmsTemplateWithOptions(UpdateSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmsTemplateResponse>(DoRPCRequest("UpdateSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmsTemplateResponse> UpdateSmsTemplateWithOptionsAsync(UpdateSmsTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmsTemplateResponse>(await DoRPCRequestAsync("UpdateSmsTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmsTemplateResponse UpdateSmsTemplate(UpdateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmsTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateSmsTemplateResponse> UpdateSmsTemplateAsync(UpdateSmsTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmsTemplateWithOptionsAsync(request, runtime);
        }

        public UpdateSpaceResponse UpdateSpaceWithOptions(UpdateSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSpaceResponse>(DoRPCRequest("UpdateSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSpaceResponse> UpdateSpaceWithOptionsAsync(UpdateSpaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSpaceResponse>(await DoRPCRequestAsync("UpdateSpace", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSpaceResponse UpdateSpace(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSpaceWithOptions(request, runtime);
        }

        public async Task<UpdateSpaceResponse> UpdateSpaceAsync(UpdateSpaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSpaceWithOptionsAsync(request, runtime);
        }

        public VerifyBuiltinFunctionTemplateResponse VerifyBuiltinFunctionTemplateWithOptions(VerifyBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyBuiltinFunctionTemplateResponse>(DoRPCRequest("VerifyBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyBuiltinFunctionTemplateResponse> VerifyBuiltinFunctionTemplateWithOptionsAsync(VerifyBuiltinFunctionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyBuiltinFunctionTemplateResponse>(await DoRPCRequestAsync("VerifyBuiltinFunctionTemplate", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyBuiltinFunctionTemplateResponse VerifyBuiltinFunctionTemplate(VerifyBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyBuiltinFunctionTemplateWithOptions(request, runtime);
        }

        public async Task<VerifyBuiltinFunctionTemplateResponse> VerifyBuiltinFunctionTemplateAsync(VerifyBuiltinFunctionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyBuiltinFunctionTemplateWithOptionsAsync(request, runtime);
        }

        public VerifyWebHostingDomainOwnerResponse VerifyWebHostingDomainOwnerWithOptions(VerifyWebHostingDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyWebHostingDomainOwnerResponse>(DoRPCRequest("VerifyWebHostingDomainOwner", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyWebHostingDomainOwnerResponse> VerifyWebHostingDomainOwnerWithOptionsAsync(VerifyWebHostingDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyWebHostingDomainOwnerResponse>(await DoRPCRequestAsync("VerifyWebHostingDomainOwner", "2019-06-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyWebHostingDomainOwnerResponse VerifyWebHostingDomainOwner(VerifyWebHostingDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyWebHostingDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyWebHostingDomainOwnerResponse> VerifyWebHostingDomainOwnerAsync(VerifyWebHostingDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyWebHostingDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
