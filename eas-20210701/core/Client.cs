// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eas20210701.Models;

namespace AlibabaCloud.SDK.Eas20210701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "pai-eas.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "pai-eas.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "pai-eas.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "pai-eas.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "pai-eas.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "pai-eas.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "pai-eas.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "pai-eas.ap-southeast-5.aliyuncs.com"},
                {"us-east-1", "pai-eas.us-east-1.aliyuncs.com"},
                {"us-west-1", "pai-eas.us-west-1.aliyuncs.com"},
                {"eu-central-1", "pai-eas.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "pai-eas.ap-south-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "pai-eas.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-north-2-gov-1", "pai-eas.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-chengdu", "pai-eas.cn-chengdu.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("eas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateBenchmarkTaskResponse CreateBenchmarkTask(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBenchmarkTaskWithOptions(request, headers, runtime);
        }

        public async Task<CreateBenchmarkTaskResponse> CreateBenchmarkTaskAsync(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBenchmarkTaskWithOptionsAsync(request, headers, runtime);
        }

        public CreateBenchmarkTaskResponse CreateBenchmarkTaskWithOptions(CreateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBenchmarkTaskResponse> CreateBenchmarkTaskWithOptionsAsync(CreateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceWithOptions(request, headers, runtime);
        }

        public async Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceWithOptionsAsync(request, headers, runtime);
        }

        public CreateResourceResponse CreateResourceWithOptions(CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceResponse> CreateResourceWithOptionsAsync(CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceInstancesResponse CreateResourceInstances(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<CreateResourceInstancesResponse> CreateResourceInstancesAsync(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public CreateResourceInstancesResponse CreateResourceInstancesWithOptions(string ClusterId, string ResourceId, CreateResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceInstancesResponse> CreateResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, CreateResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceLogResponse CreateResourceLog(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceLogWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<CreateResourceLogResponse> CreateResourceLogAsync(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceLogWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public CreateResourceLogResponse CreateResourceLogWithOptions(string ClusterId, string ResourceId, CreateResourceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                body["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceLogResponse> CreateResourceLogWithOptionsAsync(string ClusterId, string ResourceId, CreateResourceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                body["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceAutoScalerResponse CreateServiceAutoScaler(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<CreateServiceAutoScalerResponse> CreateServiceAutoScalerAsync(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public CreateServiceAutoScalerResponse CreateServiceAutoScalerWithOptions(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategies.ToMap()))
            {
                body["strategies"] = request.Strategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceAutoScalerResponse> CreateServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategies.ToMap()))
            {
                body["strategies"] = request.Strategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceCronScalerResponse CreateServiceCronScaler(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<CreateServiceCronScalerResponse> CreateServiceCronScalerAsync(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public CreateServiceCronScalerResponse CreateServiceCronScalerWithOptions(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceCronScalerResponse> CreateServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceMirrorResponse CreateServiceMirror(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<CreateServiceMirrorResponse> CreateServiceMirrorAsync(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public CreateServiceMirrorResponse CreateServiceMirrorWithOptions(string ClusterId, string ServiceName, CreateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceMirrorResponse> CreateServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBenchmarkTaskResponse DeleteBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        public async Task<DeleteBenchmarkTaskResponse> DeleteBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        public DeleteBenchmarkTaskResponse DeleteBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBenchmarkTaskResponse> DeleteBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceResponse DeleteResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DeleteResourceResponse> DeleteResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DeleteResourceResponse DeleteResourceWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceResponse> DeleteResourceWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceDLinkResponse DeleteResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DeleteResourceDLinkResponse> DeleteResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DeleteResourceDLinkResponse DeleteResourceDLinkWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceDLinkResponse> DeleteResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceInstancesResponse DeleteResourceInstances(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<DeleteResourceInstancesResponse> DeleteResourceInstancesAsync(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public DeleteResourceInstancesResponse DeleteResourceInstancesWithOptions(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllFailed))
            {
                query["AllFailed"] = request.AllFailed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceInstancesResponse> DeleteResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllFailed))
            {
                query["AllFailed"] = request.AllFailed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceLogResponse DeleteResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DeleteResourceLogResponse> DeleteResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DeleteResourceLogResponse DeleteResourceLogWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceLogResponse> DeleteResourceLogWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceResponse DeleteService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceAutoScalerResponse DeleteServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DeleteServiceAutoScalerResponse> DeleteServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DeleteServiceAutoScalerResponse DeleteServiceAutoScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceAutoScalerResponse> DeleteServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceCronScalerResponse DeleteServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DeleteServiceCronScalerResponse> DeleteServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DeleteServiceCronScalerResponse DeleteServiceCronScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceCronScalerResponse> DeleteServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceInstancesResponse DeleteServiceInstances(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public DeleteServiceInstancesResponse DeleteServiceInstancesWithOptions(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesWithOptionsAsync(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceMirrorResponse DeleteServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DeleteServiceMirrorResponse> DeleteServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DeleteServiceMirrorResponse DeleteServiceMirrorWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceMirrorResponse> DeleteServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBenchmarkTaskResponse DescribeBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        public async Task<DescribeBenchmarkTaskResponse> DescribeBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        public DescribeBenchmarkTaskResponse DescribeBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBenchmarkTaskResponse> DescribeBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBenchmarkTaskReportResponse DescribeBenchmarkTaskReport(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskReportWithOptions(ClusterId, TaskName, headers, runtime);
        }

        public async Task<DescribeBenchmarkTaskReportResponse> DescribeBenchmarkTaskReportAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskReportWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        public DescribeBenchmarkTaskReportResponse DescribeBenchmarkTaskReportWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTaskReport",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBenchmarkTaskReportResponse> DescribeBenchmarkTaskReportWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTaskReport",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeResourceResponse DescribeResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DescribeResourceResponse> DescribeResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DescribeResourceResponse DescribeResourceWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeResourceResponse> DescribeResourceWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeResourceDLinkResponse DescribeResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DescribeResourceDLinkResponse> DescribeResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DescribeResourceDLinkResponse DescribeResourceDLinkWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeResourceDLinkResponse> DescribeResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeResourceLogResponse DescribeResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        public async Task<DescribeResourceLogResponse> DescribeResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        public DescribeResourceLogResponse DescribeResourceLogWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeResourceLogResponse> DescribeResourceLogWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceResponse DescribeService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DescribeServiceResponse> DescribeServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DescribeServiceResponse DescribeServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceResponse> DescribeServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceAutoScalerResponse DescribeServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DescribeServiceAutoScalerResponse> DescribeServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DescribeServiceAutoScalerResponse DescribeServiceAutoScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceAutoScalerResponse> DescribeServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceCronScalerResponse DescribeServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DescribeServiceCronScalerResponse> DescribeServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DescribeServiceCronScalerResponse DescribeServiceCronScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceCronScalerResponse> DescribeServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceLogResponse DescribeServiceLog(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceLogWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<DescribeServiceLogResponse> DescribeServiceLogAsync(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceLogWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public DescribeServiceLogResponse DescribeServiceLogWithOptions(string ClusterId, string ServiceName, DescribeServiceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceLogResponse> DescribeServiceLogWithOptionsAsync(string ClusterId, string ServiceName, DescribeServiceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeServiceMirrorResponse DescribeServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<DescribeServiceMirrorResponse> DescribeServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public DescribeServiceMirrorResponse DescribeServiceMirrorWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeServiceMirrorResponse> DescribeServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBenchmarkTaskResponse ListBenchmarkTask()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBenchmarkTaskWithOptions(headers, runtime);
        }

        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBenchmarkTaskWithOptionsAsync(headers, runtime);
        }

        public ListBenchmarkTaskResponse ListBenchmarkTaskWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceInstanceWorkerResponse ListResourceInstanceWorker(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstanceWorkerWithOptions(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstanceWorkerWithOptionsAsync(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        public ListResourceInstanceWorkerResponse ListResourceInstanceWorkerWithOptions(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            InstanceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstanceWorker",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instance/" + InstanceName + "/workers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstanceWorkerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerWithOptionsAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            InstanceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstanceWorker",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instance/" + InstanceName + "/workers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstanceWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceInstancesResponse ListResourceInstances(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public ListResourceInstancesResponse ListResourceInstancesWithOptions(string ClusterId, string ResourceId, ListResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceInstancesResponse> ListResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceServicesResponse ListResourceServices(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceServicesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<ListResourceServicesResponse> ListResourceServicesAsync(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceServicesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public ListResourceServicesResponse ListResourceServicesWithOptions(string ClusterId, string ResourceId, ListResourceServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceServicesResponse> ListResourceServicesWithOptionsAsync(string ClusterId, string ResourceId, ListResourceServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(request, headers, runtime);
        }

        public ListResourcesResponse ListResourcesWithOptions(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceInstancesResponse ListServiceInstances(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public ListServiceInstancesResponse ListServiceInstancesWithOptions(string ClusterId, string ServiceName, ListServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(string ClusterId, string ServiceName, ListServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseServiceResponse ReleaseService(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<ReleaseServiceResponse> ReleaseServiceAsync(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public ReleaseServiceResponse ReleaseServiceWithOptions(string ClusterId, string ServiceName, ReleaseServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/release",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseServiceResponse> ReleaseServiceWithOptionsAsync(string ClusterId, string ServiceName, ReleaseServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/release",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartBenchmarkTaskResponse StartBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        public async Task<StartBenchmarkTaskResponse> StartBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        public StartBenchmarkTaskResponse StartBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartBenchmarkTaskResponse> StartBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartServiceResponse StartService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<StartServiceResponse> StartServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public StartServiceResponse StartServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartServiceResponse> StartServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopBenchmarkTaskResponse StopBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        public async Task<StopBenchmarkTaskResponse> StopBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        public StopBenchmarkTaskResponse StopBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopBenchmarkTaskResponse> StopBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopServiceResponse StopService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        public async Task<StopServiceResponse> StopServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        public StopServiceResponse StopServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopServiceResponse> StopServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBenchmarkTaskResponse UpdateBenchmarkTask(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBenchmarkTaskWithOptions(ClusterId, TaskName, request, headers, runtime);
        }

        public async Task<UpdateBenchmarkTaskResponse> UpdateBenchmarkTaskAsync(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, request, headers, runtime);
        }

        public UpdateBenchmarkTaskResponse UpdateBenchmarkTaskWithOptions(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBenchmarkTaskResponse> UpdateBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            TaskName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + ClusterId + "/" + TaskName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResourceResponse UpdateResource(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<UpdateResourceResponse> UpdateResourceAsync(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public UpdateResourceResponse UpdateResourceWithOptions(string ClusterId, string ResourceId, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResourceResponse> UpdateResourceWithOptionsAsync(string ClusterId, string ResourceId, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResourceDLinkResponse UpdateResourceDLink(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceDLinkWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        public async Task<UpdateResourceDLinkResponse> UpdateResourceDLinkAsync(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceDLinkWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        public UpdateResourceDLinkResponse UpdateResourceDLinkWithOptions(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCIDRs))
            {
                body["DestinationCIDRs"] = request.DestinationCIDRs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                body["VSwitchIdList"] = request.VSwitchIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResourceDLinkResponse> UpdateResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ResourceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCIDRs))
            {
                body["DestinationCIDRs"] = request.DestinationCIDRs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                body["VSwitchIdList"] = request.VSwitchIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + ClusterId + "/" + ResourceId + "/dlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceResponse UpdateService(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<UpdateServiceResponse> UpdateServiceAsync(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public UpdateServiceResponse UpdateServiceWithOptions(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceAutoScalerResponse UpdateServiceAutoScaler(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<UpdateServiceAutoScalerResponse> UpdateServiceAutoScalerAsync(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public UpdateServiceAutoScalerResponse UpdateServiceAutoScalerWithOptions(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategies.ToMap()))
            {
                body["strategies"] = request.Strategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceAutoScalerResponse> UpdateServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategies.ToMap()))
            {
                body["strategies"] = request.Strategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/autoscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceCronScalerResponse UpdateServiceCronScaler(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<UpdateServiceCronScalerResponse> UpdateServiceCronScalerAsync(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public UpdateServiceCronScalerResponse UpdateServiceCronScalerWithOptions(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceCronScalerResponse> UpdateServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/cronscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceMirrorResponse UpdateServiceMirror(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<UpdateServiceMirrorResponse> UpdateServiceMirrorAsync(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public UpdateServiceMirrorResponse UpdateServiceMirrorWithOptions(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceMirrorResponse> UpdateServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/mirror",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceVersionResponse UpdateServiceVersion(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceVersionWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionAsync(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceVersionWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        public UpdateServiceVersionResponse UpdateServiceVersionWithOptions(string ClusterId, string ServiceName, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ServiceName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + ClusterId + "/" + ServiceName + "/version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
