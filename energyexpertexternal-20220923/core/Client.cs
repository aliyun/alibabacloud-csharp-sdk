// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EnergyExpertExternal20220923.Models;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("energyexpertexternal", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 策略执行状态反馈
         *
         * @param request BatchSaveInstructionStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSaveInstructionStatusResponse
         */
        public BatchSaveInstructionStatusResponse BatchSaveInstructionStatusWithOptions(BatchSaveInstructionStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PKey))
            {
                body["pKey"] = request.PKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSaveInstructionStatus",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/batchSaveInstructionStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveInstructionStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 策略执行状态反馈
         *
         * @param request BatchSaveInstructionStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSaveInstructionStatusResponse
         */
        public async Task<BatchSaveInstructionStatusResponse> BatchSaveInstructionStatusWithOptionsAsync(BatchSaveInstructionStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PKey))
            {
                body["pKey"] = request.PKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSaveInstructionStatus",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/batchSaveInstructionStatus",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveInstructionStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 策略执行状态反馈
         *
         * @param request BatchSaveInstructionStatusRequest
         * @return BatchSaveInstructionStatusResponse
         */
        public BatchSaveInstructionStatusResponse BatchSaveInstructionStatus(BatchSaveInstructionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchSaveInstructionStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 策略执行状态反馈
         *
         * @param request BatchSaveInstructionStatusRequest
         * @return BatchSaveInstructionStatusResponse
         */
        public async Task<BatchSaveInstructionStatusResponse> BatchSaveInstructionStatusAsync(BatchSaveInstructionStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchSaveInstructionStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 批量设置空调站点运行计划
         *
         * @param request BatchUpdateSystemRunningPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateSystemRunningPlanResponse
         */
        public BatchUpdateSystemRunningPlanResponse BatchUpdateSystemRunningPlanWithOptions(BatchUpdateSystemRunningPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["controlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["dateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarliestStartupTime))
            {
                body["earliestStartupTime"] = request.EarliestStartupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestShutdownTime))
            {
                body["latestShutdownTime"] = request.LatestShutdownTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCarbonDioxide))
            {
                body["maxCarbonDioxide"] = request.MaxCarbonDioxide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTem))
            {
                body["maxTem"] = request.MaxTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTem))
            {
                body["minTem"] = request.MinTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeasonMode))
            {
                body["seasonMode"] = request.SeasonMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingEndTime))
            {
                body["workingEndTime"] = request.WorkingEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingStartTime))
            {
                body["workingStartTime"] = request.WorkingStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateSystemRunningPlan",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/batchUpdateSystemRunningPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateSystemRunningPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量设置空调站点运行计划
         *
         * @param request BatchUpdateSystemRunningPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchUpdateSystemRunningPlanResponse
         */
        public async Task<BatchUpdateSystemRunningPlanResponse> BatchUpdateSystemRunningPlanWithOptionsAsync(BatchUpdateSystemRunningPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["controlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["dateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarliestStartupTime))
            {
                body["earliestStartupTime"] = request.EarliestStartupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestShutdownTime))
            {
                body["latestShutdownTime"] = request.LatestShutdownTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCarbonDioxide))
            {
                body["maxCarbonDioxide"] = request.MaxCarbonDioxide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTem))
            {
                body["maxTem"] = request.MaxTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTem))
            {
                body["minTem"] = request.MinTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeasonMode))
            {
                body["seasonMode"] = request.SeasonMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingEndTime))
            {
                body["workingEndTime"] = request.WorkingEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingStartTime))
            {
                body["workingStartTime"] = request.WorkingStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchUpdateSystemRunningPlan",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/batchUpdateSystemRunningPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchUpdateSystemRunningPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量设置空调站点运行计划
         *
         * @param request BatchUpdateSystemRunningPlanRequest
         * @return BatchUpdateSystemRunningPlanResponse
         */
        public BatchUpdateSystemRunningPlanResponse BatchUpdateSystemRunningPlan(BatchUpdateSystemRunningPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchUpdateSystemRunningPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量设置空调站点运行计划
         *
         * @param request BatchUpdateSystemRunningPlanRequest
         * @return BatchUpdateSystemRunningPlanResponse
         */
        public async Task<BatchUpdateSystemRunningPlanResponse> BatchUpdateSystemRunningPlanAsync(BatchUpdateSystemRunningPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchUpdateSystemRunningPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 编辑禁用设备
         *
         * @param request EditProhibitedDevicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditProhibitedDevicesResponse
         */
        public EditProhibitedDevicesResponse EditProhibitedDevicesWithOptions(EditProhibitedDevicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HvacDeviceConfigVOList))
            {
                body["hvacDeviceConfigVOList"] = request.HvacDeviceConfigVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditProhibitedDevices",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/editProhibitedDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditProhibitedDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑禁用设备
         *
         * @param request EditProhibitedDevicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditProhibitedDevicesResponse
         */
        public async Task<EditProhibitedDevicesResponse> EditProhibitedDevicesWithOptionsAsync(EditProhibitedDevicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HvacDeviceConfigVOList))
            {
                body["hvacDeviceConfigVOList"] = request.HvacDeviceConfigVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditProhibitedDevices",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/editProhibitedDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditProhibitedDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑禁用设备
         *
         * @param request EditProhibitedDevicesRequest
         * @return EditProhibitedDevicesResponse
         */
        public EditProhibitedDevicesResponse EditProhibitedDevices(EditProhibitedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EditProhibitedDevicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 编辑禁用设备
         *
         * @param request EditProhibitedDevicesRequest
         * @return EditProhibitedDevicesResponse
         */
        public async Task<EditProhibitedDevicesResponse> EditProhibitedDevicesAsync(EditProhibitedDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EditProhibitedDevicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 编辑不利区设备
         *
         * @param request EditUnfavorableAreaDevicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditUnfavorableAreaDevicesResponse
         */
        public EditUnfavorableAreaDevicesResponse EditUnfavorableAreaDevicesWithOptions(EditUnfavorableAreaDevicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HvacDeviceConfigVOList))
            {
                body["hvacDeviceConfigVOList"] = request.HvacDeviceConfigVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditUnfavorableAreaDevices",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/editUnfavorableAreaDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditUnfavorableAreaDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑不利区设备
         *
         * @param request EditUnfavorableAreaDevicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditUnfavorableAreaDevicesResponse
         */
        public async Task<EditUnfavorableAreaDevicesResponse> EditUnfavorableAreaDevicesWithOptionsAsync(EditUnfavorableAreaDevicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HvacDeviceConfigVOList))
            {
                body["hvacDeviceConfigVOList"] = request.HvacDeviceConfigVOList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditUnfavorableAreaDevices",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/editUnfavorableAreaDevices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditUnfavorableAreaDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑不利区设备
         *
         * @param request EditUnfavorableAreaDevicesRequest
         * @return EditUnfavorableAreaDevicesResponse
         */
        public EditUnfavorableAreaDevicesResponse EditUnfavorableAreaDevices(EditUnfavorableAreaDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EditUnfavorableAreaDevicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 编辑不利区设备
         *
         * @param request EditUnfavorableAreaDevicesRequest
         * @return EditUnfavorableAreaDevicesResponse
         */
        public async Task<EditUnfavorableAreaDevicesResponse> EditUnfavorableAreaDevicesAsync(EditUnfavorableAreaDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EditUnfavorableAreaDevicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Generate a report of the specified carbon footprint.
         *
         * @description Given a product ID, this API initiates a task to calculate the carbon footprint result for the corresponding product. The task\\"s status can be checked using the `IsCompleted` API. Following the generation of results, other result inquiry APIs can be accessed for display content.
         *
         * @param request GenerateResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResultResponse
         */
        public GenerateResultResponse GenerateResultWithOptions(GenerateResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Generate a report of the specified carbon footprint.
         *
         * @description Given a product ID, this API initiates a task to calculate the carbon footprint result for the corresponding product. The task\\"s status can be checked using the `IsCompleted` API. Following the generation of results, other result inquiry APIs can be accessed for display content.
         *
         * @param request GenerateResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateResultResponse
         */
        public async Task<GenerateResultResponse> GenerateResultWithOptionsAsync(GenerateResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/generate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Generate a report of the specified carbon footprint.
         *
         * @description Given a product ID, this API initiates a task to calculate the carbon footprint result for the corresponding product. The task\\"s status can be checked using the `IsCompleted` API. Following the generation of results, other result inquiry APIs can be accessed for display content.
         *
         * @param request GenerateResultRequest
         * @return GenerateResultResponse
         */
        public GenerateResultResponse GenerateResult(GenerateResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary Generate a report of the specified carbon footprint.
         *
         * @description Given a product ID, this API initiates a task to calculate the carbon footprint result for the corresponding product. The task\\"s status can be checked using the `IsCompleted` API. Following the generation of results, other result inquiry APIs can be accessed for display content.
         *
         * @param request GenerateResultRequest
         * @return GenerateResultResponse
         */
        public async Task<GenerateResultResponse> GenerateResultAsync(GenerateResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain electrical constitute analysis data.
         *
         * @param request GetAreaElecConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAreaElecConstituteResponse
         */
        public GetAreaElecConstituteResponse GetAreaElecConstituteWithOptions(GetAreaElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAreaElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/area",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAreaElecConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain electrical constitute analysis data.
         *
         * @param request GetAreaElecConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAreaElecConstituteResponse
         */
        public async Task<GetAreaElecConstituteResponse> GetAreaElecConstituteWithOptionsAsync(GetAreaElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAreaElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/area",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAreaElecConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain electrical constitute analysis data.
         *
         * @param request GetAreaElecConstituteRequest
         * @return GetAreaElecConstituteResponse
         */
        public GetAreaElecConstituteResponse GetAreaElecConstitute(GetAreaElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAreaElecConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain electrical constitute analysis data.
         *
         * @param request GetAreaElecConstituteRequest
         * @return GetAreaElecConstituteResponse
         */
        public async Task<GetAreaElecConstituteResponse> GetAreaElecConstituteAsync(GetAreaElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAreaElecConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get trends in carbon emissions.
         *
         * @param request GetCarbonEmissionTrendRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCarbonEmissionTrendResponse
         */
        public GetCarbonEmissionTrendResponse GetCarbonEmissionTrendWithOptions(GetCarbonEmissionTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrendType))
            {
                body["trendType"] = request.TrendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCarbonEmissionTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCarbonEmissionTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get trends in carbon emissions.
         *
         * @param request GetCarbonEmissionTrendRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCarbonEmissionTrendResponse
         */
        public async Task<GetCarbonEmissionTrendResponse> GetCarbonEmissionTrendWithOptionsAsync(GetCarbonEmissionTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrendType))
            {
                body["trendType"] = request.TrendType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCarbonEmissionTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCarbonEmissionTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get trends in carbon emissions.
         *
         * @param request GetCarbonEmissionTrendRequest
         * @return GetCarbonEmissionTrendResponse
         */
        public GetCarbonEmissionTrendResponse GetCarbonEmissionTrend(GetCarbonEmissionTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCarbonEmissionTrendWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get trends in carbon emissions.
         *
         * @param request GetCarbonEmissionTrendRequest
         * @return GetCarbonEmissionTrendResponse
         */
        public async Task<GetCarbonEmissionTrendResponse> GetCarbonEmissionTrendAsync(GetCarbonEmissionTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCarbonEmissionTrendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain the details category of a data item.
         *
         * @description - obtain data item detail list under the current enterprise.
         *
         * @param request GetDataItemListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataItemListResponse
         */
        public GetDataItemListResponse GetDataItemListWithOptions(GetDataItemListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataItemList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataItemListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain the details category of a data item.
         *
         * @description - obtain data item detail list under the current enterprise.
         *
         * @param request GetDataItemListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataItemListResponse
         */
        public async Task<GetDataItemListResponse> GetDataItemListWithOptionsAsync(GetDataItemListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataItemList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataItemListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain the details category of a data item.
         *
         * @description - obtain data item detail list under the current enterprise.
         *
         * @param request GetDataItemListRequest
         * @return GetDataItemListResponse
         */
        public GetDataItemListResponse GetDataItemList(GetDataItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataItemListWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain the details category of a data item.
         *
         * @description - obtain data item detail list under the current enterprise.
         *
         * @param request GetDataItemListRequest
         * @return GetDataItemListResponse
         */
        public async Task<GetDataItemListResponse> GetDataItemListAsync(GetDataItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataItemListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Obtain the data quality evaluation results DQR and DQI.
         *
         * @description This API returns the data quality evaluation results based on the user-provided product ID. It\\"s useful for understanding the data quality of the carbon emission factors for each inventory of the product.
         *
         * @param request GetDataQualityAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataQualityAnalysisResponse
         */
        public GetDataQualityAnalysisResponse GetDataQualityAnalysisWithOptions(GetDataQualityAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataQualityAnalysis",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/data/quality/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataQualityAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtain the data quality evaluation results DQR and DQI.
         *
         * @description This API returns the data quality evaluation results based on the user-provided product ID. It\\"s useful for understanding the data quality of the carbon emission factors for each inventory of the product.
         *
         * @param request GetDataQualityAnalysisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataQualityAnalysisResponse
         */
        public async Task<GetDataQualityAnalysisResponse> GetDataQualityAnalysisWithOptionsAsync(GetDataQualityAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataQualityAnalysis",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/data/quality/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataQualityAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtain the data quality evaluation results DQR and DQI.
         *
         * @description This API returns the data quality evaluation results based on the user-provided product ID. It\\"s useful for understanding the data quality of the carbon emission factors for each inventory of the product.
         *
         * @param request GetDataQualityAnalysisRequest
         * @return GetDataQualityAnalysisResponse
         */
        public GetDataQualityAnalysisResponse GetDataQualityAnalysis(GetDataQualityAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDataQualityAnalysisWithOptions(request, headers, runtime);
        }

        /**
         * @summary Obtain the data quality evaluation results DQR and DQI.
         *
         * @description This API returns the data quality evaluation results based on the user-provided product ID. It\\"s useful for understanding the data quality of the carbon emission factors for each inventory of the product.
         *
         * @param request GetDataQualityAnalysisRequest
         * @return GetDataQualityAnalysisResponse
         */
        public async Task<GetDataQualityAnalysisResponse> GetDataQualityAnalysisAsync(GetDataQualityAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDataQualityAnalysisWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a device at a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
         * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceInfoResponse
         */
        public GetDeviceInfoResponse GetDeviceInfoWithOptions(GetDeviceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ds))
            {
                query["ds"] = request.Ds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a device at a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
         * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceInfoResponse
         */
        public async Task<GetDeviceInfoResponse> GetDeviceInfoWithOptionsAsync(GetDeviceInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["deviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ds))
            {
                query["ds"] = request.Ds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a device at a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
         * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceInfoRequest
         * @return GetDeviceInfoResponse
         */
        public GetDeviceInfoResponse GetDeviceInfo(GetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeviceInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about a device at a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can call this operation to query the parameters of a data collection device based on the device ID. If the verification is passed, the device parameters are returned. If the verification fails, a null value is returned.
         * *   You can query the parameters of a single device by day. If data of the device does not exist, a null value is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceInfoRequest
         * @return GetDeviceInfoResponse
         */
        public async Task<GetDeviceInfoResponse> GetDeviceInfoAsync(GetDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeviceInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the devices of a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
         * *   Virtual meters at the site are not returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceListResponse
         */
        public GetDeviceListResponse GetDeviceListWithOptions(GetDeviceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the devices of a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
         * *   Virtual meters at the site are not returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceListResponse
         */
        public async Task<GetDeviceListResponse> GetDeviceListWithOptionsAsync(GetDeviceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                query["factoryId"] = request.FactoryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getDeviceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the devices of a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
         * *   Virtual meters at the site are not returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceListRequest
         * @return GetDeviceListResponse
         */
        public GetDeviceListResponse GetDeviceList(GetDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeviceListWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the devices of a site that is activated by using an Alibaba Cloud account.
         *
         * @description *   You can query the information about data collection devices of a site based on the ID of the site. If the verification is passed, the information about the devices of the site is returned. If the verification fails, a null value is returned.
         * *   Virtual meters at the site are not returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param request GetDeviceListRequest
         * @return GetDeviceListResponse
         */
        public async Task<GetDeviceListResponse> GetDeviceListAsync(GetDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeviceListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文档结果
         *
         * @param request GetDocumentAnalyzeResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentAnalyzeResultResponse
         */
        public GetDocumentAnalyzeResultResponse GetDocumentAnalyzeResultWithOptions(GetDocumentAnalyzeResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentAnalyzeResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/getDocumentAnalyzeResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentAnalyzeResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档结果
         *
         * @param request GetDocumentAnalyzeResultRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDocumentAnalyzeResultResponse
         */
        public async Task<GetDocumentAnalyzeResultResponse> GetDocumentAnalyzeResultWithOptionsAsync(GetDocumentAnalyzeResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["jobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocumentAnalyzeResult",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/getDocumentAnalyzeResult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentAnalyzeResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档结果
         *
         * @param request GetDocumentAnalyzeResultRequest
         * @return GetDocumentAnalyzeResultResponse
         */
        public GetDocumentAnalyzeResultResponse GetDocumentAnalyzeResult(GetDocumentAnalyzeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDocumentAnalyzeResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文档结果
         *
         * @param request GetDocumentAnalyzeResultRequest
         * @return GetDocumentAnalyzeResultResponse
         */
        public async Task<GetDocumentAnalyzeResultResponse> GetDocumentAnalyzeResultAsync(GetDocumentAnalyzeResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDocumentAnalyzeResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain power composition analysis data.
         *
         * @param request GetElecConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetElecConstituteResponse
         */
        public GetElecConstituteResponse GetElecConstituteWithOptions(GetElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain power composition analysis data.
         *
         * @param request GetElecConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetElecConstituteResponse
         */
        public async Task<GetElecConstituteResponse> GetElecConstituteWithOptionsAsync(GetElecConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain power composition analysis data.
         *
         * @param request GetElecConstituteRequest
         * @return GetElecConstituteResponse
         */
        public GetElecConstituteResponse GetElecConstitute(GetElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetElecConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain power composition analysis data.
         *
         * @param request GetElecConstituteRequest
         * @return GetElecConstituteResponse
         */
        public async Task<GetElecConstituteResponse> GetElecConstituteAsync(GetElecConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetElecConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain power trend analysis data.
         *
         * @param request GetElecTrendRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetElecTrendResponse
         */
        public GetElecTrendResponse GetElecTrendWithOptions(GetElecTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecTrendResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain power trend analysis data.
         *
         * @param request GetElecTrendRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetElecTrendResponse
         */
        public async Task<GetElecTrendResponse> GetElecTrendWithOptionsAsync(GetElecTrendRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YearList))
            {
                body["yearList"] = request.YearList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetElecTrend",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/elec/trend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetElecTrendResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain power trend analysis data.
         *
         * @param request GetElecTrendRequest
         * @return GetElecTrendResponse
         */
        public GetElecTrendResponse GetElecTrend(GetElecTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetElecTrendWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain power trend analysis data.
         *
         * @param request GetElecTrendRequest
         * @return GetElecTrendResponse
         */
        public async Task<GetElecTrendResponse> GetElecTrendAsync(GetElecTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetElecTrendWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Obtain the emission source composition.
         *
         * @param request GetEmissionSourceConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmissionSourceConstituteResponse
         */
        public GetEmissionSourceConstituteResponse GetEmissionSourceConstituteWithOptions(GetEmissionSourceConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSourceConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSourceConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtain the emission source composition.
         *
         * @param request GetEmissionSourceConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmissionSourceConstituteResponse
         */
        public async Task<GetEmissionSourceConstituteResponse> GetEmissionSourceConstituteWithOptionsAsync(GetEmissionSourceConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSourceConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSourceConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtain the emission source composition.
         *
         * @param request GetEmissionSourceConstituteRequest
         * @return GetEmissionSourceConstituteResponse
         */
        public GetEmissionSourceConstituteResponse GetEmissionSourceConstitute(GetEmissionSourceConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmissionSourceConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Obtain the emission source composition.
         *
         * @param request GetEmissionSourceConstituteRequest
         * @return GetEmissionSourceConstituteResponse
         */
        public async Task<GetEmissionSourceConstituteResponse> GetEmissionSourceConstituteAsync(GetEmissionSourceConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmissionSourceConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get a summary of carbon emissions.
         *
         * @param request GetEmissionSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmissionSummaryResponse
         */
        public GetEmissionSummaryResponse GetEmissionSummaryWithOptions(GetEmissionSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get a summary of carbon emissions.
         *
         * @param request GetEmissionSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEmissionSummaryResponse
         */
        public async Task<GetEmissionSummaryResponse> GetEmissionSummaryWithOptionsAsync(GetEmissionSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEmissionSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEmissionSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get a summary of carbon emissions.
         *
         * @param request GetEmissionSummaryRequest
         * @return GetEmissionSummaryResponse
         */
        public GetEmissionSummaryResponse GetEmissionSummary(GetEmissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEmissionSummaryWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get a summary of carbon emissions.
         *
         * @param request GetEmissionSummaryRequest
         * @return GetEmissionSummaryResponse
         */
        public async Task<GetEmissionSummaryResponse> GetEmissionSummaryAsync(GetEmissionSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEmissionSummaryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Gets the result details of the environmental impact category.
         *
         * @description This API returns the emission amounts for various environmental impact categories at different levels for the given product ID. It helps understand the emission quantities for different environmental impact categories and inventories of the product.
         *
         * @param request GetEpdInventoryConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEpdInventoryConstituteResponse
         */
        public GetEpdInventoryConstituteResponse GetEpdInventoryConstituteWithOptions(GetEpdInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdInventoryConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets the result details of the environmental impact category.
         *
         * @description This API returns the emission amounts for various environmental impact categories at different levels for the given product ID. It helps understand the emission quantities for different environmental impact categories and inventories of the product.
         *
         * @param request GetEpdInventoryConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEpdInventoryConstituteResponse
         */
        public async Task<GetEpdInventoryConstituteResponse> GetEpdInventoryConstituteWithOptionsAsync(GetEpdInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdInventoryConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets the result details of the environmental impact category.
         *
         * @description This API returns the emission amounts for various environmental impact categories at different levels for the given product ID. It helps understand the emission quantities for different environmental impact categories and inventories of the product.
         *
         * @param request GetEpdInventoryConstituteRequest
         * @return GetEpdInventoryConstituteResponse
         */
        public GetEpdInventoryConstituteResponse GetEpdInventoryConstitute(GetEpdInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEpdInventoryConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Gets the result details of the environmental impact category.
         *
         * @description This API returns the emission amounts for various environmental impact categories at different levels for the given product ID. It helps understand the emission quantities for different environmental impact categories and inventories of the product.
         *
         * @param request GetEpdInventoryConstituteRequest
         * @return GetEpdInventoryConstituteResponse
         */
        public async Task<GetEpdInventoryConstituteResponse> GetEpdInventoryConstituteAsync(GetEpdInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEpdInventoryConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Obtain the total amount of emissions for various environmental impacts.
         *
         * @description This API takes a product ID from the user and returns the summary of environmental impact generated for the product. This info helps understand the overall emissions for different environmental impact categories of the product.
         *
         * @param request GetEpdSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEpdSummaryResponse
         */
        public GetEpdSummaryResponse GetEpdSummaryWithOptions(GetEpdSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtain the total amount of emissions for various environmental impacts.
         *
         * @description This API takes a product ID from the user and returns the summary of environmental impact generated for the product. This info helps understand the overall emissions for different environmental impact categories of the product.
         *
         * @param request GetEpdSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetEpdSummaryResponse
         */
        public async Task<GetEpdSummaryResponse> GetEpdSummaryWithOptionsAsync(GetEpdSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEpdSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/epd/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEpdSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtain the total amount of emissions for various environmental impacts.
         *
         * @description This API takes a product ID from the user and returns the summary of environmental impact generated for the product. This info helps understand the overall emissions for different environmental impact categories of the product.
         *
         * @param request GetEpdSummaryRequest
         * @return GetEpdSummaryResponse
         */
        public GetEpdSummaryResponse GetEpdSummary(GetEpdSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEpdSummaryWithOptions(request, headers, runtime);
        }

        /**
         * @summary Obtain the total amount of emissions for various environmental impacts.
         *
         * @description This API takes a product ID from the user and returns the summary of environmental impact generated for the product. This info helps understand the overall emissions for different environmental impact categories of the product.
         *
         * @param request GetEpdSummaryRequest
         * @return GetEpdSummaryResponse
         */
        public async Task<GetEpdSummaryResponse> GetEpdSummaryAsync(GetEpdSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEpdSummaryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get the list of product carbon footprints.
         *
         * @description With user-specified parameters such as enterprise code, current page, and page size, this API returns a list of matching product carbon footprints (or supply chain carbon footprints), including product names and product IDs. The product ID can be used as input parameters in other APIs to get the corresponding product\\"s detailed information.
         *
         * @param request GetFootprintListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFootprintListResponse
         */
        public GetFootprintListResponse GetFootprintListWithOptions(GetFootprintListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFootprintList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/product/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get the list of product carbon footprints.
         *
         * @description With user-specified parameters such as enterprise code, current page, and page size, this API returns a list of matching product carbon footprints (or supply chain carbon footprints), including product names and product IDs. The product ID can be used as input parameters in other APIs to get the corresponding product\\"s detailed information.
         *
         * @param request GetFootprintListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFootprintListResponse
         */
        public async Task<GetFootprintListResponse> GetFootprintListWithOptionsAsync(GetFootprintListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFootprintList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/product/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFootprintListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get the list of product carbon footprints.
         *
         * @description With user-specified parameters such as enterprise code, current page, and page size, this API returns a list of matching product carbon footprints (or supply chain carbon footprints), including product names and product IDs. The product ID can be used as input parameters in other APIs to get the corresponding product\\"s detailed information.
         *
         * @param request GetFootprintListRequest
         * @return GetFootprintListResponse
         */
        public GetFootprintListResponse GetFootprintList(GetFootprintListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFootprintListWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get the list of product carbon footprints.
         *
         * @description With user-specified parameters such as enterprise code, current page, and page size, this API returns a list of matching product carbon footprints (or supply chain carbon footprints), including product names and product IDs. The product ID can be used as input parameters in other APIs to get the corresponding product\\"s detailed information.
         *
         * @param request GetFootprintListRequest
         * @return GetFootprintListResponse
         */
        public async Task<GetFootprintListResponse> GetFootprintListAsync(GetFootprintListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFootprintListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain gas composition analysis.
         *
         * @param request GetGasConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGasConstituteResponse
         */
        public GetGasConstituteResponse GetGasConstituteWithOptions(GetGasConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGasConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/gas/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGasConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain gas composition analysis.
         *
         * @param request GetGasConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGasConstituteResponse
         */
        public async Task<GetGasConstituteResponse> GetGasConstituteWithOptionsAsync(GetGasConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGasConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/gas/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGasConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain gas composition analysis.
         *
         * @param request GetGasConstituteRequest
         * @return GetGasConstituteResponse
         */
        public GetGasConstituteResponse GetGasConstitute(GetGasConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGasConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain gas composition analysis.
         *
         * @param request GetGasConstituteRequest
         * @return GetGasConstituteResponse
         */
        public async Task<GetGasConstituteResponse> GetGasConstituteAsync(GetGasConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGasConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary obtain the active carbon reduction ranking list.
         *
         * @description This interface returns a list of proactive carbon reduction information given product ID. It\\"s used to understand the carbon reduction efforts at various levels of the product.
         *
         * @param request GetGwpBenchmarkListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpBenchmarkListResponse
         */
        public GetGwpBenchmarkListResponse GetGwpBenchmarkListWithOptions(GetGwpBenchmarkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary obtain the active carbon reduction ranking list.
         *
         * @description This interface returns a list of proactive carbon reduction information given product ID. It\\"s used to understand the carbon reduction efforts at various levels of the product.
         *
         * @param request GetGwpBenchmarkListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpBenchmarkListResponse
         */
        public async Task<GetGwpBenchmarkListResponse> GetGwpBenchmarkListWithOptionsAsync(GetGwpBenchmarkListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary obtain the active carbon reduction ranking list.
         *
         * @description This interface returns a list of proactive carbon reduction information given product ID. It\\"s used to understand the carbon reduction efforts at various levels of the product.
         *
         * @param request GetGwpBenchmarkListRequest
         * @return GetGwpBenchmarkListResponse
         */
        public GetGwpBenchmarkListResponse GetGwpBenchmarkList(GetGwpBenchmarkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpBenchmarkListWithOptions(request, headers, runtime);
        }

        /**
         * @summary obtain the active carbon reduction ranking list.
         *
         * @description This interface returns a list of proactive carbon reduction information given product ID. It\\"s used to understand the carbon reduction efforts at various levels of the product.
         *
         * @param request GetGwpBenchmarkListRequest
         * @return GetGwpBenchmarkListResponse
         */
        public async Task<GetGwpBenchmarkListResponse> GetGwpBenchmarkListAsync(GetGwpBenchmarkListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpBenchmarkListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This API is to obtain the total amount of active carbon reduction.
         *
         * @description The API takes a product ID and returns data on the carbon emissions reduction along with a list of the top four contributors to carbon reduction. This info helps understand the total carbon reduction of the product and its main sources.
         *
         * @param request GetGwpBenchmarkSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpBenchmarkSummaryResponse
         */
        public GetGwpBenchmarkSummaryResponse GetGwpBenchmarkSummaryWithOptions(GetGwpBenchmarkSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This API is to obtain the total amount of active carbon reduction.
         *
         * @description The API takes a product ID and returns data on the carbon emissions reduction along with a list of the top four contributors to carbon reduction. This info helps understand the total carbon reduction of the product and its main sources.
         *
         * @param request GetGwpBenchmarkSummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpBenchmarkSummaryResponse
         */
        public async Task<GetGwpBenchmarkSummaryResponse> GetGwpBenchmarkSummaryWithOptionsAsync(GetGwpBenchmarkSummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpBenchmarkSummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/benchmark/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpBenchmarkSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This API is to obtain the total amount of active carbon reduction.
         *
         * @description The API takes a product ID and returns data on the carbon emissions reduction along with a list of the top four contributors to carbon reduction. This info helps understand the total carbon reduction of the product and its main sources.
         *
         * @param request GetGwpBenchmarkSummaryRequest
         * @return GetGwpBenchmarkSummaryResponse
         */
        public GetGwpBenchmarkSummaryResponse GetGwpBenchmarkSummary(GetGwpBenchmarkSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpBenchmarkSummaryWithOptions(request, headers, runtime);
        }

        /**
         * @summary This API is to obtain the total amount of active carbon reduction.
         *
         * @description The API takes a product ID and returns data on the carbon emissions reduction along with a list of the top four contributors to carbon reduction. This info helps understand the total carbon reduction of the product and its main sources.
         *
         * @param request GetGwpBenchmarkSummaryRequest
         * @return GetGwpBenchmarkSummaryResponse
         */
        public async Task<GetGwpBenchmarkSummaryResponse> GetGwpBenchmarkSummaryAsync(GetGwpBenchmarkSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpBenchmarkSummaryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @description Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @param request GetGwpInventoryConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpInventoryConstituteResponse
         */
        public GetGwpInventoryConstituteResponse GetGwpInventoryConstituteWithOptions(GetGwpInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventoryConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @description Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @param request GetGwpInventoryConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpInventoryConstituteResponse
         */
        public async Task<GetGwpInventoryConstituteResponse> GetGwpInventoryConstituteWithOptionsAsync(GetGwpInventoryConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventoryConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/constitute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventoryConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @description Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @param request GetGwpInventoryConstituteRequest
         * @return GetGwpInventoryConstituteResponse
         */
        public GetGwpInventoryConstituteResponse GetGwpInventoryConstitute(GetGwpInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpInventoryConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @description Used to obtain the carbon emission composition analysis of a specified product. Carbon emission composition analysis includes two analysis dimensions: inventory and type. In the rendering effect, including a hierarchical list and pie chart.
         *
         * @param request GetGwpInventoryConstituteRequest
         * @return GetGwpInventoryConstituteResponse
         */
        public async Task<GetGwpInventoryConstituteResponse> GetGwpInventoryConstituteAsync(GetGwpInventoryConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpInventoryConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This API is used to obtain the total carbon footprint of a product and the top four types of carbon footprint contribution.
         *
         * @description Returns the total carbon footprint data for the user-specified product ID, along with details on the top four contributors to the carbon footprint, helping to understand the overall carbon footprint and its main components.
         *
         * @param request GetGwpInventorySummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpInventorySummaryResponse
         */
        public GetGwpInventorySummaryResponse GetGwpInventorySummaryWithOptions(GetGwpInventorySummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventorySummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventorySummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This API is used to obtain the total carbon footprint of a product and the top four types of carbon footprint contribution.
         *
         * @description Returns the total carbon footprint data for the user-specified product ID, along with details on the top four contributors to the carbon footprint, helping to understand the overall carbon footprint and its main components.
         *
         * @param request GetGwpInventorySummaryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetGwpInventorySummaryResponse
         */
        public async Task<GetGwpInventorySummaryResponse> GetGwpInventorySummaryWithOptionsAsync(GetGwpInventorySummaryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGwpInventorySummary",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/gwp/inventory/summary",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGwpInventorySummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This API is used to obtain the total carbon footprint of a product and the top four types of carbon footprint contribution.
         *
         * @description Returns the total carbon footprint data for the user-specified product ID, along with details on the top four contributors to the carbon footprint, helping to understand the overall carbon footprint and its main components.
         *
         * @param request GetGwpInventorySummaryRequest
         * @return GetGwpInventorySummaryResponse
         */
        public GetGwpInventorySummaryResponse GetGwpInventorySummary(GetGwpInventorySummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGwpInventorySummaryWithOptions(request, headers, runtime);
        }

        /**
         * @summary This API is used to obtain the total carbon footprint of a product and the top four types of carbon footprint contribution.
         *
         * @description Returns the total carbon footprint data for the user-specified product ID, along with details on the top four contributors to the carbon footprint, helping to understand the overall carbon footprint and its main components.
         *
         * @param request GetGwpInventorySummaryRequest
         * @return GetGwpInventorySummaryResponse
         */
        public async Task<GetGwpInventorySummaryResponse> GetGwpInventorySummaryAsync(GetGwpInventorySummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGwpInventorySummaryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get the list of emissions in descending order under the specified environmental impact (methodType), specified aggregate level (group), and specified calculation mode (emissionType).
         *
         * @description This interface retrieves a descending order list of emissions for a specified product ID, environmental impact method, group level, and calculation method. It\\"s used to understand various environmental impact emission scenarios.
         *
         * @param request GetInventoryListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInventoryListResponse
         */
        public GetInventoryListResponse GetInventoryListWithOptions(GetInventoryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmissionType))
            {
                body["emissionType"] = request.EmissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodType))
            {
                body["methodType"] = request.MethodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventoryList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/inventory/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventoryListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get the list of emissions in descending order under the specified environmental impact (methodType), specified aggregate level (group), and specified calculation mode (emissionType).
         *
         * @description This interface retrieves a descending order list of emissions for a specified product ID, environmental impact method, group level, and calculation method. It\\"s used to understand various environmental impact emission scenarios.
         *
         * @param request GetInventoryListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInventoryListResponse
         */
        public async Task<GetInventoryListResponse> GetInventoryListWithOptionsAsync(GetInventoryListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmissionType))
            {
                body["emissionType"] = request.EmissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodType))
            {
                body["methodType"] = request.MethodType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInventoryList",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/inventory/list",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInventoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get the list of emissions in descending order under the specified environmental impact (methodType), specified aggregate level (group), and specified calculation mode (emissionType).
         *
         * @description This interface retrieves a descending order list of emissions for a specified product ID, environmental impact method, group level, and calculation method. It\\"s used to understand various environmental impact emission scenarios.
         *
         * @param request GetInventoryListRequest
         * @return GetInventoryListResponse
         */
        public GetInventoryListResponse GetInventoryList(GetInventoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInventoryListWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get the list of emissions in descending order under the specified environmental impact (methodType), specified aggregate level (group), and specified calculation mode (emissionType).
         *
         * @description This interface retrieves a descending order list of emissions for a specified product ID, environmental impact method, group level, and calculation method. It\\"s used to understand various environmental impact emission scenarios.
         *
         * @param request GetInventoryListRequest
         * @return GetInventoryListResponse
         */
        public async Task<GetInventoryListResponse> GetInventoryListAsync(GetInventoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInventoryListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the organizations and sites that are activated by using an Alibaba Cloud account. You cannot call this operation to query the organizations or sites that have not been activated in the console.
         *
         * @description *   If an activated site exists, the information about the site and the organization to which the site belongs is returned. If no activated site exists, null is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgAndFactoryResponse
         */
        public GetOrgAndFactoryResponse GetOrgAndFactoryWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgAndFactory",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getOrgAndFactory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAndFactoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the organizations and sites that are activated by using an Alibaba Cloud account. You cannot call this operation to query the organizations or sites that have not been activated in the console.
         *
         * @description *   If an activated site exists, the information about the site and the organization to which the site belongs is returned. If no activated site exists, null is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgAndFactoryResponse
         */
        public async Task<GetOrgAndFactoryResponse> GetOrgAndFactoryWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgAndFactory",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/external/getOrgAndFactory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgAndFactoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the organizations and sites that are activated by using an Alibaba Cloud account. You cannot call this operation to query the organizations or sites that have not been activated in the console.
         *
         * @description *   If an activated site exists, the information about the site and the organization to which the site belongs is returned. If no activated site exists, null is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @return GetOrgAndFactoryResponse
         */
        public GetOrgAndFactoryResponse GetOrgAndFactory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrgAndFactoryWithOptions(headers, runtime);
        }

        /**
         * @summary Queries the organizations and sites that are activated by using an Alibaba Cloud account. You cannot call this operation to query the organizations or sites that have not been activated in the console.
         *
         * @description *   If an activated site exists, the information about the site and the organization to which the site belongs is returned. If no activated site exists, null is returned.
         * - By current, endpoint only supports Hangzhou: `energyexpertexternal.cn-hangzhou.aliyuncs.com`.
         * - To use this API, you need to be added to the whitelist. Please contact us through  <props="china">[official website](https://energy.aliyun.com/ifa/web/defaultLoginPage?adapter=aliyun#/consult?source=%E8%83%BD%E8%80%97%E5%AE%9D%E7%99%BB%E5%BD%95%E9%A1%B5%EF%BC%88WEB%EF%BC%89) 
         * <props="intl">[official website](https://energy.alibabacloud.com/common?adapter=aliyun&lang=en-US#/home/en) to apply for whitelist activation.
         *
         * @return GetOrgAndFactoryResponse
         */
        public async Task<GetOrgAndFactoryResponse> GetOrgAndFactoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrgAndFactoryWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary This interface is used to obtain carbon inventory organization analysis data.
         *
         * @param request GetOrgConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgConstituteResponse
         */
        public GetOrgConstituteResponse GetOrgConstituteWithOptions(GetOrgConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/org",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgConstituteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain carbon inventory organization analysis data.
         *
         * @param request GetOrgConstituteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOrgConstituteResponse
         */
        public async Task<GetOrgConstituteResponse> GetOrgConstituteWithOptionsAsync(GetOrgConstituteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleCode))
            {
                body["moduleCode"] = request.ModuleCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleType))
            {
                body["moduleType"] = request.ModuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOrgConstitute",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/analysis/org",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOrgConstituteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to obtain carbon inventory organization analysis data.
         *
         * @param request GetOrgConstituteRequest
         * @return GetOrgConstituteResponse
         */
        public GetOrgConstituteResponse GetOrgConstitute(GetOrgConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOrgConstituteWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to obtain carbon inventory organization analysis data.
         *
         * @param request GetOrgConstituteRequest
         * @return GetOrgConstituteResponse
         */
        public async Task<GetOrgConstituteResponse> GetOrgConstituteAsync(GetOrgConstituteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOrgConstituteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Obtains the oss address of the Product Carbon footprint Report.
         *
         * @description With the user-specified product ID, this interface retrieves detailed information and download links for previously generated PCR reports. To use it, two conditions must be met: 1) the result has already been generated; 2) the PCR report has been created.
         *
         * @param request GetPcrInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPcrInfoResponse
         */
        public GetPcrInfoResponse GetPcrInfoWithOptions(GetPcrInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPcrInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/pcr/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPcrInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the oss address of the Product Carbon footprint Report.
         *
         * @description With the user-specified product ID, this interface retrieves detailed information and download links for previously generated PCR reports. To use it, two conditions must be met: 1) the result has already been generated; 2) the PCR report has been created.
         *
         * @param request GetPcrInfoRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPcrInfoResponse
         */
        public async Task<GetPcrInfoResponse> GetPcrInfoWithOptionsAsync(GetPcrInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPcrInfo",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/pcr/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPcrInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the oss address of the Product Carbon footprint Report.
         *
         * @description With the user-specified product ID, this interface retrieves detailed information and download links for previously generated PCR reports. To use it, two conditions must be met: 1) the result has already been generated; 2) the PCR report has been created.
         *
         * @param request GetPcrInfoRequest
         * @return GetPcrInfoResponse
         */
        public GetPcrInfoResponse GetPcrInfo(GetPcrInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPcrInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary Obtains the oss address of the Product Carbon footprint Report.
         *
         * @description With the user-specified product ID, this interface retrieves detailed information and download links for previously generated PCR reports. To use it, two conditions must be met: 1) the result has already been generated; 2) the PCR report has been created.
         *
         * @param request GetPcrInfoRequest
         * @return GetPcrInfoResponse
         */
        public async Task<GetPcrInfoResponse> GetPcrInfoAsync(GetPcrInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPcrInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Get carbon reduction recommendations.
         *
         * @description This API returns carbon reduction proposals based on the product ID. It\\"s useful for understanding optimization tips to reduce the carbon emissions associated with a product.
         *
         * @param request GetReductionProposalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReductionProposalResponse
         */
        public GetReductionProposalResponse GetReductionProposalWithOptions(GetReductionProposalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReductionProposal",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/reduction/proposal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReductionProposalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Get carbon reduction recommendations.
         *
         * @description This API returns carbon reduction proposals based on the product ID. It\\"s useful for understanding optimization tips to reduce the carbon emissions associated with a product.
         *
         * @param request GetReductionProposalRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetReductionProposalResponse
         */
        public async Task<GetReductionProposalResponse> GetReductionProposalWithOptionsAsync(GetReductionProposalRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataQualityEvaluationType))
            {
                body["dataQualityEvaluationType"] = request.DataQualityEvaluationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReductionProposal",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/reduction/proposal",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReductionProposalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Get carbon reduction recommendations.
         *
         * @description This API returns carbon reduction proposals based on the product ID. It\\"s useful for understanding optimization tips to reduce the carbon emissions associated with a product.
         *
         * @param request GetReductionProposalRequest
         * @return GetReductionProposalResponse
         */
        public GetReductionProposalResponse GetReductionProposal(GetReductionProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetReductionProposalWithOptions(request, headers, runtime);
        }

        /**
         * @summary Get carbon reduction recommendations.
         *
         * @description This API returns carbon reduction proposals based on the product ID. It\\"s useful for understanding optimization tips to reduce the carbon emissions associated with a product.
         *
         * @param request GetReductionProposalRequest
         * @return GetReductionProposalResponse
         */
        public async Task<GetReductionProposalResponse> GetReductionProposalAsync(GetReductionProposalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetReductionProposalWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Check if the result generation is complete.
         *
         * @description This API checks the completion status of generating a report. It should be used before calling other result APIs, as they will only display content once the report generation is complete.
         *
         * @param request IsCompletedRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return IsCompletedResponse
         */
        public IsCompletedResponse IsCompletedWithOptions(IsCompletedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsCompleted",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/completed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsCompletedResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Check if the result generation is complete.
         *
         * @description This API checks the completion status of generating a report. It should be used before calling other result APIs, as they will only display content once the report generation is complete.
         *
         * @param request IsCompletedRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return IsCompletedResponse
         */
        public async Task<IsCompletedResponse> IsCompletedWithOptionsAsync(IsCompletedRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                body["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IsCompleted",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/footprint/result/completed",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<IsCompletedResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Check if the result generation is complete.
         *
         * @description This API checks the completion status of generating a report. It should be used before calling other result APIs, as they will only display content once the report generation is complete.
         *
         * @param request IsCompletedRequest
         * @return IsCompletedResponse
         */
        public IsCompletedResponse IsCompleted(IsCompletedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return IsCompletedWithOptions(request, headers, runtime);
        }

        /**
         * @summary Check if the result generation is complete.
         *
         * @description This API checks the completion status of generating a report. It should be used before calling other result APIs, as they will only display content once the report generation is complete.
         *
         * @param request IsCompletedRequest
         * @return IsCompletedResponse
         */
        public async Task<IsCompletedResponse> IsCompletedAsync(IsCompletedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await IsCompletedWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to push device measuring point data, such as power meter voltage and other data.
         *
         * @param request PushDeviceDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDeviceDataResponse
         */
        public PushDeviceDataResponse PushDeviceDataWithOptions(PushDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/data/increment/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to push device measuring point data, such as power meter voltage and other data.
         *
         * @param request PushDeviceDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushDeviceDataResponse
         */
        public async Task<PushDeviceDataResponse> PushDeviceDataWithOptionsAsync(PushDeviceDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                body["deviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Devices))
            {
                body["devices"] = request.Devices;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDeviceData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/data/increment/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDeviceDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to push device measuring point data, such as power meter voltage and other data.
         *
         * @param request PushDeviceDataRequest
         * @return PushDeviceDataResponse
         */
        public PushDeviceDataResponse PushDeviceData(PushDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushDeviceDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to push device measuring point data, such as power meter voltage and other data.
         *
         * @param request PushDeviceDataRequest
         * @return PushDeviceDataResponse
         */
        public async Task<PushDeviceDataResponse> PushDeviceDataAsync(PushDeviceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushDeviceDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary This interface is used to push data items.
         *
         * @description - This interface is used for individual data item data.
         * - Data items can link data to services such as carbon footprints and carbon inventories.
         * - Depending on the platform configuration, active data on a yearly and monthly basis is supported.
         *
         * @param request PushItemDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushItemDataResponse
         */
        public PushItemDataResponse PushItemDataWithOptions(PushItemDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushItemData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushItemDataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This interface is used to push data items.
         *
         * @description - This interface is used for individual data item data.
         * - Data items can link data to services such as carbon footprints and carbon inventories.
         * - Depending on the platform configuration, active data on a yearly and monthly basis is supported.
         *
         * @param request PushItemDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PushItemDataResponse
         */
        public async Task<PushItemDataResponse> PushItemDataWithOptionsAsync(PushItemDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Items))
            {
                body["items"] = request.Items;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushItemData",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushItemDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This interface is used to push data items.
         *
         * @description - This interface is used for individual data item data.
         * - Data items can link data to services such as carbon footprints and carbon inventories.
         * - Depending on the platform configuration, active data on a yearly and monthly basis is supported.
         *
         * @param request PushItemDataRequest
         * @return PushItemDataResponse
         */
        public PushItemDataResponse PushItemData(PushItemDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PushItemDataWithOptions(request, headers, runtime);
        }

        /**
         * @summary This interface is used to push data items.
         *
         * @description - This interface is used for individual data item data.
         * - Data items can link data to services such as carbon footprints and carbon inventories.
         * - Depending on the platform configuration, active data on a yearly and monthly basis is supported.
         *
         * @param request PushItemDataRequest
         * @return PushItemDataResponse
         */
        public async Task<PushItemDataResponse> PushItemDataAsync(PushItemDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PushItemDataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Recalculate carbon emissions.
         *
         * @description - After uploading the data items, you need to call this interface to recalculate the carbon inventory data.
         *
         * @param request RecalculateCarbonEmissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecalculateCarbonEmissionResponse
         */
        public RecalculateCarbonEmissionResponse RecalculateCarbonEmissionWithOptions(RecalculateCarbonEmissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecalculateCarbonEmission",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/recalculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecalculateCarbonEmissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Recalculate carbon emissions.
         *
         * @description - After uploading the data items, you need to call this interface to recalculate the carbon inventory data.
         *
         * @param request RecalculateCarbonEmissionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RecalculateCarbonEmissionResponse
         */
        public async Task<RecalculateCarbonEmissionResponse> RecalculateCarbonEmissionWithOptionsAsync(RecalculateCarbonEmissionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Year))
            {
                body["year"] = request.Year;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecalculateCarbonEmission",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/emission/data/item/recalculate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecalculateCarbonEmissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Recalculate carbon emissions.
         *
         * @description - After uploading the data items, you need to call this interface to recalculate the carbon inventory data.
         *
         * @param request RecalculateCarbonEmissionRequest
         * @return RecalculateCarbonEmissionResponse
         */
        public RecalculateCarbonEmissionResponse RecalculateCarbonEmission(RecalculateCarbonEmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecalculateCarbonEmissionWithOptions(request, headers, runtime);
        }

        /**
         * @summary Recalculate carbon emissions.
         *
         * @description - After uploading the data items, you need to call this interface to recalculate the carbon inventory data.
         *
         * @param request RecalculateCarbonEmissionRequest
         * @return RecalculateCarbonEmissionResponse
         */
        public async Task<RecalculateCarbonEmissionResponse> RecalculateCarbonEmissionAsync(RecalculateCarbonEmissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecalculateCarbonEmissionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 在线文档问答
         *
         * @param request SendDocumentAskQuestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDocumentAskQuestionResponse
         */
        public SendDocumentAskQuestionResponse SendDocumentAskQuestionWithOptions(SendDocumentAskQuestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["folderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDocumentAskQuestion",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/sendDocumentAskQuestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDocumentAskQuestionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 在线文档问答
         *
         * @param request SendDocumentAskQuestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendDocumentAskQuestionResponse
         */
        public async Task<SendDocumentAskQuestionResponse> SendDocumentAskQuestionWithOptionsAsync(SendDocumentAskQuestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                body["folderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                body["prompt"] = request.Prompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendDocumentAskQuestion",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/sendDocumentAskQuestion",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendDocumentAskQuestionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 在线文档问答
         *
         * @param request SendDocumentAskQuestionRequest
         * @return SendDocumentAskQuestionResponse
         */
        public SendDocumentAskQuestionResponse SendDocumentAskQuestion(SendDocumentAskQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendDocumentAskQuestionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 在线文档问答
         *
         * @param request SendDocumentAskQuestionRequest
         * @return SendDocumentAskQuestionResponse
         */
        public async Task<SendDocumentAskQuestionResponse> SendDocumentAskQuestionAsync(SendDocumentAskQuestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendDocumentAskQuestionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 设置运行计划
         *
         * @param request SetRunningPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRunningPlanResponse
         */
        public SetRunningPlanResponse SetRunningPlanWithOptions(SetRunningPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["controlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["dateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarliestStartupTime))
            {
                body["earliestStartupTime"] = request.EarliestStartupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestShutdownTime))
            {
                body["latestShutdownTime"] = request.LatestShutdownTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCarbonDioxide))
            {
                body["maxCarbonDioxide"] = request.MaxCarbonDioxide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTem))
            {
                body["maxTem"] = request.MaxTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTem))
            {
                body["minTem"] = request.MinTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PKey))
            {
                body["pKey"] = request.PKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeasonMode))
            {
                body["seasonMode"] = request.SeasonMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsTime))
            {
                body["statisticsTime"] = request.StatisticsTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingEndTime))
            {
                body["workingEndTime"] = request.WorkingEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingStartTime))
            {
                body["workingStartTime"] = request.WorkingStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRunningPlan",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/setRunningPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRunningPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置运行计划
         *
         * @param request SetRunningPlanRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetRunningPlanResponse
         */
        public async Task<SetRunningPlanResponse> SetRunningPlanWithOptionsAsync(SetRunningPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlType))
            {
                body["controlType"] = request.ControlType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateType))
            {
                body["dateType"] = request.DateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EarliestStartupTime))
            {
                body["earliestStartupTime"] = request.EarliestStartupTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FactoryId))
            {
                body["factoryId"] = request.FactoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LatestShutdownTime))
            {
                body["latestShutdownTime"] = request.LatestShutdownTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCarbonDioxide))
            {
                body["maxCarbonDioxide"] = request.MaxCarbonDioxide;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTem))
            {
                body["maxTem"] = request.MaxTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinTem))
            {
                body["minTem"] = request.MinTem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PKey))
            {
                body["pKey"] = request.PKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeasonMode))
            {
                body["seasonMode"] = request.SeasonMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatisticsTime))
            {
                body["statisticsTime"] = request.StatisticsTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemId))
            {
                body["systemId"] = request.SystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingEndTime))
            {
                body["workingEndTime"] = request.WorkingEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingStartTime))
            {
                body["workingStartTime"] = request.WorkingStartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRunningPlan",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/carbon/hvac/setRunningPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRunningPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置运行计划
         *
         * @param request SetRunningPlanRequest
         * @return SetRunningPlanResponse
         */
        public SetRunningPlanResponse SetRunningPlan(SetRunningPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetRunningPlanWithOptions(request, headers, runtime);
        }

        /**
         * @summary 设置运行计划
         *
         * @param request SetRunningPlanRequest
         * @return SetRunningPlanResponse
         */
        public async Task<SetRunningPlanResponse> SetRunningPlanAsync(SetRunningPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetRunningPlanWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文档结果
         *
         * @param request SubmitDocumentAnalyzeJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocumentAnalyzeJobResponse
         */
        public SubmitDocumentAnalyzeJobResponse SubmitDocumentAnalyzeJobWithOptions(SubmitDocumentAnalyzeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocumentAnalyzeJob",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/submitDocumentAnalyzeJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocumentAnalyzeJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取文档结果
         *
         * @param request SubmitDocumentAnalyzeJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDocumentAnalyzeJobResponse
         */
        public async Task<SubmitDocumentAnalyzeJobResponse> SubmitDocumentAnalyzeJobWithOptionsAsync(SubmitDocumentAnalyzeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                query["fileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FolderId))
            {
                query["folderId"] = request.FolderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["templateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDocumentAnalyzeJob",
                Version = "2022-09-23",
                Protocol = "HTTPS",
                Pathname = "/api/v1/aidoc/document/submitDocumentAnalyzeJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDocumentAnalyzeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取文档结果
         *
         * @param request SubmitDocumentAnalyzeJobRequest
         * @return SubmitDocumentAnalyzeJobResponse
         */
        public SubmitDocumentAnalyzeJobResponse SubmitDocumentAnalyzeJob(SubmitDocumentAnalyzeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SubmitDocumentAnalyzeJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文档结果
         *
         * @param request SubmitDocumentAnalyzeJobRequest
         * @return SubmitDocumentAnalyzeJobResponse
         */
        public async Task<SubmitDocumentAnalyzeJobResponse> SubmitDocumentAnalyzeJobAsync(SubmitDocumentAnalyzeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SubmitDocumentAnalyzeJobWithOptionsAsync(request, headers, runtime);
        }

        public SubmitDocumentAnalyzeJobResponse SubmitDocumentAnalyzeJobAdvance(SubmitDocumentAnalyzeJobAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "energyExpertExternal",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocumentAnalyzeJobRequest submitDocumentAnalyzeJobReq = new SubmitDocumentAnalyzeJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocumentAnalyzeJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                submitDocumentAnalyzeJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocumentAnalyzeJobResponse submitDocumentAnalyzeJobResp = SubmitDocumentAnalyzeJobWithOptions(submitDocumentAnalyzeJobReq, headers, runtime);
            return submitDocumentAnalyzeJobResp;
        }

        public async Task<SubmitDocumentAnalyzeJobResponse> SubmitDocumentAnalyzeJobAdvanceAsync(SubmitDocumentAnalyzeJobAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "energyExpertExternal",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            SubmitDocumentAnalyzeJobRequest submitDocumentAnalyzeJobReq = new SubmitDocumentAnalyzeJobRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, submitDocumentAnalyzeJobReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                submitDocumentAnalyzeJobReq.FileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            SubmitDocumentAnalyzeJobResponse submitDocumentAnalyzeJobResp = await SubmitDocumentAnalyzeJobWithOptionsAsync(submitDocumentAnalyzeJobReq, headers, runtime);
            return submitDocumentAnalyzeJobResp;
        }

    }
}
