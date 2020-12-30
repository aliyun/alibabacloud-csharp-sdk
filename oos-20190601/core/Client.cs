// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Oos20190601.Models;

namespace AlibabaCloud.SDK.Oos20190601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("oos", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelExecutionResponse CancelExecutionWithOptions(CancelExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelExecutionResponse>(DoRPCRequest("CancelExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelExecutionResponse> CancelExecutionWithOptionsAsync(CancelExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelExecutionResponse>(await DoRPCRequestAsync("CancelExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelExecutionResponse CancelExecution(CancelExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelExecutionWithOptions(request, runtime);
        }

        public async Task<CancelExecutionResponse> CancelExecutionAsync(CancelExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelExecutionWithOptionsAsync(request, runtime);
        }

        public CreateParameterResponse CreateParameterWithOptions(CreateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterResponse>(DoRPCRequest("CreateParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateParameterResponse> CreateParameterWithOptionsAsync(CreateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParameterResponse>(await DoRPCRequestAsync("CreateParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateParameterResponse CreateParameter(CreateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParameterWithOptions(request, runtime);
        }

        public async Task<CreateParameterResponse> CreateParameterAsync(CreateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParameterWithOptionsAsync(request, runtime);
        }

        public CreateSecretParameterResponse CreateSecretParameterWithOptions(CreateSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecretParameterResponse>(DoRPCRequest("CreateSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSecretParameterResponse> CreateSecretParameterWithOptionsAsync(CreateSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecretParameterResponse>(await DoRPCRequestAsync("CreateSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSecretParameterResponse CreateSecretParameter(CreateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecretParameterWithOptions(request, runtime);
        }

        public async Task<CreateSecretParameterResponse> CreateSecretParameterAsync(CreateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecretParameterWithOptionsAsync(request, runtime);
        }

        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateShrinkRequest request = new CreateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(DoRPCRequest("CreateTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateTemplateShrinkRequest request = new CreateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await DoRPCRequestAsync("CreateTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTemplateWithOptions(request, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteExecutionsResponse DeleteExecutionsWithOptions(DeleteExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExecutionsResponse>(DoRPCRequest("DeleteExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExecutionsResponse> DeleteExecutionsWithOptionsAsync(DeleteExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExecutionsResponse>(await DoRPCRequestAsync("DeleteExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExecutionsResponse DeleteExecutions(DeleteExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExecutionsWithOptions(request, runtime);
        }

        public async Task<DeleteExecutionsResponse> DeleteExecutionsAsync(DeleteExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExecutionsWithOptionsAsync(request, runtime);
        }

        public DeleteParameterResponse DeleteParameterWithOptions(DeleteParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterResponse>(DoRPCRequest("DeleteParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteParameterResponse> DeleteParameterWithOptionsAsync(DeleteParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteParameterResponse>(await DoRPCRequestAsync("DeleteParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteParameterResponse DeleteParameter(DeleteParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParameterWithOptions(request, runtime);
        }

        public async Task<DeleteParameterResponse> DeleteParameterAsync(DeleteParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParameterWithOptionsAsync(request, runtime);
        }

        public DeleteSecretParameterResponse DeleteSecretParameterWithOptions(DeleteSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretParameterResponse>(DoRPCRequest("DeleteSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecretParameterResponse> DeleteSecretParameterWithOptionsAsync(DeleteSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretParameterResponse>(await DoRPCRequestAsync("DeleteSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSecretParameterResponse DeleteSecretParameter(DeleteSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretParameterWithOptions(request, runtime);
        }

        public async Task<DeleteSecretParameterResponse> DeleteSecretParameterAsync(DeleteSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretParameterWithOptionsAsync(request, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(DoRPCRequest("DeleteTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(DeleteTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoRPCRequestAsync("DeleteTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteTemplatesResponse DeleteTemplatesWithOptions(DeleteTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplatesResponse>(DoRPCRequest("DeleteTemplates", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTemplatesResponse> DeleteTemplatesWithOptionsAsync(DeleteTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTemplatesResponse>(await DoRPCRequestAsync("DeleteTemplates", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTemplatesResponse DeleteTemplates(DeleteTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTemplatesWithOptions(request, runtime);
        }

        public async Task<DeleteTemplatesResponse> DeleteTemplatesAsync(DeleteTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public GenerateExecutionPolicyResponse GenerateExecutionPolicyWithOptions(GenerateExecutionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateExecutionPolicyResponse>(DoRPCRequest("GenerateExecutionPolicy", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateExecutionPolicyResponse> GenerateExecutionPolicyWithOptionsAsync(GenerateExecutionPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateExecutionPolicyResponse>(await DoRPCRequestAsync("GenerateExecutionPolicy", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateExecutionPolicyResponse GenerateExecutionPolicy(GenerateExecutionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateExecutionPolicyWithOptions(request, runtime);
        }

        public async Task<GenerateExecutionPolicyResponse> GenerateExecutionPolicyAsync(GenerateExecutionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateExecutionPolicyWithOptionsAsync(request, runtime);
        }

        public GetExecutionTemplateResponse GetExecutionTemplateWithOptions(GetExecutionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExecutionTemplateResponse>(DoRPCRequest("GetExecutionTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetExecutionTemplateResponse> GetExecutionTemplateWithOptionsAsync(GetExecutionTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExecutionTemplateResponse>(await DoRPCRequestAsync("GetExecutionTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetExecutionTemplateResponse GetExecutionTemplate(GetExecutionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExecutionTemplateWithOptions(request, runtime);
        }

        public async Task<GetExecutionTemplateResponse> GetExecutionTemplateAsync(GetExecutionTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExecutionTemplateWithOptionsAsync(request, runtime);
        }

        public GetInventorySchemaResponse GetInventorySchemaWithOptions(GetInventorySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInventorySchemaResponse>(DoRPCRequest("GetInventorySchema", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInventorySchemaResponse> GetInventorySchemaWithOptionsAsync(GetInventorySchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInventorySchemaResponse>(await DoRPCRequestAsync("GetInventorySchema", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInventorySchemaResponse GetInventorySchema(GetInventorySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInventorySchemaWithOptions(request, runtime);
        }

        public async Task<GetInventorySchemaResponse> GetInventorySchemaAsync(GetInventorySchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInventorySchemaWithOptionsAsync(request, runtime);
        }

        public GetParameterResponse GetParameterWithOptions(GetParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParameterResponse>(DoRPCRequest("GetParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetParameterResponse> GetParameterWithOptionsAsync(GetParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParameterResponse>(await DoRPCRequestAsync("GetParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetParameterResponse GetParameter(GetParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParameterWithOptions(request, runtime);
        }

        public async Task<GetParameterResponse> GetParameterAsync(GetParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParameterWithOptionsAsync(request, runtime);
        }

        public GetParametersResponse GetParametersWithOptions(GetParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersResponse>(DoRPCRequest("GetParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetParametersResponse> GetParametersWithOptionsAsync(GetParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersResponse>(await DoRPCRequestAsync("GetParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetParametersResponse GetParameters(GetParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersWithOptions(request, runtime);
        }

        public async Task<GetParametersResponse> GetParametersAsync(GetParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersWithOptionsAsync(request, runtime);
        }

        public GetParametersByPathResponse GetParametersByPathWithOptions(GetParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersByPathResponse>(DoRPCRequest("GetParametersByPath", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetParametersByPathResponse> GetParametersByPathWithOptionsAsync(GetParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetParametersByPathResponse>(await DoRPCRequestAsync("GetParametersByPath", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetParametersByPathResponse GetParametersByPath(GetParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParametersByPathWithOptions(request, runtime);
        }

        public async Task<GetParametersByPathResponse> GetParametersByPathAsync(GetParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParametersByPathWithOptionsAsync(request, runtime);
        }

        public GetSecretParameterResponse GetSecretParameterWithOptions(GetSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParameterResponse>(DoRPCRequest("GetSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSecretParameterResponse> GetSecretParameterWithOptionsAsync(GetSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParameterResponse>(await DoRPCRequestAsync("GetSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSecretParameterResponse GetSecretParameter(GetSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParameterWithOptions(request, runtime);
        }

        public async Task<GetSecretParameterResponse> GetSecretParameterAsync(GetSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParameterWithOptionsAsync(request, runtime);
        }

        public GetSecretParametersResponse GetSecretParametersWithOptions(GetSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParametersResponse>(DoRPCRequest("GetSecretParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSecretParametersResponse> GetSecretParametersWithOptionsAsync(GetSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParametersResponse>(await DoRPCRequestAsync("GetSecretParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSecretParametersResponse GetSecretParameters(GetSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParametersWithOptions(request, runtime);
        }

        public async Task<GetSecretParametersResponse> GetSecretParametersAsync(GetSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParametersWithOptionsAsync(request, runtime);
        }

        public GetSecretParametersByPathResponse GetSecretParametersByPathWithOptions(GetSecretParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParametersByPathResponse>(DoRPCRequest("GetSecretParametersByPath", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSecretParametersByPathResponse> GetSecretParametersByPathWithOptionsAsync(GetSecretParametersByPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretParametersByPathResponse>(await DoRPCRequestAsync("GetSecretParametersByPath", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSecretParametersByPathResponse GetSecretParametersByPath(GetSecretParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretParametersByPathWithOptions(request, runtime);
        }

        public async Task<GetSecretParametersByPathResponse> GetSecretParametersByPathAsync(GetSecretParametersByPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretParametersByPathWithOptionsAsync(request, runtime);
        }

        public GetServiceSettingsResponse GetServiceSettingsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetServiceSettingsResponse>(DoRPCRequest("GetServiceSettings", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceSettingsResponse> GetServiceSettingsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetServiceSettingsResponse>(await DoRPCRequestAsync("GetServiceSettings", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceSettingsResponse GetServiceSettings()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceSettingsWithOptions(runtime);
        }

        public async Task<GetServiceSettingsResponse> GetServiceSettingsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceSettingsWithOptionsAsync(runtime);
        }

        public GetTemplateResponse GetTemplateWithOptions(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTemplateResponse>(DoRPCRequest("GetTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTemplateResponse> GetTemplateWithOptionsAsync(GetTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTemplateResponse>(await DoRPCRequestAsync("GetTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTemplateWithOptions(request, runtime);
        }

        public async Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTemplateWithOptionsAsync(request, runtime);
        }

        public ListActionsResponse ListActionsWithOptions(ListActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListActionsResponse>(DoRPCRequest("ListActions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListActionsResponse> ListActionsWithOptionsAsync(ListActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListActionsResponse>(await DoRPCRequestAsync("ListActions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListActionsResponse ListActions(ListActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListActionsWithOptions(request, runtime);
        }

        public async Task<ListActionsResponse> ListActionsAsync(ListActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListActionsWithOptionsAsync(request, runtime);
        }

        public ListExecutionLogsResponse ListExecutionLogsWithOptions(ListExecutionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionLogsResponse>(DoRPCRequest("ListExecutionLogs", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExecutionLogsResponse> ListExecutionLogsWithOptionsAsync(ListExecutionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionLogsResponse>(await DoRPCRequestAsync("ListExecutionLogs", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExecutionLogsResponse ListExecutionLogs(ListExecutionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionLogsWithOptions(request, runtime);
        }

        public async Task<ListExecutionLogsResponse> ListExecutionLogsAsync(ListExecutionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionLogsWithOptionsAsync(request, runtime);
        }

        public ListExecutionRiskyTasksResponse ListExecutionRiskyTasksWithOptions(ListExecutionRiskyTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionRiskyTasksResponse>(DoRPCRequest("ListExecutionRiskyTasks", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExecutionRiskyTasksResponse> ListExecutionRiskyTasksWithOptionsAsync(ListExecutionRiskyTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionRiskyTasksResponse>(await DoRPCRequestAsync("ListExecutionRiskyTasks", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExecutionRiskyTasksResponse ListExecutionRiskyTasks(ListExecutionRiskyTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionRiskyTasksWithOptions(request, runtime);
        }

        public async Task<ListExecutionRiskyTasksResponse> ListExecutionRiskyTasksAsync(ListExecutionRiskyTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionRiskyTasksWithOptionsAsync(request, runtime);
        }

        public ListExecutionsResponse ListExecutionsWithOptions(ListExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutionsShrinkRequest request = new ListExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionsResponse>(DoRPCRequest("ListExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExecutionsResponse> ListExecutionsWithOptionsAsync(ListExecutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListExecutionsShrinkRequest request = new ListExecutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionsResponse>(await DoRPCRequestAsync("ListExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionsWithOptions(request, runtime);
        }

        public async Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionsWithOptionsAsync(request, runtime);
        }

        public ListInventoryEntriesResponse ListInventoryEntriesWithOptions(ListInventoryEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInventoryEntriesResponse>(DoRPCRequest("ListInventoryEntries", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInventoryEntriesResponse> ListInventoryEntriesWithOptionsAsync(ListInventoryEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInventoryEntriesResponse>(await DoRPCRequestAsync("ListInventoryEntries", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInventoryEntriesResponse ListInventoryEntries(ListInventoryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInventoryEntriesWithOptions(request, runtime);
        }

        public async Task<ListInventoryEntriesResponse> ListInventoryEntriesAsync(ListInventoryEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInventoryEntriesWithOptionsAsync(request, runtime);
        }

        public ListParametersResponse ListParametersWithOptions(ListParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParametersResponse>(DoRPCRequest("ListParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListParametersResponse> ListParametersWithOptionsAsync(ListParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParametersResponse>(await DoRPCRequestAsync("ListParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListParametersResponse ListParameters(ListParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParametersWithOptions(request, runtime);
        }

        public async Task<ListParametersResponse> ListParametersAsync(ListParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParametersWithOptionsAsync(request, runtime);
        }

        public ListParameterVersionsResponse ListParameterVersionsWithOptions(ListParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParameterVersionsResponse>(DoRPCRequest("ListParameterVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListParameterVersionsResponse> ListParameterVersionsWithOptionsAsync(ListParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListParameterVersionsResponse>(await DoRPCRequestAsync("ListParameterVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListParameterVersionsResponse ListParameterVersions(ListParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParameterVersionsWithOptions(request, runtime);
        }

        public async Task<ListParameterVersionsResponse> ListParameterVersionsAsync(ListParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParameterVersionsWithOptionsAsync(request, runtime);
        }

        public ListResourceExecutionStatusResponse ListResourceExecutionStatusWithOptions(ListResourceExecutionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceExecutionStatusResponse>(DoRPCRequest("ListResourceExecutionStatus", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListResourceExecutionStatusResponse> ListResourceExecutionStatusWithOptionsAsync(ListResourceExecutionStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourceExecutionStatusResponse>(await DoRPCRequestAsync("ListResourceExecutionStatus", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListResourceExecutionStatusResponse ListResourceExecutionStatus(ListResourceExecutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceExecutionStatusWithOptions(request, runtime);
        }

        public async Task<ListResourceExecutionStatusResponse> ListResourceExecutionStatusAsync(ListResourceExecutionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceExecutionStatusWithOptionsAsync(request, runtime);
        }

        public ListSecretParametersResponse ListSecretParametersWithOptions(ListSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretParametersResponse>(DoRPCRequest("ListSecretParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSecretParametersResponse> ListSecretParametersWithOptionsAsync(ListSecretParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretParametersResponse>(await DoRPCRequestAsync("ListSecretParameters", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSecretParametersResponse ListSecretParameters(ListSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretParametersWithOptions(request, runtime);
        }

        public async Task<ListSecretParametersResponse> ListSecretParametersAsync(ListSecretParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretParametersWithOptionsAsync(request, runtime);
        }

        public ListSecretParameterVersionsResponse ListSecretParameterVersionsWithOptions(ListSecretParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretParameterVersionsResponse>(DoRPCRequest("ListSecretParameterVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSecretParameterVersionsResponse> ListSecretParameterVersionsWithOptionsAsync(ListSecretParameterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecretParameterVersionsResponse>(await DoRPCRequestAsync("ListSecretParameterVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSecretParameterVersionsResponse ListSecretParameterVersions(ListSecretParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecretParameterVersionsWithOptions(request, runtime);
        }

        public async Task<ListSecretParameterVersionsResponse> ListSecretParameterVersionsAsync(ListSecretParameterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecretParameterVersionsWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(DoRPCRequest("ListTagValues", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await DoRPCRequestAsync("ListTagValues", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        public ListTaskExecutionsResponse ListTaskExecutionsWithOptions(ListTaskExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskExecutionsResponse>(DoRPCRequest("ListTaskExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTaskExecutionsResponse> ListTaskExecutionsWithOptionsAsync(ListTaskExecutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskExecutionsResponse>(await DoRPCRequestAsync("ListTaskExecutions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskExecutionsWithOptions(request, runtime);
        }

        public async Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskExecutionsWithOptionsAsync(request, runtime);
        }

        public ListTemplatesResponse ListTemplatesWithOptions(ListTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(DoRPCRequest("ListTemplates", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTemplatesResponse> ListTemplatesWithOptionsAsync(ListTemplatesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTemplatesShrinkRequest request = new ListTemplatesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesResponse>(await DoRPCRequestAsync("ListTemplates", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesWithOptions(request, runtime);
        }

        public async Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesWithOptionsAsync(request, runtime);
        }

        public ListTemplateVersionsResponse ListTemplateVersionsWithOptions(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(DoRPCRequest("ListTemplateVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsWithOptionsAsync(ListTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplateVersionsResponse>(await DoRPCRequestAsync("ListTemplateVersions", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplateVersionsWithOptions(request, runtime);
        }

        public async Task<ListTemplateVersionsResponse> ListTemplateVersionsAsync(ListTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplateVersionsWithOptionsAsync(request, runtime);
        }

        public NotifyExecutionResponse NotifyExecutionWithOptions(NotifyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyExecutionResponse>(DoRPCRequest("NotifyExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<NotifyExecutionResponse> NotifyExecutionWithOptionsAsync(NotifyExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<NotifyExecutionResponse>(await DoRPCRequestAsync("NotifyExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public NotifyExecutionResponse NotifyExecution(NotifyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyExecutionWithOptions(request, runtime);
        }

        public async Task<NotifyExecutionResponse> NotifyExecutionAsync(NotifyExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyExecutionWithOptionsAsync(request, runtime);
        }

        public SearchInventoryResponse SearchInventoryWithOptions(SearchInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchInventoryResponse>(DoRPCRequest("SearchInventory", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchInventoryResponse> SearchInventoryWithOptionsAsync(SearchInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchInventoryResponse>(await DoRPCRequestAsync("SearchInventory", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchInventoryResponse SearchInventory(SearchInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchInventoryWithOptions(request, runtime);
        }

        public async Task<SearchInventoryResponse> SearchInventoryAsync(SearchInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchInventoryWithOptionsAsync(request, runtime);
        }

        public SetServiceSettingsResponse SetServiceSettingsWithOptions(SetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServiceSettingsResponse>(DoRPCRequest("SetServiceSettings", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetServiceSettingsResponse> SetServiceSettingsWithOptionsAsync(SetServiceSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServiceSettingsResponse>(await DoRPCRequestAsync("SetServiceSettings", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetServiceSettingsResponse SetServiceSettings(SetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServiceSettingsWithOptions(request, runtime);
        }

        public async Task<SetServiceSettingsResponse> SetServiceSettingsAsync(SetServiceSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServiceSettingsWithOptionsAsync(request, runtime);
        }

        public StartExecutionResponse StartExecutionWithOptions(StartExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartExecutionShrinkRequest request = new StartExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartExecutionResponse>(DoRPCRequest("StartExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartExecutionResponse> StartExecutionWithOptionsAsync(StartExecutionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StartExecutionShrinkRequest request = new StartExecutionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartExecutionResponse>(await DoRPCRequestAsync("StartExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartExecutionResponse StartExecution(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartExecutionWithOptions(request, runtime);
        }

        public async Task<StartExecutionResponse> StartExecutionAsync(StartExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartExecutionWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            TagResourcesShrinkRequest request = new TagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public TriggerExecutionResponse TriggerExecutionWithOptions(TriggerExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerExecutionResponse>(DoRPCRequest("TriggerExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TriggerExecutionResponse> TriggerExecutionWithOptionsAsync(TriggerExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TriggerExecutionResponse>(await DoRPCRequestAsync("TriggerExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TriggerExecutionResponse TriggerExecution(TriggerExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerExecutionWithOptions(request, runtime);
        }

        public async Task<TriggerExecutionResponse> TriggerExecutionAsync(TriggerExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerExecutionWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "ResourceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "TagKeys", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateExecutionResponse UpdateExecutionWithOptions(UpdateExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExecutionResponse>(DoRPCRequest("UpdateExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateExecutionResponse> UpdateExecutionWithOptionsAsync(UpdateExecutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExecutionResponse>(await DoRPCRequestAsync("UpdateExecution", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateExecutionResponse UpdateExecution(UpdateExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExecutionWithOptions(request, runtime);
        }

        public async Task<UpdateExecutionResponse> UpdateExecutionAsync(UpdateExecutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExecutionWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceInformationResponse UpdateInstanceInformationWithOptions(UpdateInstanceInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceInformationResponse>(DoRPCRequest("UpdateInstanceInformation", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateInstanceInformationResponse> UpdateInstanceInformationWithOptionsAsync(UpdateInstanceInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceInformationResponse>(await DoRPCRequestAsync("UpdateInstanceInformation", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateInstanceInformationResponse UpdateInstanceInformation(UpdateInstanceInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceInformationWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceInformationResponse> UpdateInstanceInformationAsync(UpdateInstanceInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceInformationWithOptionsAsync(request, runtime);
        }

        public UpdateParameterResponse UpdateParameterWithOptions(UpdateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateParameterResponse>(DoRPCRequest("UpdateParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateParameterResponse> UpdateParameterWithOptionsAsync(UpdateParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateParameterResponse>(await DoRPCRequestAsync("UpdateParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateParameterResponse UpdateParameter(UpdateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateParameterWithOptions(request, runtime);
        }

        public async Task<UpdateParameterResponse> UpdateParameterAsync(UpdateParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateParameterWithOptionsAsync(request, runtime);
        }

        public UpdateSecretParameterResponse UpdateSecretParameterWithOptions(UpdateSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretParameterResponse>(DoRPCRequest("UpdateSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSecretParameterResponse> UpdateSecretParameterWithOptionsAsync(UpdateSecretParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSecretParameterResponse>(await DoRPCRequestAsync("UpdateSecretParameter", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSecretParameterResponse UpdateSecretParameter(UpdateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecretParameterWithOptions(request, runtime);
        }

        public async Task<UpdateSecretParameterResponse> UpdateSecretParameterAsync(UpdateSecretParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecretParameterWithOptionsAsync(request, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(UpdateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateShrinkRequest request = new UpdateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoRPCRequest("UpdateTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(UpdateTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateTemplateShrinkRequest request = new UpdateTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoRPCRequestAsync("UpdateTemplate", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTemplateWithOptions(request, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTemplateWithOptionsAsync(request, runtime);
        }

        public ValidateTemplateContentResponse ValidateTemplateContentWithOptions(ValidateTemplateContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateTemplateContentResponse>(DoRPCRequest("ValidateTemplateContent", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ValidateTemplateContentResponse> ValidateTemplateContentWithOptionsAsync(ValidateTemplateContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateTemplateContentResponse>(await DoRPCRequestAsync("ValidateTemplateContent", "2019-06-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ValidateTemplateContentResponse ValidateTemplateContent(ValidateTemplateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateTemplateContentWithOptions(request, runtime);
        }

        public async Task<ValidateTemplateContentResponse> ValidateTemplateContentAsync(ValidateTemplateContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateTemplateContentWithOptionsAsync(request, runtime);
        }

    }
}
