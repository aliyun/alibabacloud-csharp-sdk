// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Iot20180120.Models;

namespace AlibabaCloud.SDK.Iot20180120
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "iot.aliyuncs.com"},
                {"ap-south-1", "iot.aliyuncs.com"},
                {"ap-southeast-2", "iot.aliyuncs.com"},
                {"ap-southeast-3", "iot.aliyuncs.com"},
                {"ap-southeast-5", "iot.aliyuncs.com"},
                {"cn-beijing-finance-1", "iot.aliyuncs.com"},
                {"cn-beijing-finance-pop", "iot.aliyuncs.com"},
                {"cn-beijing-gov-1", "iot.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "iot.aliyuncs.com"},
                {"cn-chengdu", "iot.aliyuncs.com"},
                {"cn-edge-1", "iot.aliyuncs.com"},
                {"cn-fujian", "iot.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "iot.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "iot.aliyuncs.com"},
                {"cn-hangzhou-finance", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "iot.aliyuncs.com"},
                {"cn-hangzhou-test-306", "iot.aliyuncs.com"},
                {"cn-hongkong", "iot.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "iot.aliyuncs.com"},
                {"cn-huhehaote", "iot.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "iot.aliyuncs.com"},
                {"cn-qingdao", "iot.aliyuncs.com"},
                {"cn-qingdao-nebula", "iot.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "iot.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "iot.aliyuncs.com"},
                {"cn-shanghai-finance-1", "iot.aliyuncs.com"},
                {"cn-shanghai-inner", "iot.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "iot.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "iot.aliyuncs.com"},
                {"cn-shenzhen-inner", "iot.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "iot.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "iot.aliyuncs.com"},
                {"cn-wuhan", "iot.aliyuncs.com"},
                {"cn-wulanchabu", "iot.aliyuncs.com"},
                {"cn-yushanfang", "iot.aliyuncs.com"},
                {"cn-zhangbei", "iot.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "iot.aliyuncs.com"},
                {"cn-zhangjiakou", "iot.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "iot.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "iot.aliyuncs.com"},
                {"eu-west-1", "iot.aliyuncs.com"},
                {"eu-west-1-oxs", "iot.aliyuncs.com"},
                {"me-east-1", "iot.aliyuncs.com"},
                {"rus-west-1-pop", "iot.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("iot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public AddDataForApiSourceResponse AddDataForApiSourceWithOptions(AddDataForApiSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDataForApiSourceResponse>(DoRequest("AddDataForApiSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddDataForApiSourceResponse> AddDataForApiSourceWithOptionsAsync(AddDataForApiSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDataForApiSourceResponse>(await DoRequestAsync("AddDataForApiSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public AddDataForApiSourceResponse AddDataForApiSource(AddDataForApiSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDataForApiSourceWithOptions(request, runtime);
        }

        public async Task<AddDataForApiSourceResponse> AddDataForApiSourceAsync(AddDataForApiSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDataForApiSourceWithOptionsAsync(request, runtime);
        }

        public AddShareTaskDeviceResponse AddShareTaskDeviceWithOptions(AddShareTaskDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddShareTaskDeviceResponse>(DoRequest("AddShareTaskDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddShareTaskDeviceResponse> AddShareTaskDeviceWithOptionsAsync(AddShareTaskDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddShareTaskDeviceResponse>(await DoRequestAsync("AddShareTaskDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public AddShareTaskDeviceResponse AddShareTaskDevice(AddShareTaskDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddShareTaskDeviceWithOptions(request, runtime);
        }

        public async Task<AddShareTaskDeviceResponse> AddShareTaskDeviceAsync(AddShareTaskDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddShareTaskDeviceWithOptionsAsync(request, runtime);
        }

        public AttachDestinationResponse AttachDestinationWithOptions(AttachDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachDestinationResponse>(DoRequest("AttachDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AttachDestinationResponse> AttachDestinationWithOptionsAsync(AttachDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachDestinationResponse>(await DoRequestAsync("AttachDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public AttachDestinationResponse AttachDestination(AttachDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDestinationWithOptions(request, runtime);
        }

        public async Task<AttachDestinationResponse> AttachDestinationAsync(AttachDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDestinationWithOptionsAsync(request, runtime);
        }

        public AttachParserDataSourceResponse AttachParserDataSourceWithOptions(AttachParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachParserDataSourceResponse>(DoRequest("AttachParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AttachParserDataSourceResponse> AttachParserDataSourceWithOptionsAsync(AttachParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AttachParserDataSourceResponse>(await DoRequestAsync("AttachParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public AttachParserDataSourceResponse AttachParserDataSource(AttachParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachParserDataSourceWithOptions(request, runtime);
        }

        public async Task<AttachParserDataSourceResponse> AttachParserDataSourceAsync(AttachParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachParserDataSourceWithOptionsAsync(request, runtime);
        }

        public BatchAddDataForApiSourceResponse BatchAddDataForApiSourceWithOptions(BatchAddDataForApiSourceRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            BatchAddDataForApiSourceShrinkRequest request = new BatchAddDataForApiSourceShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ContentList))
            {
                request.ContentListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ContentList);
            }
            return TeaModel.ToObject<BatchAddDataForApiSourceResponse>(DoRequest("BatchAddDataForApiSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchAddDataForApiSourceResponse> BatchAddDataForApiSourceWithOptionsAsync(BatchAddDataForApiSourceRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            BatchAddDataForApiSourceShrinkRequest request = new BatchAddDataForApiSourceShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.ContentList))
            {
                request.ContentListShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.ContentList);
            }
            return TeaModel.ToObject<BatchAddDataForApiSourceResponse>(await DoRequestAsync("BatchAddDataForApiSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchAddDataForApiSourceResponse BatchAddDataForApiSource(BatchAddDataForApiSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddDataForApiSourceWithOptions(request, runtime);
        }

        public async Task<BatchAddDataForApiSourceResponse> BatchAddDataForApiSourceAsync(BatchAddDataForApiSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddDataForApiSourceWithOptionsAsync(request, runtime);
        }

        public BatchAddDeviceGroupRelationsResponse BatchAddDeviceGroupRelationsWithOptions(BatchAddDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddDeviceGroupRelationsResponse>(DoRequest("BatchAddDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchAddDeviceGroupRelationsResponse> BatchAddDeviceGroupRelationsWithOptionsAsync(BatchAddDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddDeviceGroupRelationsResponse>(await DoRequestAsync("BatchAddDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchAddDeviceGroupRelationsResponse BatchAddDeviceGroupRelations(BatchAddDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddDeviceGroupRelationsWithOptions(request, runtime);
        }

        public async Task<BatchAddDeviceGroupRelationsResponse> BatchAddDeviceGroupRelationsAsync(BatchAddDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddDeviceGroupRelationsWithOptionsAsync(request, runtime);
        }

        public BatchAddThingTopoResponse BatchAddThingTopoWithOptions(BatchAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddThingTopoResponse>(DoRequest("BatchAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchAddThingTopoResponse> BatchAddThingTopoWithOptionsAsync(BatchAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddThingTopoResponse>(await DoRequestAsync("BatchAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchAddThingTopoResponse BatchAddThingTopo(BatchAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddThingTopoWithOptions(request, runtime);
        }

        public async Task<BatchAddThingTopoResponse> BatchAddThingTopoAsync(BatchAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddThingTopoWithOptionsAsync(request, runtime);
        }

        public BatchBindDeviceToEdgeInstanceWithDriverResponse BatchBindDeviceToEdgeInstanceWithDriverWithOptions(BatchBindDeviceToEdgeInstanceWithDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDeviceToEdgeInstanceWithDriverResponse>(DoRequest("BatchBindDeviceToEdgeInstanceWithDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindDeviceToEdgeInstanceWithDriverResponse> BatchBindDeviceToEdgeInstanceWithDriverWithOptionsAsync(BatchBindDeviceToEdgeInstanceWithDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDeviceToEdgeInstanceWithDriverResponse>(await DoRequestAsync("BatchBindDeviceToEdgeInstanceWithDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindDeviceToEdgeInstanceWithDriverResponse BatchBindDeviceToEdgeInstanceWithDriver(BatchBindDeviceToEdgeInstanceWithDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDeviceToEdgeInstanceWithDriverWithOptions(request, runtime);
        }

        public async Task<BatchBindDeviceToEdgeInstanceWithDriverResponse> BatchBindDeviceToEdgeInstanceWithDriverAsync(BatchBindDeviceToEdgeInstanceWithDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDeviceToEdgeInstanceWithDriverWithOptionsAsync(request, runtime);
        }

        public BatchBindDevicesIntoProjectResponse BatchBindDevicesIntoProjectWithOptions(BatchBindDevicesIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDevicesIntoProjectResponse>(DoRequest("BatchBindDevicesIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindDevicesIntoProjectResponse> BatchBindDevicesIntoProjectWithOptionsAsync(BatchBindDevicesIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDevicesIntoProjectResponse>(await DoRequestAsync("BatchBindDevicesIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindDevicesIntoProjectResponse BatchBindDevicesIntoProject(BatchBindDevicesIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDevicesIntoProjectWithOptions(request, runtime);
        }

        public async Task<BatchBindDevicesIntoProjectResponse> BatchBindDevicesIntoProjectAsync(BatchBindDevicesIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDevicesIntoProjectWithOptionsAsync(request, runtime);
        }

        public BatchBindProductsIntoProjectResponse BatchBindProductsIntoProjectWithOptions(BatchBindProductsIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindProductsIntoProjectResponse>(DoRequest("BatchBindProductsIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindProductsIntoProjectResponse> BatchBindProductsIntoProjectWithOptionsAsync(BatchBindProductsIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindProductsIntoProjectResponse>(await DoRequestAsync("BatchBindProductsIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindProductsIntoProjectResponse BatchBindProductsIntoProject(BatchBindProductsIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindProductsIntoProjectWithOptions(request, runtime);
        }

        public async Task<BatchBindProductsIntoProjectResponse> BatchBindProductsIntoProjectAsync(BatchBindProductsIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindProductsIntoProjectWithOptionsAsync(request, runtime);
        }

        public BatchCheckDeviceNamesResponse BatchCheckDeviceNamesWithOptions(BatchCheckDeviceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckDeviceNamesResponse>(DoRequest("BatchCheckDeviceNames", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCheckDeviceNamesResponse> BatchCheckDeviceNamesWithOptionsAsync(BatchCheckDeviceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckDeviceNamesResponse>(await DoRequestAsync("BatchCheckDeviceNames", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCheckDeviceNamesResponse BatchCheckDeviceNames(BatchCheckDeviceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCheckDeviceNamesWithOptions(request, runtime);
        }

        public async Task<BatchCheckDeviceNamesResponse> BatchCheckDeviceNamesAsync(BatchCheckDeviceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCheckDeviceNamesWithOptionsAsync(request, runtime);
        }

        public BatchCheckImportDeviceResponse BatchCheckImportDeviceWithOptions(BatchCheckImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckImportDeviceResponse>(DoRequest("BatchCheckImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCheckImportDeviceResponse> BatchCheckImportDeviceWithOptionsAsync(BatchCheckImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckImportDeviceResponse>(await DoRequestAsync("BatchCheckImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCheckImportDeviceResponse BatchCheckImportDevice(BatchCheckImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCheckImportDeviceWithOptions(request, runtime);
        }

        public async Task<BatchCheckImportDeviceResponse> BatchCheckImportDeviceAsync(BatchCheckImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCheckImportDeviceWithOptionsAsync(request, runtime);
        }

        public BatchCheckVehicleDeviceResponse BatchCheckVehicleDeviceWithOptions(BatchCheckVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckVehicleDeviceResponse>(DoRequest("BatchCheckVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCheckVehicleDeviceResponse> BatchCheckVehicleDeviceWithOptionsAsync(BatchCheckVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckVehicleDeviceResponse>(await DoRequestAsync("BatchCheckVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCheckVehicleDeviceResponse BatchCheckVehicleDevice(BatchCheckVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCheckVehicleDeviceWithOptions(request, runtime);
        }

        public async Task<BatchCheckVehicleDeviceResponse> BatchCheckVehicleDeviceAsync(BatchCheckVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCheckVehicleDeviceWithOptionsAsync(request, runtime);
        }

        public BatchClearEdgeInstanceDeviceConfigResponse BatchClearEdgeInstanceDeviceConfigWithOptions(BatchClearEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchClearEdgeInstanceDeviceConfigResponse>(DoRequest("BatchClearEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchClearEdgeInstanceDeviceConfigResponse> BatchClearEdgeInstanceDeviceConfigWithOptionsAsync(BatchClearEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchClearEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchClearEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchClearEdgeInstanceDeviceConfigResponse BatchClearEdgeInstanceDeviceConfig(BatchClearEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchClearEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchClearEdgeInstanceDeviceConfigResponse> BatchClearEdgeInstanceDeviceConfigAsync(BatchClearEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchClearEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchCreateSoundCodeLabelResponse BatchCreateSoundCodeLabelWithOptions(BatchCreateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCreateSoundCodeLabelResponse>(DoRequest("BatchCreateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCreateSoundCodeLabelResponse> BatchCreateSoundCodeLabelWithOptionsAsync(BatchCreateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCreateSoundCodeLabelResponse>(await DoRequestAsync("BatchCreateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCreateSoundCodeLabelResponse BatchCreateSoundCodeLabel(BatchCreateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateSoundCodeLabelWithOptions(request, runtime);
        }

        public async Task<BatchCreateSoundCodeLabelResponse> BatchCreateSoundCodeLabelAsync(BatchCreateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateSoundCodeLabelWithOptionsAsync(request, runtime);
        }

        public BatchCreateSoundCodeLabelWithLabelsResponse BatchCreateSoundCodeLabelWithLabelsWithOptions(BatchCreateSoundCodeLabelWithLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCreateSoundCodeLabelWithLabelsResponse>(DoRequest("BatchCreateSoundCodeLabelWithLabels", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCreateSoundCodeLabelWithLabelsResponse> BatchCreateSoundCodeLabelWithLabelsWithOptionsAsync(BatchCreateSoundCodeLabelWithLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCreateSoundCodeLabelWithLabelsResponse>(await DoRequestAsync("BatchCreateSoundCodeLabelWithLabels", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCreateSoundCodeLabelWithLabelsResponse BatchCreateSoundCodeLabelWithLabels(BatchCreateSoundCodeLabelWithLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCreateSoundCodeLabelWithLabelsWithOptions(request, runtime);
        }

        public async Task<BatchCreateSoundCodeLabelWithLabelsResponse> BatchCreateSoundCodeLabelWithLabelsAsync(BatchCreateSoundCodeLabelWithLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCreateSoundCodeLabelWithLabelsWithOptionsAsync(request, runtime);
        }

        public BatchDeleteDeviceGroupRelationsResponse BatchDeleteDeviceGroupRelationsWithOptions(BatchDeleteDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteDeviceGroupRelationsResponse>(DoRequest("BatchDeleteDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchDeleteDeviceGroupRelationsResponse> BatchDeleteDeviceGroupRelationsWithOptionsAsync(BatchDeleteDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteDeviceGroupRelationsResponse>(await DoRequestAsync("BatchDeleteDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchDeleteDeviceGroupRelationsResponse BatchDeleteDeviceGroupRelations(BatchDeleteDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDeviceGroupRelationsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteDeviceGroupRelationsResponse> BatchDeleteDeviceGroupRelationsAsync(BatchDeleteDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDeviceGroupRelationsWithOptionsAsync(request, runtime);
        }

        public BatchDeleteEdgeInstanceChannelResponse BatchDeleteEdgeInstanceChannelWithOptions(BatchDeleteEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteEdgeInstanceChannelResponse>(DoRequest("BatchDeleteEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchDeleteEdgeInstanceChannelResponse> BatchDeleteEdgeInstanceChannelWithOptionsAsync(BatchDeleteEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteEdgeInstanceChannelResponse>(await DoRequestAsync("BatchDeleteEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchDeleteEdgeInstanceChannelResponse BatchDeleteEdgeInstanceChannel(BatchDeleteEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<BatchDeleteEdgeInstanceChannelResponse> BatchDeleteEdgeInstanceChannelAsync(BatchDeleteEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchGetDeviceBindStatusResponse BatchGetDeviceBindStatusWithOptions(BatchGetDeviceBindStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceBindStatusResponse>(DoRequest("BatchGetDeviceBindStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetDeviceBindStatusResponse> BatchGetDeviceBindStatusWithOptionsAsync(BatchGetDeviceBindStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceBindStatusResponse>(await DoRequestAsync("BatchGetDeviceBindStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetDeviceBindStatusResponse BatchGetDeviceBindStatus(BatchGetDeviceBindStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetDeviceBindStatusWithOptions(request, runtime);
        }

        public async Task<BatchGetDeviceBindStatusResponse> BatchGetDeviceBindStatusAsync(BatchGetDeviceBindStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetDeviceBindStatusWithOptionsAsync(request, runtime);
        }

        public BatchGetDeviceStateResponse BatchGetDeviceStateWithOptions(BatchGetDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceStateResponse>(DoRequest("BatchGetDeviceState", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetDeviceStateResponse> BatchGetDeviceStateWithOptionsAsync(BatchGetDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceStateResponse>(await DoRequestAsync("BatchGetDeviceState", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetDeviceStateResponse BatchGetDeviceState(BatchGetDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetDeviceStateWithOptions(request, runtime);
        }

        public async Task<BatchGetDeviceStateResponse> BatchGetDeviceStateAsync(BatchGetDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetDeviceStateWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeDriverResponse BatchGetEdgeDriverWithOptions(BatchGetEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeDriverResponse>(DoRequest("BatchGetEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeDriverResponse> BatchGetEdgeDriverWithOptionsAsync(BatchGetEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeDriverResponse>(await DoRequestAsync("BatchGetEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeDriverResponse BatchGetEdgeDriver(BatchGetEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeDriverWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeDriverResponse> BatchGetEdgeDriverAsync(BatchGetEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeDriverWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceChannelResponse BatchGetEdgeInstanceChannelWithOptions(BatchGetEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceChannelResponse>(DoRequest("BatchGetEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceChannelResponse> BatchGetEdgeInstanceChannelWithOptionsAsync(BatchGetEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceChannelResponse>(await DoRequestAsync("BatchGetEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceChannelResponse BatchGetEdgeInstanceChannel(BatchGetEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceChannelResponse> BatchGetEdgeInstanceChannelAsync(BatchGetEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceChannelResponse BatchGetEdgeInstanceDeviceChannelWithOptions(BatchGetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceChannelResponse>(DoRequest("BatchGetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceChannelResponse> BatchGetEdgeInstanceDeviceChannelWithOptionsAsync(BatchGetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceChannelResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceChannelResponse BatchGetEdgeInstanceDeviceChannel(BatchGetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceChannelWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceChannelResponse> BatchGetEdgeInstanceDeviceChannelAsync(BatchGetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceChannelWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceConfigResponse BatchGetEdgeInstanceDeviceConfigWithOptions(BatchGetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceConfigResponse>(DoRequest("BatchGetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceConfigResponse> BatchGetEdgeInstanceDeviceConfigWithOptionsAsync(BatchGetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceConfigResponse BatchGetEdgeInstanceDeviceConfig(BatchGetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceConfigResponse> BatchGetEdgeInstanceDeviceConfigAsync(BatchGetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceDriverResponse BatchGetEdgeInstanceDeviceDriverWithOptions(BatchGetEdgeInstanceDeviceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceDriverResponse>(DoRequest("BatchGetEdgeInstanceDeviceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceDriverResponse> BatchGetEdgeInstanceDeviceDriverWithOptionsAsync(BatchGetEdgeInstanceDeviceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceDriverResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceDriverResponse BatchGetEdgeInstanceDeviceDriver(BatchGetEdgeInstanceDeviceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceDriverWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceDriverResponse> BatchGetEdgeInstanceDeviceDriverAsync(BatchGetEdgeInstanceDeviceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceDriverWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDriverConfigsResponse BatchGetEdgeInstanceDriverConfigsWithOptions(BatchGetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDriverConfigsResponse>(DoRequest("BatchGetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDriverConfigsResponse> BatchGetEdgeInstanceDriverConfigsWithOptionsAsync(BatchGetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("BatchGetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDriverConfigsResponse BatchGetEdgeInstanceDriverConfigs(BatchGetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDriverConfigsResponse> BatchGetEdgeInstanceDriverConfigsAsync(BatchGetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public BatchImportDeviceResponse BatchImportDeviceWithOptions(BatchImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchImportDeviceResponse>(DoRequest("BatchImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchImportDeviceResponse> BatchImportDeviceWithOptionsAsync(BatchImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchImportDeviceResponse>(await DoRequestAsync("BatchImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchImportDeviceResponse BatchImportDevice(BatchImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchImportDeviceWithOptions(request, runtime);
        }

        public async Task<BatchImportDeviceResponse> BatchImportDeviceAsync(BatchImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchImportDeviceWithOptionsAsync(request, runtime);
        }

        public BatchImportVehicleDeviceResponse BatchImportVehicleDeviceWithOptions(BatchImportVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchImportVehicleDeviceResponse>(DoRequest("BatchImportVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchImportVehicleDeviceResponse> BatchImportVehicleDeviceWithOptionsAsync(BatchImportVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchImportVehicleDeviceResponse>(await DoRequestAsync("BatchImportVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchImportVehicleDeviceResponse BatchImportVehicleDevice(BatchImportVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchImportVehicleDeviceWithOptions(request, runtime);
        }

        public async Task<BatchImportVehicleDeviceResponse> BatchImportVehicleDeviceAsync(BatchImportVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchImportVehicleDeviceWithOptionsAsync(request, runtime);
        }

        public BatchPubResponse BatchPubWithOptions(BatchPubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchPubResponse>(DoRequest("BatchPub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchPubResponse> BatchPubWithOptionsAsync(BatchPubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchPubResponse>(await DoRequestAsync("BatchPub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchPubResponse BatchPub(BatchPubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchPubWithOptions(request, runtime);
        }

        public async Task<BatchPubResponse> BatchPubAsync(BatchPubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchPubWithOptionsAsync(request, runtime);
        }

        public BatchQueryDeviceDetailResponse BatchQueryDeviceDetailWithOptions(BatchQueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchQueryDeviceDetailResponse>(DoRequest("BatchQueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchQueryDeviceDetailResponse> BatchQueryDeviceDetailWithOptionsAsync(BatchQueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchQueryDeviceDetailResponse>(await DoRequestAsync("BatchQueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchQueryDeviceDetailResponse BatchQueryDeviceDetail(BatchQueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryDeviceDetailWithOptions(request, runtime);
        }

        public async Task<BatchQueryDeviceDetailResponse> BatchQueryDeviceDetailAsync(BatchQueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryDeviceDetailWithOptionsAsync(request, runtime);
        }

        public BatchRegisterDeviceResponse BatchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(DoRequest("BatchRegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceWithOptionsAsync(BatchRegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(await DoRequestAsync("BatchRegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchRegisterDeviceResponse BatchRegisterDevice(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRegisterDeviceWithOptions(request, runtime);
        }

        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceAsync(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRegisterDeviceWithOptionsAsync(request, runtime);
        }

        public BatchRegisterDeviceWithApplyIdResponse BatchRegisterDeviceWithApplyIdWithOptions(BatchRegisterDeviceWithApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceWithApplyIdResponse>(DoRequest("BatchRegisterDeviceWithApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchRegisterDeviceWithApplyIdResponse> BatchRegisterDeviceWithApplyIdWithOptionsAsync(BatchRegisterDeviceWithApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceWithApplyIdResponse>(await DoRequestAsync("BatchRegisterDeviceWithApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchRegisterDeviceWithApplyIdResponse BatchRegisterDeviceWithApplyId(BatchRegisterDeviceWithApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRegisterDeviceWithApplyIdWithOptions(request, runtime);
        }

        public async Task<BatchRegisterDeviceWithApplyIdResponse> BatchRegisterDeviceWithApplyIdAsync(BatchRegisterDeviceWithApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRegisterDeviceWithApplyIdWithOptionsAsync(request, runtime);
        }

        public BatchSetEdgeInstanceDeviceChannelResponse BatchSetEdgeInstanceDeviceChannelWithOptions(BatchSetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceChannelResponse>(DoRequest("BatchSetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchSetEdgeInstanceDeviceChannelResponse> BatchSetEdgeInstanceDeviceChannelWithOptionsAsync(BatchSetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceChannelResponse>(await DoRequestAsync("BatchSetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchSetEdgeInstanceDeviceChannelResponse BatchSetEdgeInstanceDeviceChannel(BatchSetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetEdgeInstanceDeviceChannelWithOptions(request, runtime);
        }

        public async Task<BatchSetEdgeInstanceDeviceChannelResponse> BatchSetEdgeInstanceDeviceChannelAsync(BatchSetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetEdgeInstanceDeviceChannelWithOptionsAsync(request, runtime);
        }

        public BatchSetEdgeInstanceDeviceConfigResponse BatchSetEdgeInstanceDeviceConfigWithOptions(BatchSetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceConfigResponse>(DoRequest("BatchSetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchSetEdgeInstanceDeviceConfigResponse> BatchSetEdgeInstanceDeviceConfigWithOptionsAsync(BatchSetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchSetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchSetEdgeInstanceDeviceConfigResponse BatchSetEdgeInstanceDeviceConfig(BatchSetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchSetEdgeInstanceDeviceConfigResponse> BatchSetEdgeInstanceDeviceConfigAsync(BatchSetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchUnbindDeviceFromEdgeInstanceResponse BatchUnbindDeviceFromEdgeInstanceWithOptions(BatchUnbindDeviceFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindDeviceFromEdgeInstanceResponse>(DoRequest("BatchUnbindDeviceFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindDeviceFromEdgeInstanceResponse> BatchUnbindDeviceFromEdgeInstanceWithOptionsAsync(BatchUnbindDeviceFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindDeviceFromEdgeInstanceResponse>(await DoRequestAsync("BatchUnbindDeviceFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindDeviceFromEdgeInstanceResponse BatchUnbindDeviceFromEdgeInstance(BatchUnbindDeviceFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindDeviceFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BatchUnbindDeviceFromEdgeInstanceResponse> BatchUnbindDeviceFromEdgeInstanceAsync(BatchUnbindDeviceFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindDeviceFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BatchUnbindProjectDevicesResponse BatchUnbindProjectDevicesWithOptions(BatchUnbindProjectDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectDevicesResponse>(DoRequest("BatchUnbindProjectDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindProjectDevicesResponse> BatchUnbindProjectDevicesWithOptionsAsync(BatchUnbindProjectDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectDevicesResponse>(await DoRequestAsync("BatchUnbindProjectDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindProjectDevicesResponse BatchUnbindProjectDevices(BatchUnbindProjectDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindProjectDevicesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindProjectDevicesResponse> BatchUnbindProjectDevicesAsync(BatchUnbindProjectDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindProjectDevicesWithOptionsAsync(request, runtime);
        }

        public BatchUnbindProjectProductsResponse BatchUnbindProjectProductsWithOptions(BatchUnbindProjectProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectProductsResponse>(DoRequest("BatchUnbindProjectProducts", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindProjectProductsResponse> BatchUnbindProjectProductsWithOptionsAsync(BatchUnbindProjectProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectProductsResponse>(await DoRequestAsync("BatchUnbindProjectProducts", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindProjectProductsResponse BatchUnbindProjectProducts(BatchUnbindProjectProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindProjectProductsWithOptions(request, runtime);
        }

        public async Task<BatchUnbindProjectProductsResponse> BatchUnbindProjectProductsAsync(BatchUnbindProjectProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindProjectProductsWithOptionsAsync(request, runtime);
        }

        public BatchUpdateDeviceNicknameResponse BatchUpdateDeviceNicknameWithOptions(BatchUpdateDeviceNicknameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUpdateDeviceNicknameResponse>(DoRequest("BatchUpdateDeviceNickname", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUpdateDeviceNicknameResponse> BatchUpdateDeviceNicknameWithOptionsAsync(BatchUpdateDeviceNicknameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUpdateDeviceNicknameResponse>(await DoRequestAsync("BatchUpdateDeviceNickname", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUpdateDeviceNicknameResponse BatchUpdateDeviceNickname(BatchUpdateDeviceNicknameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateDeviceNicknameWithOptions(request, runtime);
        }

        public async Task<BatchUpdateDeviceNicknameResponse> BatchUpdateDeviceNicknameAsync(BatchUpdateDeviceNicknameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateDeviceNicknameWithOptionsAsync(request, runtime);
        }

        public BindApplicationToEdgeInstanceResponse BindApplicationToEdgeInstanceWithOptions(BindApplicationToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindApplicationToEdgeInstanceResponse>(DoRequest("BindApplicationToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindApplicationToEdgeInstanceResponse> BindApplicationToEdgeInstanceWithOptionsAsync(BindApplicationToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindApplicationToEdgeInstanceResponse>(await DoRequestAsync("BindApplicationToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindApplicationToEdgeInstanceResponse BindApplicationToEdgeInstance(BindApplicationToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindApplicationToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindApplicationToEdgeInstanceResponse> BindApplicationToEdgeInstanceAsync(BindApplicationToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindApplicationToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BindDriverToEdgeInstanceResponse BindDriverToEdgeInstanceWithOptions(BindDriverToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindDriverToEdgeInstanceResponse>(DoRequest("BindDriverToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindDriverToEdgeInstanceResponse> BindDriverToEdgeInstanceWithOptionsAsync(BindDriverToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindDriverToEdgeInstanceResponse>(await DoRequestAsync("BindDriverToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindDriverToEdgeInstanceResponse BindDriverToEdgeInstance(BindDriverToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindDriverToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindDriverToEdgeInstanceResponse> BindDriverToEdgeInstanceAsync(BindDriverToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindDriverToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BindGatewayToEdgeInstanceResponse BindGatewayToEdgeInstanceWithOptions(BindGatewayToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindGatewayToEdgeInstanceResponse>(DoRequest("BindGatewayToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindGatewayToEdgeInstanceResponse> BindGatewayToEdgeInstanceWithOptionsAsync(BindGatewayToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindGatewayToEdgeInstanceResponse>(await DoRequestAsync("BindGatewayToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindGatewayToEdgeInstanceResponse BindGatewayToEdgeInstance(BindGatewayToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindGatewayToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindGatewayToEdgeInstanceResponse> BindGatewayToEdgeInstanceAsync(BindGatewayToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindGatewayToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BindLicenseDeviceResponse BindLicenseDeviceWithOptions(BindLicenseDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindLicenseDeviceResponse>(DoRequest("BindLicenseDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindLicenseDeviceResponse> BindLicenseDeviceWithOptionsAsync(BindLicenseDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindLicenseDeviceResponse>(await DoRequestAsync("BindLicenseDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindLicenseDeviceResponse BindLicenseDevice(BindLicenseDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindLicenseDeviceWithOptions(request, runtime);
        }

        public async Task<BindLicenseDeviceResponse> BindLicenseDeviceAsync(BindLicenseDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindLicenseDeviceWithOptionsAsync(request, runtime);
        }

        public BindLicenseProductResponse BindLicenseProductWithOptions(BindLicenseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindLicenseProductResponse>(DoRequest("BindLicenseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindLicenseProductResponse> BindLicenseProductWithOptionsAsync(BindLicenseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindLicenseProductResponse>(await DoRequestAsync("BindLicenseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindLicenseProductResponse BindLicenseProduct(BindLicenseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindLicenseProductWithOptions(request, runtime);
        }

        public async Task<BindLicenseProductResponse> BindLicenseProductAsync(BindLicenseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindLicenseProductWithOptionsAsync(request, runtime);
        }

        public BindRoleToEdgeInstanceResponse BindRoleToEdgeInstanceWithOptions(BindRoleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindRoleToEdgeInstanceResponse>(DoRequest("BindRoleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindRoleToEdgeInstanceResponse> BindRoleToEdgeInstanceWithOptionsAsync(BindRoleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindRoleToEdgeInstanceResponse>(await DoRequestAsync("BindRoleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindRoleToEdgeInstanceResponse BindRoleToEdgeInstance(BindRoleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindRoleToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindRoleToEdgeInstanceResponse> BindRoleToEdgeInstanceAsync(BindRoleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindRoleToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BindSceneRuleToEdgeInstanceResponse BindSceneRuleToEdgeInstanceWithOptions(BindSceneRuleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindSceneRuleToEdgeInstanceResponse>(DoRequest("BindSceneRuleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindSceneRuleToEdgeInstanceResponse> BindSceneRuleToEdgeInstanceWithOptionsAsync(BindSceneRuleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindSceneRuleToEdgeInstanceResponse>(await DoRequestAsync("BindSceneRuleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindSceneRuleToEdgeInstanceResponse BindSceneRuleToEdgeInstance(BindSceneRuleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindSceneRuleToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindSceneRuleToEdgeInstanceResponse> BindSceneRuleToEdgeInstanceAsync(BindSceneRuleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindSceneRuleToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public CancelJobResponse CancelJobWithOptions(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelJobResponse>(DoRequest("CancelJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelJobResponse> CancelJobWithOptionsAsync(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelJobResponse>(await DoRequestAsync("CancelJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelJobWithOptions(request, runtime);
        }

        public async Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelJobWithOptionsAsync(request, runtime);
        }

        public CancelOTAStrategyByJobResponse CancelOTAStrategyByJobWithOptions(CancelOTAStrategyByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTAStrategyByJobResponse>(DoRequest("CancelOTAStrategyByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTAStrategyByJobResponse> CancelOTAStrategyByJobWithOptionsAsync(CancelOTAStrategyByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTAStrategyByJobResponse>(await DoRequestAsync("CancelOTAStrategyByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTAStrategyByJobResponse CancelOTAStrategyByJob(CancelOTAStrategyByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTAStrategyByJobWithOptions(request, runtime);
        }

        public async Task<CancelOTAStrategyByJobResponse> CancelOTAStrategyByJobAsync(CancelOTAStrategyByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTAStrategyByJobWithOptionsAsync(request, runtime);
        }

        public CancelOTATaskByDeviceResponse CancelOTATaskByDeviceWithOptions(CancelOTATaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByDeviceResponse>(DoRequest("CancelOTATaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTATaskByDeviceResponse> CancelOTATaskByDeviceWithOptionsAsync(CancelOTATaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByDeviceResponse>(await DoRequestAsync("CancelOTATaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTATaskByDeviceResponse CancelOTATaskByDevice(CancelOTATaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTATaskByDeviceWithOptions(request, runtime);
        }

        public async Task<CancelOTATaskByDeviceResponse> CancelOTATaskByDeviceAsync(CancelOTATaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTATaskByDeviceWithOptionsAsync(request, runtime);
        }

        public CancelOTATaskByJobResponse CancelOTATaskByJobWithOptions(CancelOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByJobResponse>(DoRequest("CancelOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTATaskByJobResponse> CancelOTATaskByJobWithOptionsAsync(CancelOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByJobResponse>(await DoRequestAsync("CancelOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTATaskByJobResponse CancelOTATaskByJob(CancelOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTATaskByJobWithOptions(request, runtime);
        }

        public async Task<CancelOTATaskByJobResponse> CancelOTATaskByJobAsync(CancelOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTATaskByJobWithOptionsAsync(request, runtime);
        }

        public CancelReleaseProductResponse CancelReleaseProductWithOptions(CancelReleaseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelReleaseProductResponse>(DoRequest("CancelReleaseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelReleaseProductResponse> CancelReleaseProductWithOptionsAsync(CancelReleaseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelReleaseProductResponse>(await DoRequestAsync("CancelReleaseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelReleaseProductResponse CancelReleaseProduct(CancelReleaseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelReleaseProductWithOptions(request, runtime);
        }

        public async Task<CancelReleaseProductResponse> CancelReleaseProductAsync(CancelReleaseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelReleaseProductWithOptionsAsync(request, runtime);
        }

        public CheckBindLicenseDeviceProgressResponse CheckBindLicenseDeviceProgressWithOptions(CheckBindLicenseDeviceProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckBindLicenseDeviceProgressResponse>(DoRequest("CheckBindLicenseDeviceProgress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckBindLicenseDeviceProgressResponse> CheckBindLicenseDeviceProgressWithOptionsAsync(CheckBindLicenseDeviceProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckBindLicenseDeviceProgressResponse>(await DoRequestAsync("CheckBindLicenseDeviceProgress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CheckBindLicenseDeviceProgressResponse CheckBindLicenseDeviceProgress(CheckBindLicenseDeviceProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckBindLicenseDeviceProgressWithOptions(request, runtime);
        }

        public async Task<CheckBindLicenseDeviceProgressResponse> CheckBindLicenseDeviceProgressAsync(CheckBindLicenseDeviceProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckBindLicenseDeviceProgressWithOptionsAsync(request, runtime);
        }

        public ClearDeviceDesiredPropertyResponse ClearDeviceDesiredPropertyWithOptions(ClearDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearDeviceDesiredPropertyResponse>(DoRequest("ClearDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ClearDeviceDesiredPropertyResponse> ClearDeviceDesiredPropertyWithOptionsAsync(ClearDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearDeviceDesiredPropertyResponse>(await DoRequestAsync("ClearDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ClearDeviceDesiredPropertyResponse ClearDeviceDesiredProperty(ClearDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearDeviceDesiredPropertyWithOptions(request, runtime);
        }

        public async Task<ClearDeviceDesiredPropertyResponse> ClearDeviceDesiredPropertyAsync(ClearDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearDeviceDesiredPropertyWithOptionsAsync(request, runtime);
        }

        public ClearEdgeInstanceDriverConfigsResponse ClearEdgeInstanceDriverConfigsWithOptions(ClearEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearEdgeInstanceDriverConfigsResponse>(DoRequest("ClearEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ClearEdgeInstanceDriverConfigsResponse> ClearEdgeInstanceDriverConfigsWithOptionsAsync(ClearEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("ClearEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ClearEdgeInstanceDriverConfigsResponse ClearEdgeInstanceDriverConfigs(ClearEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<ClearEdgeInstanceDriverConfigsResponse> ClearEdgeInstanceDriverConfigsAsync(ClearEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public CloseDeviceTunnelResponse CloseDeviceTunnelWithOptions(CloseDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseDeviceTunnelResponse>(DoRequest("CloseDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CloseDeviceTunnelResponse> CloseDeviceTunnelWithOptionsAsync(CloseDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseDeviceTunnelResponse>(await DoRequestAsync("CloseDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CloseDeviceTunnelResponse CloseDeviceTunnel(CloseDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<CloseDeviceTunnelResponse> CloseDeviceTunnelAsync(CloseDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public CloseEdgeInstanceDeploymentResponse CloseEdgeInstanceDeploymentWithOptions(CloseEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseEdgeInstanceDeploymentResponse>(DoRequest("CloseEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CloseEdgeInstanceDeploymentResponse> CloseEdgeInstanceDeploymentWithOptionsAsync(CloseEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseEdgeInstanceDeploymentResponse>(await DoRequestAsync("CloseEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CloseEdgeInstanceDeploymentResponse CloseEdgeInstanceDeployment(CloseEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<CloseEdgeInstanceDeploymentResponse> CloseEdgeInstanceDeploymentAsync(CloseEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public ConfirmOTATaskResponse ConfirmOTATaskWithOptions(ConfirmOTATaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfirmOTATaskResponse>(DoRequest("ConfirmOTATask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ConfirmOTATaskResponse> ConfirmOTATaskWithOptionsAsync(ConfirmOTATaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ConfirmOTATaskResponse>(await DoRequestAsync("ConfirmOTATask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ConfirmOTATaskResponse ConfirmOTATask(ConfirmOTATaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmOTATaskWithOptions(request, runtime);
        }

        public async Task<ConfirmOTATaskResponse> ConfirmOTATaskAsync(ConfirmOTATaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmOTATaskWithOptionsAsync(request, runtime);
        }

        public CopyThingModelResponse CopyThingModelWithOptions(CopyThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyThingModelResponse>(DoRequest("CopyThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CopyThingModelResponse> CopyThingModelWithOptionsAsync(CopyThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyThingModelResponse>(await DoRequestAsync("CopyThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CopyThingModelResponse CopyThingModel(CopyThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyThingModelWithOptions(request, runtime);
        }

        public async Task<CopyThingModelResponse> CopyThingModelAsync(CopyThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyThingModelWithOptionsAsync(request, runtime);
        }

        public CountSpeechBroadcastHourResponse CountSpeechBroadcastHourWithOptions(CountSpeechBroadcastHourRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CountSpeechBroadcastHourResponse>(DoRequest("CountSpeechBroadcastHour", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CountSpeechBroadcastHourResponse> CountSpeechBroadcastHourWithOptionsAsync(CountSpeechBroadcastHourRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CountSpeechBroadcastHourResponse>(await DoRequestAsync("CountSpeechBroadcastHour", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CountSpeechBroadcastHourResponse CountSpeechBroadcastHour(CountSpeechBroadcastHourRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CountSpeechBroadcastHourWithOptions(request, runtime);
        }

        public async Task<CountSpeechBroadcastHourResponse> CountSpeechBroadcastHourAsync(CountSpeechBroadcastHourRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CountSpeechBroadcastHourWithOptionsAsync(request, runtime);
        }

        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupResponse>(DoRequest("CreateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await DoRequestAsync("CreateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupWithOptions(request, runtime);
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupWithOptionsAsync(request, runtime);
        }

        public CreateConsumerGroupSubscribeRelationResponse CreateConsumerGroupSubscribeRelationWithOptions(CreateConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupSubscribeRelationResponse>(DoRequest("CreateConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateConsumerGroupSubscribeRelationResponse> CreateConsumerGroupSubscribeRelationWithOptionsAsync(CreateConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupSubscribeRelationResponse>(await DoRequestAsync("CreateConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateConsumerGroupSubscribeRelationResponse CreateConsumerGroupSubscribeRelation(CreateConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<CreateConsumerGroupSubscribeRelationResponse> CreateConsumerGroupSubscribeRelationAsync(CreateConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public CreateDataAPIServiceResponse CreateDataAPIServiceWithOptions(CreateDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataAPIServiceResponse>(DoRequest("CreateDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataAPIServiceResponse> CreateDataAPIServiceWithOptionsAsync(CreateDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataAPIServiceResponse>(await DoRequestAsync("CreateDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataAPIServiceResponse CreateDataAPIService(CreateDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataAPIServiceWithOptions(request, runtime);
        }

        public async Task<CreateDataAPIServiceResponse> CreateDataAPIServiceAsync(CreateDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataAPIServiceWithOptionsAsync(request, runtime);
        }

        public CreateDataSourceItemResponse CreateDataSourceItemWithOptions(CreateDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataSourceItemResponse>(DoRequest("CreateDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataSourceItemResponse> CreateDataSourceItemWithOptionsAsync(CreateDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataSourceItemResponse>(await DoRequestAsync("CreateDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataSourceItemResponse CreateDataSourceItem(CreateDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceItemWithOptions(request, runtime);
        }

        public async Task<CreateDataSourceItemResponse> CreateDataSourceItemAsync(CreateDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceItemWithOptionsAsync(request, runtime);
        }

        public CreateDestinationResponse CreateDestinationWithOptions(CreateDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDestinationResponse>(DoRequest("CreateDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDestinationResponse> CreateDestinationWithOptionsAsync(CreateDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDestinationResponse>(await DoRequestAsync("CreateDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDestinationResponse CreateDestination(CreateDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDestinationWithOptions(request, runtime);
        }

        public async Task<CreateDestinationResponse> CreateDestinationAsync(CreateDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDestinationWithOptionsAsync(request, runtime);
        }

        public CreateDeviceDistributeJobResponse CreateDeviceDistributeJobWithOptions(CreateDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDistributeJobResponse>(DoRequest("CreateDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceDistributeJobResponse> CreateDeviceDistributeJobWithOptionsAsync(CreateDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDistributeJobResponse>(await DoRequestAsync("CreateDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceDistributeJobResponse CreateDeviceDistributeJob(CreateDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<CreateDeviceDistributeJobResponse> CreateDeviceDistributeJobAsync(CreateDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public CreateDeviceDynamicGroupResponse CreateDeviceDynamicGroupWithOptions(CreateDeviceDynamicGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDynamicGroupResponse>(DoRequest("CreateDeviceDynamicGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceDynamicGroupResponse> CreateDeviceDynamicGroupWithOptionsAsync(CreateDeviceDynamicGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDynamicGroupResponse>(await DoRequestAsync("CreateDeviceDynamicGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceDynamicGroupResponse CreateDeviceDynamicGroup(CreateDeviceDynamicGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceDynamicGroupWithOptions(request, runtime);
        }

        public async Task<CreateDeviceDynamicGroupResponse> CreateDeviceDynamicGroupAsync(CreateDeviceDynamicGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceDynamicGroupWithOptionsAsync(request, runtime);
        }

        public CreateDeviceGroupResponse CreateDeviceGroupWithOptions(CreateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceGroupResponse>(DoRequest("CreateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceGroupResponse> CreateDeviceGroupWithOptionsAsync(CreateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceGroupResponse>(await DoRequestAsync("CreateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceGroupResponse CreateDeviceGroup(CreateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceGroupWithOptions(request, runtime);
        }

        public async Task<CreateDeviceGroupResponse> CreateDeviceGroupAsync(CreateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceGroupWithOptionsAsync(request, runtime);
        }

        public CreateDeviceTunnelResponse CreateDeviceTunnelWithOptions(CreateDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceTunnelResponse>(DoRequest("CreateDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceTunnelResponse> CreateDeviceTunnelWithOptionsAsync(CreateDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceTunnelResponse>(await DoRequestAsync("CreateDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceTunnelResponse CreateDeviceTunnel(CreateDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<CreateDeviceTunnelResponse> CreateDeviceTunnelAsync(CreateDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public CreateDownloadDataJobResponse CreateDownloadDataJobWithOptions(CreateDownloadDataJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateDownloadDataJobShrinkRequest request = new CreateDownloadDataJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Context))
            {
                request.ContextShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Context);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.FileConfig))
            {
                request.FileConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.FileConfig);
            }
            return TeaModel.ToObject<CreateDownloadDataJobResponse>(DoRequest("CreateDownloadDataJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDownloadDataJobResponse> CreateDownloadDataJobWithOptionsAsync(CreateDownloadDataJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateDownloadDataJobShrinkRequest request = new CreateDownloadDataJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Context))
            {
                request.ContextShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Context);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.FileConfig))
            {
                request.FileConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.FileConfig);
            }
            return TeaModel.ToObject<CreateDownloadDataJobResponse>(await DoRequestAsync("CreateDownloadDataJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDownloadDataJobResponse CreateDownloadDataJob(CreateDownloadDataJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDownloadDataJobWithOptions(request, runtime);
        }

        public async Task<CreateDownloadDataJobResponse> CreateDownloadDataJobAsync(CreateDownloadDataJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDownloadDataJobWithOptionsAsync(request, runtime);
        }

        public CreateEdgeDriverResponse CreateEdgeDriverWithOptions(CreateEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverResponse>(DoRequest("CreateEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeDriverResponse> CreateEdgeDriverWithOptionsAsync(CreateEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverResponse>(await DoRequestAsync("CreateEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeDriverResponse CreateEdgeDriver(CreateEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeDriverWithOptions(request, runtime);
        }

        public async Task<CreateEdgeDriverResponse> CreateEdgeDriverAsync(CreateEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeDriverWithOptionsAsync(request, runtime);
        }

        public CreateEdgeDriverVersionResponse CreateEdgeDriverVersionWithOptions(CreateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverVersionResponse>(DoRequest("CreateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeDriverVersionResponse> CreateEdgeDriverVersionWithOptionsAsync(CreateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverVersionResponse>(await DoRequestAsync("CreateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeDriverVersionResponse CreateEdgeDriverVersion(CreateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<CreateEdgeDriverVersionResponse> CreateEdgeDriverVersionAsync(CreateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceResponse CreateEdgeInstanceWithOptions(CreateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceResponse>(DoRequest("CreateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceResponse> CreateEdgeInstanceWithOptionsAsync(CreateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceResponse>(await DoRequestAsync("CreateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceResponse CreateEdgeInstance(CreateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceResponse> CreateEdgeInstanceAsync(CreateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceChannelResponse CreateEdgeInstanceChannelWithOptions(CreateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceChannelResponse>(DoRequest("CreateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceChannelResponse> CreateEdgeInstanceChannelWithOptionsAsync(CreateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceChannelResponse>(await DoRequestAsync("CreateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceChannelResponse CreateEdgeInstanceChannel(CreateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceChannelResponse> CreateEdgeInstanceChannelAsync(CreateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceDeploymentResponse CreateEdgeInstanceDeploymentWithOptions(CreateEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceDeploymentResponse>(DoRequest("CreateEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceDeploymentResponse> CreateEdgeInstanceDeploymentWithOptionsAsync(CreateEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceDeploymentResponse>(await DoRequestAsync("CreateEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceDeploymentResponse CreateEdgeInstanceDeployment(CreateEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceDeploymentResponse> CreateEdgeInstanceDeploymentAsync(CreateEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceMessageRoutingResponse CreateEdgeInstanceMessageRoutingWithOptions(CreateEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceMessageRoutingResponse>(DoRequest("CreateEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceMessageRoutingResponse> CreateEdgeInstanceMessageRoutingWithOptionsAsync(CreateEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceMessageRoutingResponse>(await DoRequestAsync("CreateEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceMessageRoutingResponse CreateEdgeInstanceMessageRouting(CreateEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceMessageRoutingWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceMessageRoutingResponse> CreateEdgeInstanceMessageRoutingAsync(CreateEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceMessageRoutingWithOptionsAsync(request, runtime);
        }

        public CreateEdgeOssPreSignedAddressResponse CreateEdgeOssPreSignedAddressWithOptions(CreateEdgeOssPreSignedAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeOssPreSignedAddressResponse>(DoRequest("CreateEdgeOssPreSignedAddress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeOssPreSignedAddressResponse> CreateEdgeOssPreSignedAddressWithOptionsAsync(CreateEdgeOssPreSignedAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeOssPreSignedAddressResponse>(await DoRequestAsync("CreateEdgeOssPreSignedAddress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeOssPreSignedAddressResponse CreateEdgeOssPreSignedAddress(CreateEdgeOssPreSignedAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeOssPreSignedAddressWithOptions(request, runtime);
        }

        public async Task<CreateEdgeOssPreSignedAddressResponse> CreateEdgeOssPreSignedAddressAsync(CreateEdgeOssPreSignedAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeOssPreSignedAddressWithOptionsAsync(request, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.JobFile))
            {
                request.JobFileShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.JobFile);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TargetConfig))
            {
                request.TargetConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TargetConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            return TeaModel.ToObject<CreateJobResponse>(DoRequest("CreateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.JobFile))
            {
                request.JobFileShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.JobFile);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TargetConfig))
            {
                request.TargetConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TargetConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            return TeaModel.ToObject<CreateJobResponse>(await DoRequestAsync("CreateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        public CreateLoRaNodesTaskResponse CreateLoRaNodesTaskWithOptions(CreateLoRaNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLoRaNodesTaskResponse>(DoRequest("CreateLoRaNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateLoRaNodesTaskResponse> CreateLoRaNodesTaskWithOptionsAsync(CreateLoRaNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLoRaNodesTaskResponse>(await DoRequestAsync("CreateLoRaNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateLoRaNodesTaskResponse CreateLoRaNodesTask(CreateLoRaNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoRaNodesTaskWithOptions(request, runtime);
        }

        public async Task<CreateLoRaNodesTaskResponse> CreateLoRaNodesTaskAsync(CreateLoRaNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoRaNodesTaskWithOptionsAsync(request, runtime);
        }

        public CreateOTADynamicUpgradeJobResponse CreateOTADynamicUpgradeJobWithOptions(CreateOTADynamicUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTADynamicUpgradeJobResponse>(DoRequest("CreateOTADynamicUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTADynamicUpgradeJobResponse> CreateOTADynamicUpgradeJobWithOptionsAsync(CreateOTADynamicUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTADynamicUpgradeJobResponse>(await DoRequestAsync("CreateOTADynamicUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTADynamicUpgradeJobResponse CreateOTADynamicUpgradeJob(CreateOTADynamicUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTADynamicUpgradeJobWithOptions(request, runtime);
        }

        public async Task<CreateOTADynamicUpgradeJobResponse> CreateOTADynamicUpgradeJobAsync(CreateOTADynamicUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTADynamicUpgradeJobWithOptionsAsync(request, runtime);
        }

        public CreateOTAFirmwareResponse CreateOTAFirmwareWithOptions(CreateOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAFirmwareResponse>(DoRequest("CreateOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAFirmwareResponse> CreateOTAFirmwareWithOptionsAsync(CreateOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAFirmwareResponse>(await DoRequestAsync("CreateOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAFirmwareResponse CreateOTAFirmware(CreateOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<CreateOTAFirmwareResponse> CreateOTAFirmwareAsync(CreateOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public CreateOTAModuleResponse CreateOTAModuleWithOptions(CreateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAModuleResponse>(DoRequest("CreateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAModuleResponse> CreateOTAModuleWithOptionsAsync(CreateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAModuleResponse>(await DoRequestAsync("CreateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAModuleResponse CreateOTAModule(CreateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAModuleWithOptions(request, runtime);
        }

        public async Task<CreateOTAModuleResponse> CreateOTAModuleAsync(CreateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAModuleWithOptionsAsync(request, runtime);
        }

        public CreateOTAStaticUpgradeJobResponse CreateOTAStaticUpgradeJobWithOptions(CreateOTAStaticUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAStaticUpgradeJobResponse>(DoRequest("CreateOTAStaticUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAStaticUpgradeJobResponse> CreateOTAStaticUpgradeJobWithOptionsAsync(CreateOTAStaticUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAStaticUpgradeJobResponse>(await DoRequestAsync("CreateOTAStaticUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAStaticUpgradeJobResponse CreateOTAStaticUpgradeJob(CreateOTAStaticUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAStaticUpgradeJobWithOptions(request, runtime);
        }

        public async Task<CreateOTAStaticUpgradeJobResponse> CreateOTAStaticUpgradeJobAsync(CreateOTAStaticUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAStaticUpgradeJobWithOptionsAsync(request, runtime);
        }

        public CreateOTAVerifyJobResponse CreateOTAVerifyJobWithOptions(CreateOTAVerifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAVerifyJobResponse>(DoRequest("CreateOTAVerifyJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAVerifyJobResponse> CreateOTAVerifyJobWithOptionsAsync(CreateOTAVerifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAVerifyJobResponse>(await DoRequestAsync("CreateOTAVerifyJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAVerifyJobResponse CreateOTAVerifyJob(CreateOTAVerifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAVerifyJobWithOptions(request, runtime);
        }

        public async Task<CreateOTAVerifyJobResponse> CreateOTAVerifyJobAsync(CreateOTAVerifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAVerifyJobWithOptionsAsync(request, runtime);
        }

        public CreateParserResponse CreateParserWithOptions(CreateParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateParserResponse>(DoRequest("CreateParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateParserResponse> CreateParserWithOptionsAsync(CreateParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateParserResponse>(await DoRequestAsync("CreateParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateParserResponse CreateParser(CreateParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParserWithOptions(request, runtime);
        }

        public async Task<CreateParserResponse> CreateParserAsync(CreateParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParserWithOptionsAsync(request, runtime);
        }

        public CreateParserDataSourceResponse CreateParserDataSourceWithOptions(CreateParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateParserDataSourceResponse>(DoRequest("CreateParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateParserDataSourceResponse> CreateParserDataSourceWithOptionsAsync(CreateParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateParserDataSourceResponse>(await DoRequestAsync("CreateParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateParserDataSourceResponse CreateParserDataSource(CreateParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParserDataSourceWithOptions(request, runtime);
        }

        public async Task<CreateParserDataSourceResponse> CreateParserDataSourceAsync(CreateParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParserDataSourceWithOptionsAsync(request, runtime);
        }

        public CreateProductResponse CreateProductWithOptions(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductResponse>(DoRequest("CreateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductResponse> CreateProductWithOptionsAsync(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductResponse>(await DoRequestAsync("CreateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductWithOptions(request, runtime);
        }

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductWithOptionsAsync(request, runtime);
        }

        public CreateProductDistributeJobResponse CreateProductDistributeJobWithOptions(CreateProductDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductDistributeJobResponse>(DoRequest("CreateProductDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductDistributeJobResponse> CreateProductDistributeJobWithOptionsAsync(CreateProductDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductDistributeJobResponse>(await DoRequestAsync("CreateProductDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductDistributeJobResponse CreateProductDistributeJob(CreateProductDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductDistributeJobWithOptions(request, runtime);
        }

        public async Task<CreateProductDistributeJobResponse> CreateProductDistributeJobAsync(CreateProductDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductDistributeJobWithOptionsAsync(request, runtime);
        }

        public CreateProductTagsResponse CreateProductTagsWithOptions(CreateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTagsResponse>(DoRequest("CreateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductTagsResponse> CreateProductTagsWithOptionsAsync(CreateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTagsResponse>(await DoRequestAsync("CreateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductTagsResponse CreateProductTags(CreateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductTagsWithOptions(request, runtime);
        }

        public async Task<CreateProductTagsResponse> CreateProductTagsAsync(CreateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductTagsWithOptionsAsync(request, runtime);
        }

        public CreateProductTopicResponse CreateProductTopicWithOptions(CreateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTopicResponse>(DoRequest("CreateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductTopicResponse> CreateProductTopicWithOptionsAsync(CreateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTopicResponse>(await DoRequestAsync("CreateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductTopicResponse CreateProductTopic(CreateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductTopicWithOptions(request, runtime);
        }

        public async Task<CreateProductTopicResponse> CreateProductTopicAsync(CreateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductTopicWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleResponse>(DoRequest("CreateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleResponse>(await DoRequestAsync("CreateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        public CreateRuleActionResponse CreateRuleActionWithOptions(CreateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleActionResponse>(DoRequest("CreateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRuleActionResponse> CreateRuleActionWithOptionsAsync(CreateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleActionResponse>(await DoRequestAsync("CreateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateRuleActionResponse CreateRuleAction(CreateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleActionWithOptions(request, runtime);
        }

        public async Task<CreateRuleActionResponse> CreateRuleActionAsync(CreateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleActionWithOptionsAsync(request, runtime);
        }

        public CreateSceneRuleResponse CreateSceneRuleWithOptions(CreateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneRuleResponse>(DoRequest("CreateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSceneRuleResponse> CreateSceneRuleWithOptionsAsync(CreateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneRuleResponse>(await DoRequestAsync("CreateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSceneRuleResponse CreateSceneRule(CreateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSceneRuleWithOptions(request, runtime);
        }

        public async Task<CreateSceneRuleResponse> CreateSceneRuleAsync(CreateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSceneRuleWithOptionsAsync(request, runtime);
        }

        public CreateSchedulePeriodResponse CreateSchedulePeriodWithOptions(CreateSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSchedulePeriodResponse>(DoRequest("CreateSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSchedulePeriodResponse> CreateSchedulePeriodWithOptionsAsync(CreateSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSchedulePeriodResponse>(await DoRequestAsync("CreateSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSchedulePeriodResponse CreateSchedulePeriod(CreateSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchedulePeriodWithOptions(request, runtime);
        }

        public async Task<CreateSchedulePeriodResponse> CreateSchedulePeriodAsync(CreateSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchedulePeriodWithOptionsAsync(request, runtime);
        }

        public CreateSoundCodeResponse CreateSoundCodeWithOptions(CreateSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeResponse>(DoRequest("CreateSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSoundCodeResponse> CreateSoundCodeWithOptionsAsync(CreateSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeResponse>(await DoRequestAsync("CreateSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSoundCodeResponse CreateSoundCode(CreateSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSoundCodeWithOptions(request, runtime);
        }

        public async Task<CreateSoundCodeResponse> CreateSoundCodeAsync(CreateSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSoundCodeWithOptionsAsync(request, runtime);
        }

        public CreateSoundCodeLabelResponse CreateSoundCodeLabelWithOptions(CreateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeLabelResponse>(DoRequest("CreateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSoundCodeLabelResponse> CreateSoundCodeLabelWithOptionsAsync(CreateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeLabelResponse>(await DoRequestAsync("CreateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSoundCodeLabelResponse CreateSoundCodeLabel(CreateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSoundCodeLabelWithOptions(request, runtime);
        }

        public async Task<CreateSoundCodeLabelResponse> CreateSoundCodeLabelAsync(CreateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSoundCodeLabelWithOptionsAsync(request, runtime);
        }

        public CreateSoundCodeScheduleResponse CreateSoundCodeScheduleWithOptions(CreateSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeScheduleResponse>(DoRequest("CreateSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSoundCodeScheduleResponse> CreateSoundCodeScheduleWithOptionsAsync(CreateSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSoundCodeScheduleResponse>(await DoRequestAsync("CreateSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSoundCodeScheduleResponse CreateSoundCodeSchedule(CreateSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSoundCodeScheduleWithOptions(request, runtime);
        }

        public async Task<CreateSoundCodeScheduleResponse> CreateSoundCodeScheduleAsync(CreateSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSoundCodeScheduleWithOptionsAsync(request, runtime);
        }

        public CreateSpeechResponse CreateSpeechWithOptions(CreateSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateSpeechShrinkRequest request = new CreateSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<CreateSpeechResponse>(DoRequest("CreateSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSpeechResponse> CreateSpeechWithOptionsAsync(CreateSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateSpeechShrinkRequest request = new CreateSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<CreateSpeechResponse>(await DoRequestAsync("CreateSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSpeechResponse CreateSpeech(CreateSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSpeechWithOptions(request, runtime);
        }

        public async Task<CreateSpeechResponse> CreateSpeechAsync(CreateSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSpeechWithOptionsAsync(request, runtime);
        }

        public CreateStudioAppDomainOpenResponse CreateStudioAppDomainOpenWithOptions(CreateStudioAppDomainOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateStudioAppDomainOpenResponse>(DoRequest("CreateStudioAppDomainOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateStudioAppDomainOpenResponse> CreateStudioAppDomainOpenWithOptionsAsync(CreateStudioAppDomainOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateStudioAppDomainOpenResponse>(await DoRequestAsync("CreateStudioAppDomainOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateStudioAppDomainOpenResponse CreateStudioAppDomainOpen(CreateStudioAppDomainOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStudioAppDomainOpenWithOptions(request, runtime);
        }

        public async Task<CreateStudioAppDomainOpenResponse> CreateStudioAppDomainOpenAsync(CreateStudioAppDomainOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStudioAppDomainOpenWithOptionsAsync(request, runtime);
        }

        public CreateSubscribeRelationResponse CreateSubscribeRelationWithOptions(CreateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSubscribeRelationResponse>(DoRequest("CreateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSubscribeRelationResponse> CreateSubscribeRelationWithOptionsAsync(CreateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSubscribeRelationResponse>(await DoRequestAsync("CreateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSubscribeRelationResponse CreateSubscribeRelation(CreateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<CreateSubscribeRelationResponse> CreateSubscribeRelationAsync(CreateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public CreateThingModelResponse CreateThingModelWithOptions(CreateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingModelResponse>(DoRequest("CreateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateThingModelResponse> CreateThingModelWithOptionsAsync(CreateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingModelResponse>(await DoRequestAsync("CreateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateThingModelResponse CreateThingModel(CreateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThingModelWithOptions(request, runtime);
        }

        public async Task<CreateThingModelResponse> CreateThingModelAsync(CreateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThingModelWithOptionsAsync(request, runtime);
        }

        public CreateThingScriptResponse CreateThingScriptWithOptions(CreateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingScriptResponse>(DoRequest("CreateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateThingScriptResponse> CreateThingScriptWithOptionsAsync(CreateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingScriptResponse>(await DoRequestAsync("CreateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateThingScriptResponse CreateThingScript(CreateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThingScriptWithOptions(request, runtime);
        }

        public async Task<CreateThingScriptResponse> CreateThingScriptAsync(CreateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThingScriptWithOptionsAsync(request, runtime);
        }

        public CreateTopicRouteTableResponse CreateTopicRouteTableWithOptions(CreateTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTopicRouteTableResponse>(DoRequest("CreateTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateTopicRouteTableResponse> CreateTopicRouteTableWithOptionsAsync(CreateTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTopicRouteTableResponse>(await DoRequestAsync("CreateTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateTopicRouteTableResponse CreateTopicRouteTable(CreateTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<CreateTopicRouteTableResponse> CreateTopicRouteTableAsync(CreateTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public DeleteClientIdsResponse DeleteClientIdsWithOptions(DeleteClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClientIdsResponse>(DoRequest("DeleteClientIds", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteClientIdsResponse> DeleteClientIdsWithOptionsAsync(DeleteClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClientIdsResponse>(await DoRequestAsync("DeleteClientIds", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteClientIdsResponse DeleteClientIds(DeleteClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientIdsWithOptions(request, runtime);
        }

        public async Task<DeleteClientIdsResponse> DeleteClientIdsAsync(DeleteClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientIdsWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(DoRequest("DeleteConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await DoRequestAsync("DeleteConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerGroupSubscribeRelationResponse DeleteConsumerGroupSubscribeRelationWithOptions(DeleteConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupSubscribeRelationResponse>(DoRequest("DeleteConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConsumerGroupSubscribeRelationResponse> DeleteConsumerGroupSubscribeRelationWithOptionsAsync(DeleteConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupSubscribeRelationResponse>(await DoRequestAsync("DeleteConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConsumerGroupSubscribeRelationResponse DeleteConsumerGroupSubscribeRelation(DeleteConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerGroupSubscribeRelationResponse> DeleteConsumerGroupSubscribeRelationAsync(DeleteConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceItemResponse DeleteDataSourceItemWithOptions(DeleteDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceItemResponse>(DoRequest("DeleteDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDataSourceItemResponse> DeleteDataSourceItemWithOptionsAsync(DeleteDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceItemResponse>(await DoRequestAsync("DeleteDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDataSourceItemResponse DeleteDataSourceItem(DeleteDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceItemWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceItemResponse> DeleteDataSourceItemAsync(DeleteDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceItemWithOptionsAsync(request, runtime);
        }

        public DeleteDestinationResponse DeleteDestinationWithOptions(DeleteDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDestinationResponse>(DoRequest("DeleteDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDestinationResponse> DeleteDestinationWithOptionsAsync(DeleteDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDestinationResponse>(await DoRequestAsync("DeleteDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDestinationWithOptions(request, runtime);
        }

        public async Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDestinationWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRequest("DeleteDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRequestAsync("DeleteDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceDistributeJobResponse DeleteDeviceDistributeJobWithOptions(DeleteDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDistributeJobResponse>(DoRequest("DeleteDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceDistributeJobResponse> DeleteDeviceDistributeJobWithOptionsAsync(DeleteDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDistributeJobResponse>(await DoRequestAsync("DeleteDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceDistributeJobResponse DeleteDeviceDistributeJob(DeleteDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceDistributeJobResponse> DeleteDeviceDistributeJobAsync(DeleteDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceDynamicGroupResponse DeleteDeviceDynamicGroupWithOptions(DeleteDeviceDynamicGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDynamicGroupResponse>(DoRequest("DeleteDeviceDynamicGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceDynamicGroupResponse> DeleteDeviceDynamicGroupWithOptionsAsync(DeleteDeviceDynamicGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDynamicGroupResponse>(await DoRequestAsync("DeleteDeviceDynamicGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceDynamicGroupResponse DeleteDeviceDynamicGroup(DeleteDeviceDynamicGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceDynamicGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceDynamicGroupResponse> DeleteDeviceDynamicGroupAsync(DeleteDeviceDynamicGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceDynamicGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceFileResponse DeleteDeviceFileWithOptions(DeleteDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceFileResponse>(DoRequest("DeleteDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceFileResponse> DeleteDeviceFileWithOptionsAsync(DeleteDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceFileResponse>(await DoRequestAsync("DeleteDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceFileResponse DeleteDeviceFile(DeleteDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceFileWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceFileResponse> DeleteDeviceFileAsync(DeleteDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceFileWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceGroupResponse DeleteDeviceGroupWithOptions(DeleteDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceGroupResponse>(DoRequest("DeleteDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupWithOptionsAsync(DeleteDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceGroupResponse>(await DoRequestAsync("DeleteDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceGroupResponse DeleteDeviceGroup(DeleteDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupAsync(DeleteDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDevicePropResponse DeleteDevicePropWithOptions(DeleteDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDevicePropResponse>(DoRequest("DeleteDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDevicePropResponse> DeleteDevicePropWithOptionsAsync(DeleteDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDevicePropResponse>(await DoRequestAsync("DeleteDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDevicePropResponse DeleteDeviceProp(DeleteDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevicePropWithOptions(request, runtime);
        }

        public async Task<DeleteDevicePropResponse> DeleteDevicePropAsync(DeleteDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevicePropWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceSpeechResponse DeleteDeviceSpeechWithOptions(DeleteDeviceSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceSpeechResponse>(DoRequest("DeleteDeviceSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceSpeechResponse> DeleteDeviceSpeechWithOptionsAsync(DeleteDeviceSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceSpeechResponse>(await DoRequestAsync("DeleteDeviceSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceSpeechResponse DeleteDeviceSpeech(DeleteDeviceSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceSpeechWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceSpeechResponse> DeleteDeviceSpeechAsync(DeleteDeviceSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceSpeechWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceTunnelResponse DeleteDeviceTunnelWithOptions(DeleteDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceTunnelResponse>(DoRequest("DeleteDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceTunnelResponse> DeleteDeviceTunnelWithOptionsAsync(DeleteDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceTunnelResponse>(await DoRequestAsync("DeleteDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceTunnelResponse DeleteDeviceTunnel(DeleteDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceTunnelResponse> DeleteDeviceTunnelAsync(DeleteDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeDriverResponse DeleteEdgeDriverWithOptions(DeleteEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverResponse>(DoRequest("DeleteEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeDriverResponse> DeleteEdgeDriverWithOptionsAsync(DeleteEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverResponse>(await DoRequestAsync("DeleteEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeDriverResponse DeleteEdgeDriver(DeleteEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeDriverWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeDriverResponse> DeleteEdgeDriverAsync(DeleteEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeDriverWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeDriverVersionResponse DeleteEdgeDriverVersionWithOptions(DeleteEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverVersionResponse>(DoRequest("DeleteEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeDriverVersionResponse> DeleteEdgeDriverVersionWithOptionsAsync(DeleteEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverVersionResponse>(await DoRequestAsync("DeleteEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeDriverVersionResponse DeleteEdgeDriverVersion(DeleteEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeDriverVersionResponse> DeleteEdgeDriverVersionAsync(DeleteEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeInstanceResponse DeleteEdgeInstanceWithOptions(DeleteEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceResponse>(DoRequest("DeleteEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeInstanceResponse> DeleteEdgeInstanceWithOptionsAsync(DeleteEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceResponse>(await DoRequestAsync("DeleteEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeInstanceResponse DeleteEdgeInstance(DeleteEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeInstanceResponse> DeleteEdgeInstanceAsync(DeleteEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeInstanceMessageRoutingResponse DeleteEdgeInstanceMessageRoutingWithOptions(DeleteEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceMessageRoutingResponse>(DoRequest("DeleteEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeInstanceMessageRoutingResponse> DeleteEdgeInstanceMessageRoutingWithOptionsAsync(DeleteEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceMessageRoutingResponse>(await DoRequestAsync("DeleteEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeInstanceMessageRoutingResponse DeleteEdgeInstanceMessageRouting(DeleteEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeInstanceMessageRoutingWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeInstanceMessageRoutingResponse> DeleteEdgeInstanceMessageRoutingAsync(DeleteEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeInstanceMessageRoutingWithOptionsAsync(request, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteJobResponse>(DoRequest("DeleteJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteJobResponse>(await DoRequestAsync("DeleteJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        public DeleteOTAFirmwareResponse DeleteOTAFirmwareWithOptions(DeleteOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAFirmwareResponse>(DoRequest("DeleteOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteOTAFirmwareResponse> DeleteOTAFirmwareWithOptionsAsync(DeleteOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAFirmwareResponse>(await DoRequestAsync("DeleteOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteOTAFirmwareResponse DeleteOTAFirmware(DeleteOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<DeleteOTAFirmwareResponse> DeleteOTAFirmwareAsync(DeleteOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public DeleteOTAModuleResponse DeleteOTAModuleWithOptions(DeleteOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAModuleResponse>(DoRequest("DeleteOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteOTAModuleResponse> DeleteOTAModuleWithOptionsAsync(DeleteOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAModuleResponse>(await DoRequestAsync("DeleteOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteOTAModuleResponse DeleteOTAModule(DeleteOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOTAModuleWithOptions(request, runtime);
        }

        public async Task<DeleteOTAModuleResponse> DeleteOTAModuleAsync(DeleteOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOTAModuleWithOptionsAsync(request, runtime);
        }

        public DeleteParserResponse DeleteParserWithOptions(DeleteParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteParserResponse>(DoRequest("DeleteParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteParserResponse> DeleteParserWithOptionsAsync(DeleteParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteParserResponse>(await DoRequestAsync("DeleteParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteParserResponse DeleteParser(DeleteParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParserWithOptions(request, runtime);
        }

        public async Task<DeleteParserResponse> DeleteParserAsync(DeleteParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParserWithOptionsAsync(request, runtime);
        }

        public DeleteParserDataSourceResponse DeleteParserDataSourceWithOptions(DeleteParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteParserDataSourceResponse>(DoRequest("DeleteParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteParserDataSourceResponse> DeleteParserDataSourceWithOptionsAsync(DeleteParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteParserDataSourceResponse>(await DoRequestAsync("DeleteParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteParserDataSourceResponse DeleteParserDataSource(DeleteParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteParserDataSourceWithOptions(request, runtime);
        }

        public async Task<DeleteParserDataSourceResponse> DeleteParserDataSourceAsync(DeleteParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteParserDataSourceWithOptionsAsync(request, runtime);
        }

        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(DoRequest("DeleteProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(await DoRequestAsync("DeleteProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductWithOptions(request, runtime);
        }

        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductWithOptionsAsync(request, runtime);
        }

        public DeleteProductTagsResponse DeleteProductTagsWithOptions(DeleteProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTagsResponse>(DoRequest("DeleteProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductTagsResponse> DeleteProductTagsWithOptionsAsync(DeleteProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTagsResponse>(await DoRequestAsync("DeleteProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductTagsResponse DeleteProductTags(DeleteProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductTagsWithOptions(request, runtime);
        }

        public async Task<DeleteProductTagsResponse> DeleteProductTagsAsync(DeleteProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductTagsWithOptionsAsync(request, runtime);
        }

        public DeleteProductTopicResponse DeleteProductTopicWithOptions(DeleteProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTopicResponse>(DoRequest("DeleteProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductTopicResponse> DeleteProductTopicWithOptionsAsync(DeleteProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTopicResponse>(await DoRequestAsync("DeleteProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductTopicResponse DeleteProductTopic(DeleteProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductTopicWithOptions(request, runtime);
        }

        public async Task<DeleteProductTopicResponse> DeleteProductTopicAsync(DeleteProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductTopicWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleResponse>(DoRequest("DeleteRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleResponse>(await DoRequestAsync("DeleteRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        public DeleteRuleActionResponse DeleteRuleActionWithOptions(DeleteRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleActionResponse>(DoRequest("DeleteRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRuleActionResponse> DeleteRuleActionWithOptionsAsync(DeleteRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleActionResponse>(await DoRequestAsync("DeleteRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRuleActionResponse DeleteRuleAction(DeleteRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleActionWithOptions(request, runtime);
        }

        public async Task<DeleteRuleActionResponse> DeleteRuleActionAsync(DeleteRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleActionWithOptionsAsync(request, runtime);
        }

        public DeleteSceneRuleResponse DeleteSceneRuleWithOptions(DeleteSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSceneRuleResponse>(DoRequest("DeleteSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSceneRuleResponse> DeleteSceneRuleWithOptionsAsync(DeleteSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSceneRuleResponse>(await DoRequestAsync("DeleteSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSceneRuleResponse DeleteSceneRule(DeleteSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSceneRuleWithOptions(request, runtime);
        }

        public async Task<DeleteSceneRuleResponse> DeleteSceneRuleAsync(DeleteSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSceneRuleWithOptionsAsync(request, runtime);
        }

        public DeleteSchedulePeriodResponse DeleteSchedulePeriodWithOptions(DeleteSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSchedulePeriodResponse>(DoRequest("DeleteSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSchedulePeriodResponse> DeleteSchedulePeriodWithOptionsAsync(DeleteSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSchedulePeriodResponse>(await DoRequestAsync("DeleteSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSchedulePeriodResponse DeleteSchedulePeriod(DeleteSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchedulePeriodWithOptions(request, runtime);
        }

        public async Task<DeleteSchedulePeriodResponse> DeleteSchedulePeriodAsync(DeleteSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchedulePeriodWithOptionsAsync(request, runtime);
        }

        public DeleteShareTaskDeviceResponse DeleteShareTaskDeviceWithOptions(DeleteShareTaskDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteShareTaskDeviceResponse>(DoRequest("DeleteShareTaskDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteShareTaskDeviceResponse> DeleteShareTaskDeviceWithOptionsAsync(DeleteShareTaskDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteShareTaskDeviceResponse>(await DoRequestAsync("DeleteShareTaskDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteShareTaskDeviceResponse DeleteShareTaskDevice(DeleteShareTaskDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteShareTaskDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteShareTaskDeviceResponse> DeleteShareTaskDeviceAsync(DeleteShareTaskDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteShareTaskDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteSoundCodeResponse DeleteSoundCodeWithOptions(DeleteSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeResponse>(DoRequest("DeleteSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSoundCodeResponse> DeleteSoundCodeWithOptionsAsync(DeleteSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeResponse>(await DoRequestAsync("DeleteSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSoundCodeResponse DeleteSoundCode(DeleteSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSoundCodeWithOptions(request, runtime);
        }

        public async Task<DeleteSoundCodeResponse> DeleteSoundCodeAsync(DeleteSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSoundCodeWithOptionsAsync(request, runtime);
        }

        public DeleteSoundCodeLabelResponse DeleteSoundCodeLabelWithOptions(DeleteSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeLabelResponse>(DoRequest("DeleteSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSoundCodeLabelResponse> DeleteSoundCodeLabelWithOptionsAsync(DeleteSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeLabelResponse>(await DoRequestAsync("DeleteSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSoundCodeLabelResponse DeleteSoundCodeLabel(DeleteSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSoundCodeLabelWithOptions(request, runtime);
        }

        public async Task<DeleteSoundCodeLabelResponse> DeleteSoundCodeLabelAsync(DeleteSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSoundCodeLabelWithOptionsAsync(request, runtime);
        }

        public DeleteSoundCodeScheduleResponse DeleteSoundCodeScheduleWithOptions(DeleteSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeScheduleResponse>(DoRequest("DeleteSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSoundCodeScheduleResponse> DeleteSoundCodeScheduleWithOptionsAsync(DeleteSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSoundCodeScheduleResponse>(await DoRequestAsync("DeleteSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSoundCodeScheduleResponse DeleteSoundCodeSchedule(DeleteSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSoundCodeScheduleWithOptions(request, runtime);
        }

        public async Task<DeleteSoundCodeScheduleResponse> DeleteSoundCodeScheduleAsync(DeleteSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSoundCodeScheduleWithOptionsAsync(request, runtime);
        }

        public DeleteSpeechResponse DeleteSpeechWithOptions(DeleteSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSpeechResponse>(DoRequest("DeleteSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSpeechResponse> DeleteSpeechWithOptionsAsync(DeleteSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSpeechResponse>(await DoRequestAsync("DeleteSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSpeechResponse DeleteSpeech(DeleteSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpeechWithOptions(request, runtime);
        }

        public async Task<DeleteSpeechResponse> DeleteSpeechAsync(DeleteSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpeechWithOptionsAsync(request, runtime);
        }

        public DeleteStudioAppDomainOpenResponse DeleteStudioAppDomainOpenWithOptions(DeleteStudioAppDomainOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteStudioAppDomainOpenResponse>(DoRequest("DeleteStudioAppDomainOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteStudioAppDomainOpenResponse> DeleteStudioAppDomainOpenWithOptionsAsync(DeleteStudioAppDomainOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteStudioAppDomainOpenResponse>(await DoRequestAsync("DeleteStudioAppDomainOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteStudioAppDomainOpenResponse DeleteStudioAppDomainOpen(DeleteStudioAppDomainOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStudioAppDomainOpenWithOptions(request, runtime);
        }

        public async Task<DeleteStudioAppDomainOpenResponse> DeleteStudioAppDomainOpenAsync(DeleteStudioAppDomainOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStudioAppDomainOpenWithOptionsAsync(request, runtime);
        }

        public DeleteSubscribeRelationResponse DeleteSubscribeRelationWithOptions(DeleteSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSubscribeRelationResponse>(DoRequest("DeleteSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSubscribeRelationResponse> DeleteSubscribeRelationWithOptionsAsync(DeleteSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSubscribeRelationResponse>(await DoRequestAsync("DeleteSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSubscribeRelationResponse DeleteSubscribeRelation(DeleteSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<DeleteSubscribeRelationResponse> DeleteSubscribeRelationAsync(DeleteSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public DeleteThingModelResponse DeleteThingModelWithOptions(DeleteThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteThingModelResponse>(DoRequest("DeleteThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteThingModelResponse> DeleteThingModelWithOptionsAsync(DeleteThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteThingModelResponse>(await DoRequestAsync("DeleteThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteThingModelResponse DeleteThingModel(DeleteThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteThingModelWithOptions(request, runtime);
        }

        public async Task<DeleteThingModelResponse> DeleteThingModelAsync(DeleteThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteThingModelWithOptionsAsync(request, runtime);
        }

        public DeleteTopicRouteTableResponse DeleteTopicRouteTableWithOptions(DeleteTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTopicRouteTableResponse>(DoRequest("DeleteTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteTopicRouteTableResponse> DeleteTopicRouteTableWithOptionsAsync(DeleteTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTopicRouteTableResponse>(await DoRequestAsync("DeleteTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteTopicRouteTableResponse DeleteTopicRouteTable(DeleteTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<DeleteTopicRouteTableResponse> DeleteTopicRouteTableAsync(DeleteTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public DetachDestinationResponse DetachDestinationWithOptions(DetachDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachDestinationResponse>(DoRequest("DetachDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DetachDestinationResponse> DetachDestinationWithOptionsAsync(DetachDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachDestinationResponse>(await DoRequestAsync("DetachDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DetachDestinationResponse DetachDestination(DetachDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDestinationWithOptions(request, runtime);
        }

        public async Task<DetachDestinationResponse> DetachDestinationAsync(DetachDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDestinationWithOptionsAsync(request, runtime);
        }

        public DetachParserDataSourceResponse DetachParserDataSourceWithOptions(DetachParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachParserDataSourceResponse>(DoRequest("DetachParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DetachParserDataSourceResponse> DetachParserDataSourceWithOptionsAsync(DetachParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetachParserDataSourceResponse>(await DoRequestAsync("DetachParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DetachParserDataSourceResponse DetachParserDataSource(DetachParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachParserDataSourceWithOptions(request, runtime);
        }

        public async Task<DetachParserDataSourceResponse> DetachParserDataSourceAsync(DetachParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachParserDataSourceWithOptionsAsync(request, runtime);
        }

        public DisableDeviceTunnelResponse DisableDeviceTunnelWithOptions(DisableDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableDeviceTunnelResponse>(DoRequest("DisableDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableDeviceTunnelResponse> DisableDeviceTunnelWithOptionsAsync(DisableDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableDeviceTunnelResponse>(await DoRequestAsync("DisableDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableDeviceTunnelResponse DisableDeviceTunnel(DisableDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<DisableDeviceTunnelResponse> DisableDeviceTunnelAsync(DisableDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public DisableDeviceTunnelShareResponse DisableDeviceTunnelShareWithOptions(DisableDeviceTunnelShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableDeviceTunnelShareResponse>(DoRequest("DisableDeviceTunnelShare", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableDeviceTunnelShareResponse> DisableDeviceTunnelShareWithOptionsAsync(DisableDeviceTunnelShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableDeviceTunnelShareResponse>(await DoRequestAsync("DisableDeviceTunnelShare", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableDeviceTunnelShareResponse DisableDeviceTunnelShare(DisableDeviceTunnelShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDeviceTunnelShareWithOptions(request, runtime);
        }

        public async Task<DisableDeviceTunnelShareResponse> DisableDeviceTunnelShareAsync(DisableDeviceTunnelShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDeviceTunnelShareWithOptionsAsync(request, runtime);
        }

        public DisableSceneRuleResponse DisableSceneRuleWithOptions(DisableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableSceneRuleResponse>(DoRequest("DisableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableSceneRuleResponse> DisableSceneRuleWithOptionsAsync(DisableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableSceneRuleResponse>(await DoRequestAsync("DisableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableSceneRuleResponse DisableSceneRule(DisableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSceneRuleWithOptions(request, runtime);
        }

        public async Task<DisableSceneRuleResponse> DisableSceneRuleAsync(DisableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSceneRuleWithOptionsAsync(request, runtime);
        }

        public DisableThingResponse DisableThingWithOptions(DisableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableThingResponse>(DoRequest("DisableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableThingResponse> DisableThingWithOptionsAsync(DisableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableThingResponse>(await DoRequestAsync("DisableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableThingResponse DisableThing(DisableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableThingWithOptions(request, runtime);
        }

        public async Task<DisableThingResponse> DisableThingAsync(DisableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableThingWithOptionsAsync(request, runtime);
        }

        public EnableDeviceTunnelResponse EnableDeviceTunnelWithOptions(EnableDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableDeviceTunnelResponse>(DoRequest("EnableDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableDeviceTunnelResponse> EnableDeviceTunnelWithOptionsAsync(EnableDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableDeviceTunnelResponse>(await DoRequestAsync("EnableDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableDeviceTunnelResponse EnableDeviceTunnel(EnableDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<EnableDeviceTunnelResponse> EnableDeviceTunnelAsync(EnableDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public EnableDeviceTunnelShareResponse EnableDeviceTunnelShareWithOptions(EnableDeviceTunnelShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableDeviceTunnelShareResponse>(DoRequest("EnableDeviceTunnelShare", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableDeviceTunnelShareResponse> EnableDeviceTunnelShareWithOptionsAsync(EnableDeviceTunnelShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableDeviceTunnelShareResponse>(await DoRequestAsync("EnableDeviceTunnelShare", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableDeviceTunnelShareResponse EnableDeviceTunnelShare(EnableDeviceTunnelShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDeviceTunnelShareWithOptions(request, runtime);
        }

        public async Task<EnableDeviceTunnelShareResponse> EnableDeviceTunnelShareAsync(EnableDeviceTunnelShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDeviceTunnelShareWithOptionsAsync(request, runtime);
        }

        public EnableSceneRuleResponse EnableSceneRuleWithOptions(EnableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableSceneRuleResponse>(DoRequest("EnableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableSceneRuleResponse> EnableSceneRuleWithOptionsAsync(EnableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableSceneRuleResponse>(await DoRequestAsync("EnableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableSceneRuleResponse EnableSceneRule(EnableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSceneRuleWithOptions(request, runtime);
        }

        public async Task<EnableSceneRuleResponse> EnableSceneRuleAsync(EnableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSceneRuleWithOptionsAsync(request, runtime);
        }

        public EnableThingResponse EnableThingWithOptions(EnableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableThingResponse>(DoRequest("EnableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableThingResponse> EnableThingWithOptionsAsync(EnableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableThingResponse>(await DoRequestAsync("EnableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableThingResponse EnableThing(EnableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableThingWithOptions(request, runtime);
        }

        public async Task<EnableThingResponse> EnableThingAsync(EnableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableThingWithOptionsAsync(request, runtime);
        }

        public GenerateDeviceNameListURLResponse GenerateDeviceNameListURLWithOptions(GenerateDeviceNameListURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDeviceNameListURLResponse>(DoRequest("GenerateDeviceNameListURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateDeviceNameListURLResponse> GenerateDeviceNameListURLWithOptionsAsync(GenerateDeviceNameListURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDeviceNameListURLResponse>(await DoRequestAsync("GenerateDeviceNameListURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateDeviceNameListURLResponse GenerateDeviceNameListURL(GenerateDeviceNameListURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDeviceNameListURLWithOptions(request, runtime);
        }

        public async Task<GenerateDeviceNameListURLResponse> GenerateDeviceNameListURLAsync(GenerateDeviceNameListURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDeviceNameListURLWithOptionsAsync(request, runtime);
        }

        public GenerateFileUploadURLResponse GenerateFileUploadURLWithOptions(GenerateFileUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateFileUploadURLResponse>(DoRequest("GenerateFileUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateFileUploadURLResponse> GenerateFileUploadURLWithOptionsAsync(GenerateFileUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateFileUploadURLResponse>(await DoRequestAsync("GenerateFileUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateFileUploadURLResponse GenerateFileUploadURL(GenerateFileUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateFileUploadURLWithOptions(request, runtime);
        }

        public async Task<GenerateFileUploadURLResponse> GenerateFileUploadURLAsync(GenerateFileUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateFileUploadURLWithOptionsAsync(request, runtime);
        }

        public GenerateOTAUploadURLResponse GenerateOTAUploadURLWithOptions(GenerateOTAUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateOTAUploadURLResponse>(DoRequest("GenerateOTAUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateOTAUploadURLResponse> GenerateOTAUploadURLWithOptionsAsync(GenerateOTAUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateOTAUploadURLResponse>(await DoRequestAsync("GenerateOTAUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateOTAUploadURLResponse GenerateOTAUploadURL(GenerateOTAUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOTAUploadURLWithOptions(request, runtime);
        }

        public async Task<GenerateOTAUploadURLResponse> GenerateOTAUploadURLAsync(GenerateOTAUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOTAUploadURLWithOptionsAsync(request, runtime);
        }

        public GetDataAPIServiceDetailResponse GetDataAPIServiceDetailWithOptions(GetDataAPIServiceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataAPIServiceDetailResponse>(DoRequest("GetDataAPIServiceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataAPIServiceDetailResponse> GetDataAPIServiceDetailWithOptionsAsync(GetDataAPIServiceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataAPIServiceDetailResponse>(await DoRequestAsync("GetDataAPIServiceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDataAPIServiceDetailResponse GetDataAPIServiceDetail(GetDataAPIServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataAPIServiceDetailWithOptions(request, runtime);
        }

        public async Task<GetDataAPIServiceDetailResponse> GetDataAPIServiceDetailAsync(GetDataAPIServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataAPIServiceDetailWithOptionsAsync(request, runtime);
        }

        public GetDestinationResponse GetDestinationWithOptions(GetDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDestinationResponse>(DoRequest("GetDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDestinationResponse> GetDestinationWithOptionsAsync(GetDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDestinationResponse>(await DoRequestAsync("GetDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDestinationResponse GetDestination(GetDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDestinationWithOptions(request, runtime);
        }

        public async Task<GetDestinationResponse> GetDestinationAsync(GetDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDestinationWithOptionsAsync(request, runtime);
        }

        public GetDeviceShadowResponse GetDeviceShadowWithOptions(GetDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceShadowResponse>(DoRequest("GetDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceShadowResponse> GetDeviceShadowWithOptionsAsync(GetDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceShadowResponse>(await DoRequestAsync("GetDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceShadowResponse GetDeviceShadow(GetDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceShadowWithOptions(request, runtime);
        }

        public async Task<GetDeviceShadowResponse> GetDeviceShadowAsync(GetDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceShadowWithOptionsAsync(request, runtime);
        }

        public GetDeviceStatusResponse GetDeviceStatusWithOptions(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceStatusResponse>(DoRequest("GetDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusWithOptionsAsync(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceStatusResponse>(await DoRequestAsync("GetDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceStatusResponse GetDeviceStatus(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceStatusWithOptions(request, runtime);
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusAsync(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceStatusWithOptionsAsync(request, runtime);
        }

        public GetDeviceTunnelShareStatusResponse GetDeviceTunnelShareStatusWithOptions(GetDeviceTunnelShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceTunnelShareStatusResponse>(DoRequest("GetDeviceTunnelShareStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceTunnelShareStatusResponse> GetDeviceTunnelShareStatusWithOptionsAsync(GetDeviceTunnelShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceTunnelShareStatusResponse>(await DoRequestAsync("GetDeviceTunnelShareStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceTunnelShareStatusResponse GetDeviceTunnelShareStatus(GetDeviceTunnelShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceTunnelShareStatusWithOptions(request, runtime);
        }

        public async Task<GetDeviceTunnelShareStatusResponse> GetDeviceTunnelShareStatusAsync(GetDeviceTunnelShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceTunnelShareStatusWithOptionsAsync(request, runtime);
        }

        public GetDeviceTunnelStatusResponse GetDeviceTunnelStatusWithOptions(GetDeviceTunnelStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceTunnelStatusResponse>(DoRequest("GetDeviceTunnelStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceTunnelStatusResponse> GetDeviceTunnelStatusWithOptionsAsync(GetDeviceTunnelStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceTunnelStatusResponse>(await DoRequestAsync("GetDeviceTunnelStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceTunnelStatusResponse GetDeviceTunnelStatus(GetDeviceTunnelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceTunnelStatusWithOptions(request, runtime);
        }

        public async Task<GetDeviceTunnelStatusResponse> GetDeviceTunnelStatusAsync(GetDeviceTunnelStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceTunnelStatusWithOptionsAsync(request, runtime);
        }

        public GetDownloadFileResponse GetDownloadFileWithOptions(GetDownloadFileRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetDownloadFileShrinkRequest request = new GetDownloadFileShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Context))
            {
                request.ContextShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Context);
            }
            return TeaModel.ToObject<GetDownloadFileResponse>(DoRequest("GetDownloadFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDownloadFileResponse> GetDownloadFileWithOptionsAsync(GetDownloadFileRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            GetDownloadFileShrinkRequest request = new GetDownloadFileShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Context))
            {
                request.ContextShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Context);
            }
            return TeaModel.ToObject<GetDownloadFileResponse>(await DoRequestAsync("GetDownloadFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDownloadFileResponse GetDownloadFile(GetDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDownloadFileWithOptions(request, runtime);
        }

        public async Task<GetDownloadFileResponse> GetDownloadFileAsync(GetDownloadFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDownloadFileWithOptionsAsync(request, runtime);
        }

        public GetEdgeDriverVersionResponse GetEdgeDriverVersionWithOptions(GetEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeDriverVersionResponse>(DoRequest("GetEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeDriverVersionResponse> GetEdgeDriverVersionWithOptionsAsync(GetEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeDriverVersionResponse>(await DoRequestAsync("GetEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeDriverVersionResponse GetEdgeDriverVersion(GetEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<GetEdgeDriverVersionResponse> GetEdgeDriverVersionAsync(GetEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public GetEdgeInstanceResponse GetEdgeInstanceWithOptions(GetEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceResponse>(DoRequest("GetEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeInstanceResponse> GetEdgeInstanceWithOptionsAsync(GetEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceResponse>(await DoRequestAsync("GetEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeInstanceResponse GetEdgeInstance(GetEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<GetEdgeInstanceResponse> GetEdgeInstanceAsync(GetEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public GetEdgeInstanceDeploymentResponse GetEdgeInstanceDeploymentWithOptions(GetEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceDeploymentResponse>(DoRequest("GetEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeInstanceDeploymentResponse> GetEdgeInstanceDeploymentWithOptionsAsync(GetEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceDeploymentResponse>(await DoRequestAsync("GetEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeInstanceDeploymentResponse GetEdgeInstanceDeployment(GetEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<GetEdgeInstanceDeploymentResponse> GetEdgeInstanceDeploymentAsync(GetEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public GetEdgeInstanceMessageRoutingResponse GetEdgeInstanceMessageRoutingWithOptions(GetEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceMessageRoutingResponse>(DoRequest("GetEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeInstanceMessageRoutingResponse> GetEdgeInstanceMessageRoutingWithOptionsAsync(GetEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceMessageRoutingResponse>(await DoRequestAsync("GetEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeInstanceMessageRoutingResponse GetEdgeInstanceMessageRouting(GetEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeInstanceMessageRoutingWithOptions(request, runtime);
        }

        public async Task<GetEdgeInstanceMessageRoutingResponse> GetEdgeInstanceMessageRoutingAsync(GetEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeInstanceMessageRoutingWithOptionsAsync(request, runtime);
        }

        public GetGatewayBySubDeviceResponse GetGatewayBySubDeviceWithOptions(GetGatewayBySubDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetGatewayBySubDeviceResponse>(DoRequest("GetGatewayBySubDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetGatewayBySubDeviceResponse> GetGatewayBySubDeviceWithOptionsAsync(GetGatewayBySubDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetGatewayBySubDeviceResponse>(await DoRequestAsync("GetGatewayBySubDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetGatewayBySubDeviceResponse GetGatewayBySubDevice(GetGatewayBySubDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGatewayBySubDeviceWithOptions(request, runtime);
        }

        public async Task<GetGatewayBySubDeviceResponse> GetGatewayBySubDeviceAsync(GetGatewayBySubDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGatewayBySubDeviceWithOptionsAsync(request, runtime);
        }

        public GetLoraNodesTaskResponse GetLoraNodesTaskWithOptions(GetLoraNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoraNodesTaskResponse>(DoRequest("GetLoraNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetLoraNodesTaskResponse> GetLoraNodesTaskWithOptionsAsync(GetLoraNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoraNodesTaskResponse>(await DoRequestAsync("GetLoraNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetLoraNodesTaskResponse GetLoraNodesTask(GetLoraNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoraNodesTaskWithOptions(request, runtime);
        }

        public async Task<GetLoraNodesTaskResponse> GetLoraNodesTaskAsync(GetLoraNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoraNodesTaskWithOptionsAsync(request, runtime);
        }

        public GetParserResponse GetParserWithOptions(GetParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParserResponse>(DoRequest("GetParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetParserResponse> GetParserWithOptionsAsync(GetParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParserResponse>(await DoRequestAsync("GetParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetParserResponse GetParser(GetParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParserWithOptions(request, runtime);
        }

        public async Task<GetParserResponse> GetParserAsync(GetParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParserWithOptionsAsync(request, runtime);
        }

        public GetParserDataSourceResponse GetParserDataSourceWithOptions(GetParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParserDataSourceResponse>(DoRequest("GetParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetParserDataSourceResponse> GetParserDataSourceWithOptionsAsync(GetParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParserDataSourceResponse>(await DoRequestAsync("GetParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetParserDataSourceResponse GetParserDataSource(GetParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetParserDataSourceWithOptions(request, runtime);
        }

        public async Task<GetParserDataSourceResponse> GetParserDataSourceAsync(GetParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetParserDataSourceWithOptionsAsync(request, runtime);
        }

        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleResponse>(DoRequest("GetRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleResponse>(await DoRequestAsync("GetRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        public GetRuleActionResponse GetRuleActionWithOptions(GetRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleActionResponse>(DoRequest("GetRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRuleActionResponse> GetRuleActionWithOptionsAsync(GetRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleActionResponse>(await DoRequestAsync("GetRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetRuleActionResponse GetRuleAction(GetRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleActionWithOptions(request, runtime);
        }

        public async Task<GetRuleActionResponse> GetRuleActionAsync(GetRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleActionWithOptionsAsync(request, runtime);
        }

        public GetSceneRuleResponse GetSceneRuleWithOptions(GetSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneRuleResponse>(DoRequest("GetSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSceneRuleResponse> GetSceneRuleWithOptionsAsync(GetSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneRuleResponse>(await DoRequestAsync("GetSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSceneRuleResponse GetSceneRule(GetSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSceneRuleWithOptions(request, runtime);
        }

        public async Task<GetSceneRuleResponse> GetSceneRuleAsync(GetSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSceneRuleWithOptionsAsync(request, runtime);
        }

        public GetShareTaskByDeviceOpenResponse GetShareTaskByDeviceOpenWithOptions(GetShareTaskByDeviceOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetShareTaskByDeviceOpenResponse>(DoRequest("GetShareTaskByDeviceOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetShareTaskByDeviceOpenResponse> GetShareTaskByDeviceOpenWithOptionsAsync(GetShareTaskByDeviceOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetShareTaskByDeviceOpenResponse>(await DoRequestAsync("GetShareTaskByDeviceOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetShareTaskByDeviceOpenResponse GetShareTaskByDeviceOpen(GetShareTaskByDeviceOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetShareTaskByDeviceOpenWithOptions(request, runtime);
        }

        public async Task<GetShareTaskByDeviceOpenResponse> GetShareTaskByDeviceOpenAsync(GetShareTaskByDeviceOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetShareTaskByDeviceOpenWithOptionsAsync(request, runtime);
        }

        public GetSoundCodeAudioResponse GetSoundCodeAudioWithOptions(GetSoundCodeAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSoundCodeAudioResponse>(DoRequest("GetSoundCodeAudio", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSoundCodeAudioResponse> GetSoundCodeAudioWithOptionsAsync(GetSoundCodeAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSoundCodeAudioResponse>(await DoRequestAsync("GetSoundCodeAudio", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSoundCodeAudioResponse GetSoundCodeAudio(GetSoundCodeAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSoundCodeAudioWithOptions(request, runtime);
        }

        public async Task<GetSoundCodeAudioResponse> GetSoundCodeAudioAsync(GetSoundCodeAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSoundCodeAudioWithOptionsAsync(request, runtime);
        }

        public GetSoundCodeScheduleResponse GetSoundCodeScheduleWithOptions(GetSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSoundCodeScheduleResponse>(DoRequest("GetSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSoundCodeScheduleResponse> GetSoundCodeScheduleWithOptionsAsync(GetSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSoundCodeScheduleResponse>(await DoRequestAsync("GetSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSoundCodeScheduleResponse GetSoundCodeSchedule(GetSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSoundCodeScheduleWithOptions(request, runtime);
        }

        public async Task<GetSoundCodeScheduleResponse> GetSoundCodeScheduleAsync(GetSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSoundCodeScheduleWithOptionsAsync(request, runtime);
        }

        public GetSpeechDeviceDetailResponse GetSpeechDeviceDetailWithOptions(GetSpeechDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechDeviceDetailResponse>(DoRequest("GetSpeechDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSpeechDeviceDetailResponse> GetSpeechDeviceDetailWithOptionsAsync(GetSpeechDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechDeviceDetailResponse>(await DoRequestAsync("GetSpeechDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSpeechDeviceDetailResponse GetSpeechDeviceDetail(GetSpeechDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpeechDeviceDetailWithOptions(request, runtime);
        }

        public async Task<GetSpeechDeviceDetailResponse> GetSpeechDeviceDetailAsync(GetSpeechDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpeechDeviceDetailWithOptionsAsync(request, runtime);
        }

        public GetSpeechLicenseDeviceStatisticsResponse GetSpeechLicenseDeviceStatisticsWithOptions(GetSpeechLicenseDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechLicenseDeviceStatisticsResponse>(DoRequest("GetSpeechLicenseDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSpeechLicenseDeviceStatisticsResponse> GetSpeechLicenseDeviceStatisticsWithOptionsAsync(GetSpeechLicenseDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechLicenseDeviceStatisticsResponse>(await DoRequestAsync("GetSpeechLicenseDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSpeechLicenseDeviceStatisticsResponse GetSpeechLicenseDeviceStatistics(GetSpeechLicenseDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpeechLicenseDeviceStatisticsWithOptions(request, runtime);
        }

        public async Task<GetSpeechLicenseDeviceStatisticsResponse> GetSpeechLicenseDeviceStatisticsAsync(GetSpeechLicenseDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpeechLicenseDeviceStatisticsWithOptionsAsync(request, runtime);
        }

        public GetSpeechVoiceResponse GetSpeechVoiceWithOptions(GetSpeechVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechVoiceResponse>(DoRequest("GetSpeechVoice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSpeechVoiceResponse> GetSpeechVoiceWithOptionsAsync(GetSpeechVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSpeechVoiceResponse>(await DoRequestAsync("GetSpeechVoice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSpeechVoiceResponse GetSpeechVoice(GetSpeechVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpeechVoiceWithOptions(request, runtime);
        }

        public async Task<GetSpeechVoiceResponse> GetSpeechVoiceAsync(GetSpeechVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpeechVoiceWithOptionsAsync(request, runtime);
        }

        public GetStudioAppTokenOpenResponse GetStudioAppTokenOpenWithOptions(GetStudioAppTokenOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetStudioAppTokenOpenResponse>(DoRequest("GetStudioAppTokenOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetStudioAppTokenOpenResponse> GetStudioAppTokenOpenWithOptionsAsync(GetStudioAppTokenOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetStudioAppTokenOpenResponse>(await DoRequestAsync("GetStudioAppTokenOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetStudioAppTokenOpenResponse GetStudioAppTokenOpen(GetStudioAppTokenOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStudioAppTokenOpenWithOptions(request, runtime);
        }

        public async Task<GetStudioAppTokenOpenResponse> GetStudioAppTokenOpenAsync(GetStudioAppTokenOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStudioAppTokenOpenWithOptionsAsync(request, runtime);
        }

        public GetThingModelTslResponse GetThingModelTslWithOptions(GetThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslResponse>(DoRequest("GetThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingModelTslResponse> GetThingModelTslWithOptionsAsync(GetThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslResponse>(await DoRequestAsync("GetThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingModelTslResponse GetThingModelTsl(GetThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingModelTslWithOptions(request, runtime);
        }

        public async Task<GetThingModelTslResponse> GetThingModelTslAsync(GetThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingModelTslWithOptionsAsync(request, runtime);
        }

        public GetThingModelTslPublishedResponse GetThingModelTslPublishedWithOptions(GetThingModelTslPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslPublishedResponse>(DoRequest("GetThingModelTslPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingModelTslPublishedResponse> GetThingModelTslPublishedWithOptionsAsync(GetThingModelTslPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslPublishedResponse>(await DoRequestAsync("GetThingModelTslPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingModelTslPublishedResponse GetThingModelTslPublished(GetThingModelTslPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingModelTslPublishedWithOptions(request, runtime);
        }

        public async Task<GetThingModelTslPublishedResponse> GetThingModelTslPublishedAsync(GetThingModelTslPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingModelTslPublishedWithOptionsAsync(request, runtime);
        }

        public GetThingScriptResponse GetThingScriptWithOptions(GetThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingScriptResponse>(DoRequest("GetThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingScriptResponse> GetThingScriptWithOptionsAsync(GetThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingScriptResponse>(await DoRequestAsync("GetThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingScriptResponse GetThingScript(GetThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingScriptWithOptions(request, runtime);
        }

        public async Task<GetThingScriptResponse> GetThingScriptAsync(GetThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingScriptWithOptionsAsync(request, runtime);
        }

        public GetThingTemplateResponse GetThingTemplateWithOptions(GetThingTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTemplateResponse>(DoRequest("GetThingTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingTemplateResponse> GetThingTemplateWithOptionsAsync(GetThingTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTemplateResponse>(await DoRequestAsync("GetThingTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingTemplateResponse GetThingTemplate(GetThingTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingTemplateWithOptions(request, runtime);
        }

        public async Task<GetThingTemplateResponse> GetThingTemplateAsync(GetThingTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingTemplateWithOptionsAsync(request, runtime);
        }

        public GetThingTopoResponse GetThingTopoWithOptions(GetThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTopoResponse>(DoRequest("GetThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingTopoResponse> GetThingTopoWithOptionsAsync(GetThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTopoResponse>(await DoRequestAsync("GetThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingTopoResponse GetThingTopo(GetThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingTopoWithOptions(request, runtime);
        }

        public async Task<GetThingTopoResponse> GetThingTopoAsync(GetThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingTopoWithOptionsAsync(request, runtime);
        }

        public GisQueryDeviceLocationResponse GisQueryDeviceLocationWithOptions(GisQueryDeviceLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GisQueryDeviceLocationResponse>(DoRequest("GisQueryDeviceLocation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GisQueryDeviceLocationResponse> GisQueryDeviceLocationWithOptionsAsync(GisQueryDeviceLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GisQueryDeviceLocationResponse>(await DoRequestAsync("GisQueryDeviceLocation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GisQueryDeviceLocationResponse GisQueryDeviceLocation(GisQueryDeviceLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GisQueryDeviceLocationWithOptions(request, runtime);
        }

        public async Task<GisQueryDeviceLocationResponse> GisQueryDeviceLocationAsync(GisQueryDeviceLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GisQueryDeviceLocationWithOptionsAsync(request, runtime);
        }

        public GisSearchDeviceTraceResponse GisSearchDeviceTraceWithOptions(GisSearchDeviceTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GisSearchDeviceTraceResponse>(DoRequest("GisSearchDeviceTrace", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GisSearchDeviceTraceResponse> GisSearchDeviceTraceWithOptionsAsync(GisSearchDeviceTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GisSearchDeviceTraceResponse>(await DoRequestAsync("GisSearchDeviceTrace", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GisSearchDeviceTraceResponse GisSearchDeviceTrace(GisSearchDeviceTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GisSearchDeviceTraceWithOptions(request, runtime);
        }

        public async Task<GisSearchDeviceTraceResponse> GisSearchDeviceTraceAsync(GisSearchDeviceTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GisSearchDeviceTraceWithOptionsAsync(request, runtime);
        }

        public ImportDTDataResponse ImportDTDataWithOptions(ImportDTDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDTDataResponse>(DoRequest("ImportDTData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ImportDTDataResponse> ImportDTDataWithOptionsAsync(ImportDTDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDTDataResponse>(await DoRequestAsync("ImportDTData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ImportDTDataResponse ImportDTData(ImportDTDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDTDataWithOptions(request, runtime);
        }

        public async Task<ImportDTDataResponse> ImportDTDataAsync(ImportDTDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDTDataWithOptionsAsync(request, runtime);
        }

        public ImportDeviceResponse ImportDeviceWithOptions(ImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDeviceResponse>(DoRequest("ImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ImportDeviceResponse> ImportDeviceWithOptionsAsync(ImportDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDeviceResponse>(await DoRequestAsync("ImportDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ImportDeviceResponse ImportDevice(ImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDeviceWithOptions(request, runtime);
        }

        public async Task<ImportDeviceResponse> ImportDeviceAsync(ImportDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDeviceWithOptionsAsync(request, runtime);
        }

        public ImportThingModelTslResponse ImportThingModelTslWithOptions(ImportThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportThingModelTslResponse>(DoRequest("ImportThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ImportThingModelTslResponse> ImportThingModelTslWithOptionsAsync(ImportThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportThingModelTslResponse>(await DoRequestAsync("ImportThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ImportThingModelTslResponse ImportThingModelTsl(ImportThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportThingModelTslWithOptions(request, runtime);
        }

        public async Task<ImportThingModelTslResponse> ImportThingModelTslAsync(ImportThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportThingModelTslWithOptionsAsync(request, runtime);
        }

        public InvokeDataAPIServiceResponse InvokeDataAPIServiceWithOptions(InvokeDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeDataAPIServiceResponse>(DoRequest("InvokeDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeDataAPIServiceResponse> InvokeDataAPIServiceWithOptionsAsync(InvokeDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeDataAPIServiceResponse>(await DoRequestAsync("InvokeDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeDataAPIServiceResponse InvokeDataAPIService(InvokeDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeDataAPIServiceWithOptions(request, runtime);
        }

        public async Task<InvokeDataAPIServiceResponse> InvokeDataAPIServiceAsync(InvokeDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeDataAPIServiceWithOptionsAsync(request, runtime);
        }

        public InvokeThingServiceResponse InvokeThingServiceWithOptions(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingServiceResponse>(DoRequest("InvokeThingService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceWithOptionsAsync(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingServiceResponse>(await DoRequestAsync("InvokeThingService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeThingServiceResponse InvokeThingService(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeThingServiceWithOptions(request, runtime);
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceAsync(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeThingServiceWithOptionsAsync(request, runtime);
        }

        public InvokeThingsServiceResponse InvokeThingsServiceWithOptions(InvokeThingsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingsServiceResponse>(DoRequest("InvokeThingsService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeThingsServiceResponse> InvokeThingsServiceWithOptionsAsync(InvokeThingsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingsServiceResponse>(await DoRequestAsync("InvokeThingsService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeThingsServiceResponse InvokeThingsService(InvokeThingsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeThingsServiceWithOptions(request, runtime);
        }

        public async Task<InvokeThingsServiceResponse> InvokeThingsServiceAsync(InvokeThingsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeThingsServiceWithOptionsAsync(request, runtime);
        }

        public ListAnalyticsDataResponse ListAnalyticsDataWithOptions(ListAnalyticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAnalyticsDataResponse>(DoRequest("ListAnalyticsData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAnalyticsDataResponse> ListAnalyticsDataWithOptionsAsync(ListAnalyticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAnalyticsDataResponse>(await DoRequestAsync("ListAnalyticsData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListAnalyticsDataResponse ListAnalyticsData(ListAnalyticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnalyticsDataWithOptions(request, runtime);
        }

        public async Task<ListAnalyticsDataResponse> ListAnalyticsDataAsync(ListAnalyticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnalyticsDataWithOptionsAsync(request, runtime);
        }

        public ListDataSourceItemResponse ListDataSourceItemWithOptions(ListDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataSourceItemResponse>(DoRequest("ListDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataSourceItemResponse> ListDataSourceItemWithOptionsAsync(ListDataSourceItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataSourceItemResponse>(await DoRequestAsync("ListDataSourceItem", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDataSourceItemResponse ListDataSourceItem(ListDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceItemWithOptions(request, runtime);
        }

        public async Task<ListDataSourceItemResponse> ListDataSourceItemAsync(ListDataSourceItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceItemWithOptionsAsync(request, runtime);
        }

        public ListDestinationResponse ListDestinationWithOptions(ListDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDestinationResponse>(DoRequest("ListDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDestinationResponse> ListDestinationWithOptionsAsync(ListDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDestinationResponse>(await DoRequestAsync("ListDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDestinationResponse ListDestination(ListDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDestinationWithOptions(request, runtime);
        }

        public async Task<ListDestinationResponse> ListDestinationAsync(ListDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDestinationWithOptionsAsync(request, runtime);
        }

        public ListDeviceDistributeJobResponse ListDeviceDistributeJobWithOptions(ListDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceDistributeJobResponse>(DoRequest("ListDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDeviceDistributeJobResponse> ListDeviceDistributeJobWithOptionsAsync(ListDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceDistributeJobResponse>(await DoRequestAsync("ListDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDeviceDistributeJobResponse ListDeviceDistributeJob(ListDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<ListDeviceDistributeJobResponse> ListDeviceDistributeJobAsync(ListDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public ListDistributedDeviceResponse ListDistributedDeviceWithOptions(ListDistributedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedDeviceResponse>(DoRequest("ListDistributedDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDistributedDeviceResponse> ListDistributedDeviceWithOptionsAsync(ListDistributedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedDeviceResponse>(await DoRequestAsync("ListDistributedDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDistributedDeviceResponse ListDistributedDevice(ListDistributedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributedDeviceWithOptions(request, runtime);
        }

        public async Task<ListDistributedDeviceResponse> ListDistributedDeviceAsync(ListDistributedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributedDeviceWithOptionsAsync(request, runtime);
        }

        public ListDistributedProductResponse ListDistributedProductWithOptions(ListDistributedProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedProductResponse>(DoRequest("ListDistributedProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDistributedProductResponse> ListDistributedProductWithOptionsAsync(ListDistributedProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedProductResponse>(await DoRequestAsync("ListDistributedProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDistributedProductResponse ListDistributedProduct(ListDistributedProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributedProductWithOptions(request, runtime);
        }

        public async Task<ListDistributedProductResponse> ListDistributedProductAsync(ListDistributedProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributedProductWithOptionsAsync(request, runtime);
        }

        public ListJobResponse ListJobWithOptions(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListJobResponse>(DoRequest("ListJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListJobResponse> ListJobWithOptionsAsync(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListJobResponse>(await DoRequestAsync("ListJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListJobResponse ListJob(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobWithOptions(request, runtime);
        }

        public async Task<ListJobResponse> ListJobAsync(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobWithOptionsAsync(request, runtime);
        }

        public ListOTAFirmwareResponse ListOTAFirmwareWithOptions(ListOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAFirmwareResponse>(DoRequest("ListOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAFirmwareResponse> ListOTAFirmwareWithOptionsAsync(ListOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAFirmwareResponse>(await DoRequestAsync("ListOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAFirmwareResponse ListOTAFirmware(ListOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<ListOTAFirmwareResponse> ListOTAFirmwareAsync(ListOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public ListOTAJobByDeviceResponse ListOTAJobByDeviceWithOptions(ListOTAJobByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByDeviceResponse>(DoRequest("ListOTAJobByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAJobByDeviceResponse> ListOTAJobByDeviceWithOptionsAsync(ListOTAJobByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByDeviceResponse>(await DoRequestAsync("ListOTAJobByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAJobByDeviceResponse ListOTAJobByDevice(ListOTAJobByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAJobByDeviceWithOptions(request, runtime);
        }

        public async Task<ListOTAJobByDeviceResponse> ListOTAJobByDeviceAsync(ListOTAJobByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAJobByDeviceWithOptionsAsync(request, runtime);
        }

        public ListOTAJobByFirmwareResponse ListOTAJobByFirmwareWithOptions(ListOTAJobByFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByFirmwareResponse>(DoRequest("ListOTAJobByFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAJobByFirmwareResponse> ListOTAJobByFirmwareWithOptionsAsync(ListOTAJobByFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByFirmwareResponse>(await DoRequestAsync("ListOTAJobByFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAJobByFirmwareResponse ListOTAJobByFirmware(ListOTAJobByFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAJobByFirmwareWithOptions(request, runtime);
        }

        public async Task<ListOTAJobByFirmwareResponse> ListOTAJobByFirmwareAsync(ListOTAJobByFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAJobByFirmwareWithOptionsAsync(request, runtime);
        }

        public ListOTAModuleByProductResponse ListOTAModuleByProductWithOptions(ListOTAModuleByProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleByProductResponse>(DoRequest("ListOTAModuleByProduct", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListOTAModuleByProductResponse> ListOTAModuleByProductWithOptionsAsync(ListOTAModuleByProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleByProductResponse>(await DoRequestAsync("ListOTAModuleByProduct", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public ListOTAModuleByProductResponse ListOTAModuleByProduct(ListOTAModuleByProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAModuleByProductWithOptions(request, runtime);
        }

        public async Task<ListOTAModuleByProductResponse> ListOTAModuleByProductAsync(ListOTAModuleByProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAModuleByProductWithOptionsAsync(request, runtime);
        }

        public ListOTAModuleVersionsByDeviceResponse ListOTAModuleVersionsByDeviceWithOptions(ListOTAModuleVersionsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleVersionsByDeviceResponse>(DoRequest("ListOTAModuleVersionsByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAModuleVersionsByDeviceResponse> ListOTAModuleVersionsByDeviceWithOptionsAsync(ListOTAModuleVersionsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleVersionsByDeviceResponse>(await DoRequestAsync("ListOTAModuleVersionsByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAModuleVersionsByDeviceResponse ListOTAModuleVersionsByDevice(ListOTAModuleVersionsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAModuleVersionsByDeviceWithOptions(request, runtime);
        }

        public async Task<ListOTAModuleVersionsByDeviceResponse> ListOTAModuleVersionsByDeviceAsync(ListOTAModuleVersionsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAModuleVersionsByDeviceWithOptionsAsync(request, runtime);
        }

        public ListOTATaskByJobResponse ListOTATaskByJobWithOptions(ListOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTATaskByJobResponse>(DoRequest("ListOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTATaskByJobResponse> ListOTATaskByJobWithOptionsAsync(ListOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTATaskByJobResponse>(await DoRequestAsync("ListOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTATaskByJobResponse ListOTATaskByJob(ListOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTATaskByJobWithOptions(request, runtime);
        }

        public async Task<ListOTATaskByJobResponse> ListOTATaskByJobAsync(ListOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTATaskByJobWithOptionsAsync(request, runtime);
        }

        public ListOTAUnfinishedTaskByDeviceResponse ListOTAUnfinishedTaskByDeviceWithOptions(ListOTAUnfinishedTaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAUnfinishedTaskByDeviceResponse>(DoRequest("ListOTAUnfinishedTaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAUnfinishedTaskByDeviceResponse> ListOTAUnfinishedTaskByDeviceWithOptionsAsync(ListOTAUnfinishedTaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAUnfinishedTaskByDeviceResponse>(await DoRequestAsync("ListOTAUnfinishedTaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAUnfinishedTaskByDeviceResponse ListOTAUnfinishedTaskByDevice(ListOTAUnfinishedTaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAUnfinishedTaskByDeviceWithOptions(request, runtime);
        }

        public async Task<ListOTAUnfinishedTaskByDeviceResponse> ListOTAUnfinishedTaskByDeviceAsync(ListOTAUnfinishedTaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAUnfinishedTaskByDeviceWithOptionsAsync(request, runtime);
        }

        public ListParserResponse ListParserWithOptions(ListParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserResponse>(DoRequest("ListParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListParserResponse> ListParserWithOptionsAsync(ListParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserResponse>(await DoRequestAsync("ListParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListParserResponse ListParser(ListParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParserWithOptions(request, runtime);
        }

        public async Task<ListParserResponse> ListParserAsync(ListParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParserWithOptionsAsync(request, runtime);
        }

        public ListParserDataSourceResponse ListParserDataSourceWithOptions(ListParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserDataSourceResponse>(DoRequest("ListParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListParserDataSourceResponse> ListParserDataSourceWithOptionsAsync(ListParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserDataSourceResponse>(await DoRequestAsync("ListParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListParserDataSourceResponse ListParserDataSource(ListParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParserDataSourceWithOptions(request, runtime);
        }

        public async Task<ListParserDataSourceResponse> ListParserDataSourceAsync(ListParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParserDataSourceWithOptionsAsync(request, runtime);
        }

        public ListParserDestinationResponse ListParserDestinationWithOptions(ListParserDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserDestinationResponse>(DoRequest("ListParserDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListParserDestinationResponse> ListParserDestinationWithOptionsAsync(ListParserDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListParserDestinationResponse>(await DoRequestAsync("ListParserDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListParserDestinationResponse ListParserDestination(ListParserDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListParserDestinationWithOptions(request, runtime);
        }

        public async Task<ListParserDestinationResponse> ListParserDestinationAsync(ListParserDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListParserDestinationWithOptionsAsync(request, runtime);
        }

        public ListProductByTagsResponse ListProductByTagsWithOptions(ListProductByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductByTagsResponse>(DoRequest("ListProductByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProductByTagsResponse> ListProductByTagsWithOptionsAsync(ListProductByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductByTagsResponse>(await DoRequestAsync("ListProductByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListProductByTagsResponse ListProductByTags(ListProductByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductByTagsWithOptions(request, runtime);
        }

        public async Task<ListProductByTagsResponse> ListProductByTagsAsync(ListProductByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductByTagsWithOptionsAsync(request, runtime);
        }

        public ListProductTagsResponse ListProductTagsWithOptions(ListProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductTagsResponse>(DoRequest("ListProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProductTagsResponse> ListProductTagsWithOptionsAsync(ListProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductTagsResponse>(await DoRequestAsync("ListProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListProductTagsResponse ListProductTags(ListProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductTagsWithOptions(request, runtime);
        }

        public async Task<ListProductTagsResponse> ListProductTagsAsync(ListProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductTagsWithOptionsAsync(request, runtime);
        }

        public ListRuleResponse ListRuleWithOptions(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleResponse>(DoRequest("ListRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRuleResponse> ListRuleWithOptionsAsync(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleResponse>(await DoRequestAsync("ListRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListRuleResponse ListRule(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleWithOptions(request, runtime);
        }

        public async Task<ListRuleResponse> ListRuleAsync(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleWithOptionsAsync(request, runtime);
        }

        public ListRuleActionsResponse ListRuleActionsWithOptions(ListRuleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleActionsResponse>(DoRequest("ListRuleActions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRuleActionsResponse> ListRuleActionsWithOptionsAsync(ListRuleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleActionsResponse>(await DoRequestAsync("ListRuleActions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListRuleActionsResponse ListRuleActions(ListRuleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleActionsWithOptions(request, runtime);
        }

        public async Task<ListRuleActionsResponse> ListRuleActionsAsync(ListRuleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleActionsWithOptionsAsync(request, runtime);
        }

        public ListTaskResponse ListTaskWithOptions(ListTaskRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskShrinkRequest request = new ListTaskShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskResponse>(DoRequest("ListTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTaskResponse> ListTaskWithOptionsAsync(ListTaskRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskShrinkRequest request = new ListTaskShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskResponse>(await DoRequestAsync("ListTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListTaskResponse ListTask(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskWithOptions(request, runtime);
        }

        public async Task<ListTaskResponse> ListTaskAsync(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskWithOptionsAsync(request, runtime);
        }

        public ListThingModelVersionResponse ListThingModelVersionWithOptions(ListThingModelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingModelVersionResponse>(DoRequest("ListThingModelVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListThingModelVersionResponse> ListThingModelVersionWithOptionsAsync(ListThingModelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingModelVersionResponse>(await DoRequestAsync("ListThingModelVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListThingModelVersionResponse ListThingModelVersion(ListThingModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListThingModelVersionWithOptions(request, runtime);
        }

        public async Task<ListThingModelVersionResponse> ListThingModelVersionAsync(ListThingModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListThingModelVersionWithOptionsAsync(request, runtime);
        }

        public ListThingTemplatesResponse ListThingTemplatesWithOptions(ListThingTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingTemplatesResponse>(DoRequest("ListThingTemplates", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListThingTemplatesResponse> ListThingTemplatesWithOptionsAsync(ListThingTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingTemplatesResponse>(await DoRequestAsync("ListThingTemplates", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListThingTemplatesResponse ListThingTemplates(ListThingTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListThingTemplatesWithOptions(request, runtime);
        }

        public async Task<ListThingTemplatesResponse> ListThingTemplatesAsync(ListThingTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListThingTemplatesWithOptionsAsync(request, runtime);
        }

        public NotifyAddThingTopoResponse NotifyAddThingTopoWithOptions(NotifyAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<NotifyAddThingTopoResponse>(DoRequest("NotifyAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<NotifyAddThingTopoResponse> NotifyAddThingTopoWithOptionsAsync(NotifyAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<NotifyAddThingTopoResponse>(await DoRequestAsync("NotifyAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public NotifyAddThingTopoResponse NotifyAddThingTopo(NotifyAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyAddThingTopoWithOptions(request, runtime);
        }

        public async Task<NotifyAddThingTopoResponse> NotifyAddThingTopoAsync(NotifyAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyAddThingTopoWithOptionsAsync(request, runtime);
        }

        public OpenIotServiceResponse OpenIotServiceWithOptions(OpenIotServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenIotServiceResponse>(DoRequest("OpenIotService", "HTTPS", "POST", "2018-01-20", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<OpenIotServiceResponse> OpenIotServiceWithOptionsAsync(OpenIotServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenIotServiceResponse>(await DoRequestAsync("OpenIotService", "HTTPS", "POST", "2018-01-20", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public OpenIotServiceResponse OpenIotService(OpenIotServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenIotServiceWithOptions(request, runtime);
        }

        public async Task<OpenIotServiceResponse> OpenIotServiceAsync(OpenIotServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenIotServiceWithOptionsAsync(request, runtime);
        }

        public PackageSoundCodeLabelBatchAudioResponse PackageSoundCodeLabelBatchAudioWithOptions(PackageSoundCodeLabelBatchAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PackageSoundCodeLabelBatchAudioResponse>(DoRequest("PackageSoundCodeLabelBatchAudio", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PackageSoundCodeLabelBatchAudioResponse> PackageSoundCodeLabelBatchAudioWithOptionsAsync(PackageSoundCodeLabelBatchAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PackageSoundCodeLabelBatchAudioResponse>(await DoRequestAsync("PackageSoundCodeLabelBatchAudio", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PackageSoundCodeLabelBatchAudioResponse PackageSoundCodeLabelBatchAudio(PackageSoundCodeLabelBatchAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PackageSoundCodeLabelBatchAudioWithOptions(request, runtime);
        }

        public async Task<PackageSoundCodeLabelBatchAudioResponse> PackageSoundCodeLabelBatchAudioAsync(PackageSoundCodeLabelBatchAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PackageSoundCodeLabelBatchAudioWithOptionsAsync(request, runtime);
        }

        public PageQuerySharedSpeechOpenResponse PageQuerySharedSpeechOpenWithOptions(PageQuerySharedSpeechOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PageQuerySharedSpeechOpenResponse>(DoRequest("PageQuerySharedSpeechOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PageQuerySharedSpeechOpenResponse> PageQuerySharedSpeechOpenWithOptionsAsync(PageQuerySharedSpeechOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PageQuerySharedSpeechOpenResponse>(await DoRequestAsync("PageQuerySharedSpeechOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PageQuerySharedSpeechOpenResponse PageQuerySharedSpeechOpen(PageQuerySharedSpeechOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageQuerySharedSpeechOpenWithOptions(request, runtime);
        }

        public async Task<PageQuerySharedSpeechOpenResponse> PageQuerySharedSpeechOpenAsync(PageQuerySharedSpeechOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageQuerySharedSpeechOpenWithOptionsAsync(request, runtime);
        }

        public PageQuerySpeechBroadcastHourResponse PageQuerySpeechBroadcastHourWithOptions(PageQuerySpeechBroadcastHourRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PageQuerySpeechBroadcastHourResponse>(DoRequest("PageQuerySpeechBroadcastHour", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PageQuerySpeechBroadcastHourResponse> PageQuerySpeechBroadcastHourWithOptionsAsync(PageQuerySpeechBroadcastHourRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PageQuerySpeechBroadcastHourResponse>(await DoRequestAsync("PageQuerySpeechBroadcastHour", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PageQuerySpeechBroadcastHourResponse PageQuerySpeechBroadcastHour(PageQuerySpeechBroadcastHourRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageQuerySpeechBroadcastHourWithOptions(request, runtime);
        }

        public async Task<PageQuerySpeechBroadcastHourResponse> PageQuerySpeechBroadcastHourAsync(PageQuerySpeechBroadcastHourRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageQuerySpeechBroadcastHourWithOptionsAsync(request, runtime);
        }

        public PrintByTemplateResponse PrintByTemplateWithOptions(PrintByTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PrintByTemplateResponse>(DoRequest("PrintByTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PrintByTemplateResponse> PrintByTemplateWithOptionsAsync(PrintByTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PrintByTemplateResponse>(await DoRequestAsync("PrintByTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PrintByTemplateResponse PrintByTemplate(PrintByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PrintByTemplateWithOptions(request, runtime);
        }

        public async Task<PrintByTemplateResponse> PrintByTemplateAsync(PrintByTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PrintByTemplateWithOptionsAsync(request, runtime);
        }

        public PubResponse PubWithOptions(PubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubResponse>(DoRequest("Pub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PubResponse> PubWithOptionsAsync(PubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubResponse>(await DoRequestAsync("Pub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PubResponse Pub(PubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PubWithOptions(request, runtime);
        }

        public async Task<PubResponse> PubAsync(PubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PubWithOptionsAsync(request, runtime);
        }

        public PubBroadcastResponse PubBroadcastWithOptions(PubBroadcastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubBroadcastResponse>(DoRequest("PubBroadcast", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PubBroadcastResponse> PubBroadcastWithOptionsAsync(PubBroadcastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubBroadcastResponse>(await DoRequestAsync("PubBroadcast", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PubBroadcastResponse PubBroadcast(PubBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PubBroadcastWithOptions(request, runtime);
        }

        public async Task<PubBroadcastResponse> PubBroadcastAsync(PubBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PubBroadcastWithOptionsAsync(request, runtime);
        }

        public PublishScriptResponse PublishScriptWithOptions(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishScriptResponse>(DoRequest("PublishScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PublishScriptResponse> PublishScriptWithOptionsAsync(PublishScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishScriptResponse>(await DoRequestAsync("PublishScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PublishScriptResponse PublishScript(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishScriptWithOptions(request, runtime);
        }

        public async Task<PublishScriptResponse> PublishScriptAsync(PublishScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishScriptWithOptionsAsync(request, runtime);
        }

        public PublishStudioAppResponse PublishStudioAppWithOptions(PublishStudioAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishStudioAppResponse>(DoRequest("PublishStudioApp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PublishStudioAppResponse> PublishStudioAppWithOptionsAsync(PublishStudioAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishStudioAppResponse>(await DoRequestAsync("PublishStudioApp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PublishStudioAppResponse PublishStudioApp(PublishStudioAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishStudioAppWithOptions(request, runtime);
        }

        public async Task<PublishStudioAppResponse> PublishStudioAppAsync(PublishStudioAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishStudioAppWithOptionsAsync(request, runtime);
        }

        public PublishThingModelResponse PublishThingModelWithOptions(PublishThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishThingModelResponse>(DoRequest("PublishThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PublishThingModelResponse> PublishThingModelWithOptionsAsync(PublishThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishThingModelResponse>(await DoRequestAsync("PublishThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PublishThingModelResponse PublishThingModel(PublishThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishThingModelWithOptions(request, runtime);
        }

        public async Task<PublishThingModelResponse> PublishThingModelAsync(PublishThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishThingModelWithOptionsAsync(request, runtime);
        }

        public PushSpeechResponse PushSpeechWithOptions(PushSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PushSpeechResponse>(DoRequest("PushSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PushSpeechResponse> PushSpeechWithOptionsAsync(PushSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PushSpeechResponse>(await DoRequestAsync("PushSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PushSpeechResponse PushSpeech(PushSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushSpeechWithOptions(request, runtime);
        }

        public async Task<PushSpeechResponse> PushSpeechAsync(PushSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushSpeechWithOptionsAsync(request, runtime);
        }

        public QueryBatchRegisterDeviceStatusResponse QueryBatchRegisterDeviceStatusWithOptions(QueryBatchRegisterDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryBatchRegisterDeviceStatusResponse>(DoRequest("QueryBatchRegisterDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryBatchRegisterDeviceStatusResponse> QueryBatchRegisterDeviceStatusWithOptionsAsync(QueryBatchRegisterDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryBatchRegisterDeviceStatusResponse>(await DoRequestAsync("QueryBatchRegisterDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryBatchRegisterDeviceStatusResponse QueryBatchRegisterDeviceStatus(QueryBatchRegisterDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchRegisterDeviceStatusWithOptions(request, runtime);
        }

        public async Task<QueryBatchRegisterDeviceStatusResponse> QueryBatchRegisterDeviceStatusAsync(QueryBatchRegisterDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchRegisterDeviceStatusWithOptionsAsync(request, runtime);
        }

        public QueryCertUrlByApplyIdResponse QueryCertUrlByApplyIdWithOptions(QueryCertUrlByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryCertUrlByApplyIdResponse>(DoRequest("QueryCertUrlByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryCertUrlByApplyIdResponse> QueryCertUrlByApplyIdWithOptionsAsync(QueryCertUrlByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryCertUrlByApplyIdResponse>(await DoRequestAsync("QueryCertUrlByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryCertUrlByApplyIdResponse QueryCertUrlByApplyId(QueryCertUrlByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCertUrlByApplyIdWithOptions(request, runtime);
        }

        public async Task<QueryCertUrlByApplyIdResponse> QueryCertUrlByApplyIdAsync(QueryCertUrlByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCertUrlByApplyIdWithOptionsAsync(request, runtime);
        }

        public QueryClientIdsResponse QueryClientIdsWithOptions(QueryClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryClientIdsResponse>(DoRequest("QueryClientIds", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryClientIdsResponse> QueryClientIdsWithOptionsAsync(QueryClientIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryClientIdsResponse>(await DoRequestAsync("QueryClientIds", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryClientIdsResponse QueryClientIds(QueryClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryClientIdsWithOptions(request, runtime);
        }

        public async Task<QueryClientIdsResponse> QueryClientIdsAsync(QueryClientIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryClientIdsWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupByGroupIdResponse QueryConsumerGroupByGroupIdWithOptions(QueryConsumerGroupByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupByGroupIdResponse>(DoRequest("QueryConsumerGroupByGroupId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupByGroupIdResponse> QueryConsumerGroupByGroupIdWithOptionsAsync(QueryConsumerGroupByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupByGroupIdResponse>(await DoRequestAsync("QueryConsumerGroupByGroupId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupByGroupIdResponse QueryConsumerGroupByGroupId(QueryConsumerGroupByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupByGroupIdWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupByGroupIdResponse> QueryConsumerGroupByGroupIdAsync(QueryConsumerGroupByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupByGroupIdWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupListResponse QueryConsumerGroupListWithOptions(QueryConsumerGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupListResponse>(DoRequest("QueryConsumerGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupListResponse> QueryConsumerGroupListWithOptionsAsync(QueryConsumerGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupListResponse>(await DoRequestAsync("QueryConsumerGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupListResponse QueryConsumerGroupList(QueryConsumerGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupListWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupListResponse> QueryConsumerGroupListAsync(QueryConsumerGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupListWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupStatusResponse QueryConsumerGroupStatusWithOptions(QueryConsumerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupStatusResponse>(DoRequest("QueryConsumerGroupStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupStatusResponse> QueryConsumerGroupStatusWithOptionsAsync(QueryConsumerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupStatusResponse>(await DoRequestAsync("QueryConsumerGroupStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupStatusResponse QueryConsumerGroupStatus(QueryConsumerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupStatusWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupStatusResponse> QueryConsumerGroupStatusAsync(QueryConsumerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupStatusWithOptionsAsync(request, runtime);
        }

        public QueryDetailSceneRuleLogResponse QueryDetailSceneRuleLogWithOptions(QueryDetailSceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDetailSceneRuleLogResponse>(DoRequest("QueryDetailSceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDetailSceneRuleLogResponse> QueryDetailSceneRuleLogWithOptionsAsync(QueryDetailSceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDetailSceneRuleLogResponse>(await DoRequestAsync("QueryDetailSceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDetailSceneRuleLogResponse QueryDetailSceneRuleLog(QueryDetailSceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDetailSceneRuleLogWithOptions(request, runtime);
        }

        public async Task<QueryDetailSceneRuleLogResponse> QueryDetailSceneRuleLogAsync(QueryDetailSceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDetailSceneRuleLogWithOptionsAsync(request, runtime);
        }

        public QueryDeviceResponse QueryDeviceWithOptions(QueryDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceResponse>(DoRequest("QueryDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceResponse> QueryDeviceWithOptionsAsync(QueryDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceResponse>(await DoRequestAsync("QueryDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceResponse QueryDevice(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceWithOptions(request, runtime);
        }

        public async Task<QueryDeviceResponse> QueryDeviceAsync(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceWithOptionsAsync(request, runtime);
        }

        public QueryDeviceBySQLResponse QueryDeviceBySQLWithOptions(QueryDeviceBySQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceBySQLResponse>(DoRequest("QueryDeviceBySQL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceBySQLResponse> QueryDeviceBySQLWithOptionsAsync(QueryDeviceBySQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceBySQLResponse>(await DoRequestAsync("QueryDeviceBySQL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceBySQLResponse QueryDeviceBySQL(QueryDeviceBySQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceBySQLWithOptions(request, runtime);
        }

        public async Task<QueryDeviceBySQLResponse> QueryDeviceBySQLAsync(QueryDeviceBySQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceBySQLWithOptionsAsync(request, runtime);
        }

        public QueryDeviceByStatusResponse QueryDeviceByStatusWithOptions(QueryDeviceByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByStatusResponse>(DoRequest("QueryDeviceByStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceByStatusResponse> QueryDeviceByStatusWithOptionsAsync(QueryDeviceByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByStatusResponse>(await DoRequestAsync("QueryDeviceByStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceByStatusResponse QueryDeviceByStatus(QueryDeviceByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceByStatusWithOptions(request, runtime);
        }

        public async Task<QueryDeviceByStatusResponse> QueryDeviceByStatusAsync(QueryDeviceByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceByStatusWithOptionsAsync(request, runtime);
        }

        public QueryDeviceByTagsResponse QueryDeviceByTagsWithOptions(QueryDeviceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByTagsResponse>(DoRequest("QueryDeviceByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceByTagsResponse> QueryDeviceByTagsWithOptionsAsync(QueryDeviceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByTagsResponse>(await DoRequestAsync("QueryDeviceByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceByTagsResponse QueryDeviceByTags(QueryDeviceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceByTagsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceByTagsResponse> QueryDeviceByTagsAsync(QueryDeviceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceByTagsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceCertResponse QueryDeviceCertWithOptions(QueryDeviceCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceCertResponse>(DoRequest("QueryDeviceCert", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceCertResponse> QueryDeviceCertWithOptionsAsync(QueryDeviceCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceCertResponse>(await DoRequestAsync("QueryDeviceCert", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceCertResponse QueryDeviceCert(QueryDeviceCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceCertWithOptions(request, runtime);
        }

        public async Task<QueryDeviceCertResponse> QueryDeviceCertAsync(QueryDeviceCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceCertWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDesiredPropertyResponse QueryDeviceDesiredPropertyWithOptions(QueryDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDesiredPropertyResponse>(DoRequest("QueryDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDesiredPropertyResponse> QueryDeviceDesiredPropertyWithOptionsAsync(QueryDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDesiredPropertyResponse>(await DoRequestAsync("QueryDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDesiredPropertyResponse QueryDeviceDesiredProperty(QueryDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDesiredPropertyWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDesiredPropertyResponse> QueryDeviceDesiredPropertyAsync(QueryDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDesiredPropertyWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDetailResponse QueryDeviceDetailWithOptions(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDetailResponse>(DoRequest("QueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailWithOptionsAsync(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDetailResponse>(await DoRequestAsync("QueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDetailResponse QueryDeviceDetail(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDetailWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailAsync(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDetailWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDistributeDetailResponse QueryDeviceDistributeDetailWithOptions(QueryDeviceDistributeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeDetailResponse>(DoRequest("QueryDeviceDistributeDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDistributeDetailResponse> QueryDeviceDistributeDetailWithOptionsAsync(QueryDeviceDistributeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeDetailResponse>(await DoRequestAsync("QueryDeviceDistributeDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDistributeDetailResponse QueryDeviceDistributeDetail(QueryDeviceDistributeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDistributeDetailWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDistributeDetailResponse> QueryDeviceDistributeDetailAsync(QueryDeviceDistributeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDistributeDetailWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDistributeJobResponse QueryDeviceDistributeJobWithOptions(QueryDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeJobResponse>(DoRequest("QueryDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDistributeJobResponse> QueryDeviceDistributeJobWithOptionsAsync(QueryDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeJobResponse>(await DoRequestAsync("QueryDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDistributeJobResponse QueryDeviceDistributeJob(QueryDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDistributeJobResponse> QueryDeviceDistributeJobAsync(QueryDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventDataResponse QueryDeviceEventDataWithOptions(QueryDeviceEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceEventDataResponse>(DoRequest("QueryDeviceEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceEventDataResponse> QueryDeviceEventDataWithOptionsAsync(QueryDeviceEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceEventDataResponse>(await DoRequestAsync("QueryDeviceEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceEventDataResponse QueryDeviceEventData(QueryDeviceEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceEventDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceEventDataResponse> QueryDeviceEventDataAsync(QueryDeviceEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceEventDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceFileResponse QueryDeviceFileWithOptions(QueryDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileResponse>(DoRequest("QueryDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceFileResponse> QueryDeviceFileWithOptionsAsync(QueryDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileResponse>(await DoRequestAsync("QueryDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceFileResponse QueryDeviceFile(QueryDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceFileWithOptions(request, runtime);
        }

        public async Task<QueryDeviceFileResponse> QueryDeviceFileAsync(QueryDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceFileWithOptionsAsync(request, runtime);
        }

        public QueryDeviceFileListResponse QueryDeviceFileListWithOptions(QueryDeviceFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileListResponse>(DoRequest("QueryDeviceFileList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceFileListResponse> QueryDeviceFileListWithOptionsAsync(QueryDeviceFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileListResponse>(await DoRequestAsync("QueryDeviceFileList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceFileListResponse QueryDeviceFileList(QueryDeviceFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceFileListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceFileListResponse> QueryDeviceFileListAsync(QueryDeviceFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceFileListWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupByDeviceResponse QueryDeviceGroupByDeviceWithOptions(QueryDeviceGroupByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByDeviceResponse>(DoRequest("QueryDeviceGroupByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupByDeviceResponse> QueryDeviceGroupByDeviceWithOptionsAsync(QueryDeviceGroupByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByDeviceResponse>(await DoRequestAsync("QueryDeviceGroupByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupByDeviceResponse QueryDeviceGroupByDevice(QueryDeviceGroupByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupByDeviceWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupByDeviceResponse> QueryDeviceGroupByDeviceAsync(QueryDeviceGroupByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupByDeviceWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupByTagsResponse QueryDeviceGroupByTagsWithOptions(QueryDeviceGroupByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByTagsResponse>(DoRequest("QueryDeviceGroupByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupByTagsResponse> QueryDeviceGroupByTagsWithOptionsAsync(QueryDeviceGroupByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByTagsResponse>(await DoRequestAsync("QueryDeviceGroupByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupByTagsResponse QueryDeviceGroupByTags(QueryDeviceGroupByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupByTagsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupByTagsResponse> QueryDeviceGroupByTagsAsync(QueryDeviceGroupByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupByTagsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupInfoResponse QueryDeviceGroupInfoWithOptions(QueryDeviceGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupInfoResponse>(DoRequest("QueryDeviceGroupInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupInfoResponse> QueryDeviceGroupInfoWithOptionsAsync(QueryDeviceGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupInfoResponse>(await DoRequestAsync("QueryDeviceGroupInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupInfoResponse QueryDeviceGroupInfo(QueryDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupInfoWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupInfoResponse> QueryDeviceGroupInfoAsync(QueryDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupInfoWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupListResponse QueryDeviceGroupListWithOptions(QueryDeviceGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupListResponse>(DoRequest("QueryDeviceGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupListResponse> QueryDeviceGroupListWithOptionsAsync(QueryDeviceGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupListResponse>(await DoRequestAsync("QueryDeviceGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupListResponse QueryDeviceGroupList(QueryDeviceGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupListResponse> QueryDeviceGroupListAsync(QueryDeviceGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupListWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupTagListResponse QueryDeviceGroupTagListWithOptions(QueryDeviceGroupTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupTagListResponse>(DoRequest("QueryDeviceGroupTagList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupTagListResponse> QueryDeviceGroupTagListWithOptionsAsync(QueryDeviceGroupTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupTagListResponse>(await DoRequestAsync("QueryDeviceGroupTagList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupTagListResponse QueryDeviceGroupTagList(QueryDeviceGroupTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupTagListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupTagListResponse> QueryDeviceGroupTagListAsync(QueryDeviceGroupTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupTagListWithOptionsAsync(request, runtime);
        }

        public QueryDeviceInfoResponse QueryDeviceInfoWithOptions(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceInfoResponse>(DoRequest("QueryDeviceInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoWithOptionsAsync(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceInfoResponse>(await DoRequestAsync("QueryDeviceInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceInfoResponse QueryDeviceInfo(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceInfoWithOptions(request, runtime);
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoAsync(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceInfoWithOptionsAsync(request, runtime);
        }

        public QueryDeviceListByDeviceGroupResponse QueryDeviceListByDeviceGroupWithOptions(QueryDeviceListByDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceListByDeviceGroupResponse>(DoRequest("QueryDeviceListByDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceListByDeviceGroupResponse> QueryDeviceListByDeviceGroupWithOptionsAsync(QueryDeviceListByDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceListByDeviceGroupResponse>(await DoRequestAsync("QueryDeviceListByDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceListByDeviceGroupResponse QueryDeviceListByDeviceGroup(QueryDeviceListByDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceListByDeviceGroupWithOptions(request, runtime);
        }

        public async Task<QueryDeviceListByDeviceGroupResponse> QueryDeviceListByDeviceGroupAsync(QueryDeviceListByDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceListByDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalEventDataResponse QueryDeviceOriginalEventDataWithOptions(QueryDeviceOriginalEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalEventDataResponse>(DoRequest("QueryDeviceOriginalEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalEventDataResponse> QueryDeviceOriginalEventDataWithOptionsAsync(QueryDeviceOriginalEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalEventDataResponse>(await DoRequestAsync("QueryDeviceOriginalEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalEventDataResponse QueryDeviceOriginalEventData(QueryDeviceOriginalEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalEventDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalEventDataResponse> QueryDeviceOriginalEventDataAsync(QueryDeviceOriginalEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalEventDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalPropertyDataResponse QueryDeviceOriginalPropertyDataWithOptions(QueryDeviceOriginalPropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyDataResponse>(DoRequest("QueryDeviceOriginalPropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalPropertyDataResponse> QueryDeviceOriginalPropertyDataWithOptionsAsync(QueryDeviceOriginalPropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyDataResponse>(await DoRequestAsync("QueryDeviceOriginalPropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalPropertyDataResponse QueryDeviceOriginalPropertyData(QueryDeviceOriginalPropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalPropertyDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalPropertyDataResponse> QueryDeviceOriginalPropertyDataAsync(QueryDeviceOriginalPropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalPropertyDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalPropertyStatusResponse QueryDeviceOriginalPropertyStatusWithOptions(QueryDeviceOriginalPropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyStatusResponse>(DoRequest("QueryDeviceOriginalPropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalPropertyStatusResponse> QueryDeviceOriginalPropertyStatusWithOptionsAsync(QueryDeviceOriginalPropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyStatusResponse>(await DoRequestAsync("QueryDeviceOriginalPropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalPropertyStatusResponse QueryDeviceOriginalPropertyStatus(QueryDeviceOriginalPropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalPropertyStatusWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalPropertyStatusResponse> QueryDeviceOriginalPropertyStatusAsync(QueryDeviceOriginalPropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalPropertyStatusWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalServiceDataResponse QueryDeviceOriginalServiceDataWithOptions(QueryDeviceOriginalServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalServiceDataResponse>(DoRequest("QueryDeviceOriginalServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalServiceDataResponse> QueryDeviceOriginalServiceDataWithOptionsAsync(QueryDeviceOriginalServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalServiceDataResponse>(await DoRequestAsync("QueryDeviceOriginalServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalServiceDataResponse QueryDeviceOriginalServiceData(QueryDeviceOriginalServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalServiceDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalServiceDataResponse> QueryDeviceOriginalServiceDataAsync(QueryDeviceOriginalServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalServiceDataWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropResponse QueryDevicePropWithOptions(QueryDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropResponse>(DoRequest("QueryDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropResponse> QueryDevicePropWithOptionsAsync(QueryDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropResponse>(await DoRequestAsync("QueryDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropResponse QueryDeviceProp(QueryDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropResponse> QueryDevicePropAsync(QueryDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertiesDataResponse QueryDevicePropertiesDataWithOptions(QueryDevicePropertiesDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertiesDataResponse>(DoRequest("QueryDevicePropertiesData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertiesDataResponse> QueryDevicePropertiesDataWithOptionsAsync(QueryDevicePropertiesDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertiesDataResponse>(await DoRequestAsync("QueryDevicePropertiesData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertiesDataResponse QueryDevicePropertiesData(QueryDevicePropertiesDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertiesDataWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertiesDataResponse> QueryDevicePropertiesDataAsync(QueryDevicePropertiesDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertiesDataWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertyDataResponse QueryDevicePropertyDataWithOptions(QueryDevicePropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyDataResponse>(DoRequest("QueryDevicePropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertyDataResponse> QueryDevicePropertyDataWithOptionsAsync(QueryDevicePropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyDataResponse>(await DoRequestAsync("QueryDevicePropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertyDataResponse QueryDevicePropertyData(QueryDevicePropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertyDataWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertyDataResponse> QueryDevicePropertyDataAsync(QueryDevicePropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertyDataWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertyStatusResponse QueryDevicePropertyStatusWithOptions(QueryDevicePropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyStatusResponse>(DoRequest("QueryDevicePropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertyStatusResponse> QueryDevicePropertyStatusWithOptionsAsync(QueryDevicePropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyStatusResponse>(await DoRequestAsync("QueryDevicePropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertyStatusResponse QueryDevicePropertyStatus(QueryDevicePropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertyStatusWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertyStatusResponse> QueryDevicePropertyStatusAsync(QueryDevicePropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertyStatusWithOptionsAsync(request, runtime);
        }

        public QueryDeviceServiceDataResponse QueryDeviceServiceDataWithOptions(QueryDeviceServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceServiceDataResponse>(DoRequest("QueryDeviceServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceServiceDataResponse> QueryDeviceServiceDataWithOptionsAsync(QueryDeviceServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceServiceDataResponse>(await DoRequestAsync("QueryDeviceServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceServiceDataResponse QueryDeviceServiceData(QueryDeviceServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceServiceDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceServiceDataResponse> QueryDeviceServiceDataAsync(QueryDeviceServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceServiceDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceSpeechResponse QueryDeviceSpeechWithOptions(QueryDeviceSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceSpeechResponse>(DoRequest("QueryDeviceSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceSpeechResponse> QueryDeviceSpeechWithOptionsAsync(QueryDeviceSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceSpeechResponse>(await DoRequestAsync("QueryDeviceSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceSpeechResponse QueryDeviceSpeech(QueryDeviceSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceSpeechWithOptions(request, runtime);
        }

        public async Task<QueryDeviceSpeechResponse> QueryDeviceSpeechAsync(QueryDeviceSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceSpeechWithOptionsAsync(request, runtime);
        }

        public QueryDeviceStatisticsResponse QueryDeviceStatisticsWithOptions(QueryDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceStatisticsResponse>(DoRequest("QueryDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceStatisticsResponse> QueryDeviceStatisticsWithOptionsAsync(QueryDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceStatisticsResponse>(await DoRequestAsync("QueryDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceStatisticsResponse QueryDeviceStatistics(QueryDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceStatisticsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceStatisticsResponse> QueryDeviceStatisticsAsync(QueryDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceStatisticsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceSubTopicResponse QueryDeviceSubTopicWithOptions(QueryDeviceSubTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceSubTopicResponse>(DoRequest("QueryDeviceSubTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceSubTopicResponse> QueryDeviceSubTopicWithOptionsAsync(QueryDeviceSubTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceSubTopicResponse>(await DoRequestAsync("QueryDeviceSubTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceSubTopicResponse QueryDeviceSubTopic(QueryDeviceSubTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceSubTopicWithOptions(request, runtime);
        }

        public async Task<QueryDeviceSubTopicResponse> QueryDeviceSubTopicAsync(QueryDeviceSubTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceSubTopicWithOptionsAsync(request, runtime);
        }

        public QueryDeviceTunnelResponse QueryDeviceTunnelWithOptions(QueryDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceTunnelResponse>(DoRequest("QueryDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceTunnelResponse> QueryDeviceTunnelWithOptionsAsync(QueryDeviceTunnelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceTunnelResponse>(await DoRequestAsync("QueryDeviceTunnel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceTunnelResponse QueryDeviceTunnel(QueryDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceTunnelWithOptions(request, runtime);
        }

        public async Task<QueryDeviceTunnelResponse> QueryDeviceTunnelAsync(QueryDeviceTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceTunnelWithOptionsAsync(request, runtime);
        }

        public QueryDevicesHotStorageDataResponse QueryDevicesHotStorageDataWithOptions(QueryDevicesHotStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicesHotStorageDataResponse>(DoRequest("QueryDevicesHotStorageData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicesHotStorageDataResponse> QueryDevicesHotStorageDataWithOptionsAsync(QueryDevicesHotStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicesHotStorageDataResponse>(await DoRequestAsync("QueryDevicesHotStorageData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicesHotStorageDataResponse QueryDevicesHotStorageData(QueryDevicesHotStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesHotStorageDataWithOptions(request, runtime);
        }

        public async Task<QueryDevicesHotStorageDataResponse> QueryDevicesHotStorageDataAsync(QueryDevicesHotStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesHotStorageDataWithOptionsAsync(request, runtime);
        }

        public QueryDevicesHotStorageDataStatusResponse QueryDevicesHotStorageDataStatusWithOptions(QueryDevicesHotStorageDataStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicesHotStorageDataStatusResponse>(DoRequest("QueryDevicesHotStorageDataStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicesHotStorageDataStatusResponse> QueryDevicesHotStorageDataStatusWithOptionsAsync(QueryDevicesHotStorageDataStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicesHotStorageDataStatusResponse>(await DoRequestAsync("QueryDevicesHotStorageDataStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicesHotStorageDataStatusResponse QueryDevicesHotStorageDataStatus(QueryDevicesHotStorageDataStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesHotStorageDataStatusWithOptions(request, runtime);
        }

        public async Task<QueryDevicesHotStorageDataStatusResponse> QueryDevicesHotStorageDataStatusAsync(QueryDevicesHotStorageDataStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesHotStorageDataStatusWithOptionsAsync(request, runtime);
        }

        public QueryDynamicGroupDevicesResponse QueryDynamicGroupDevicesWithOptions(QueryDynamicGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDynamicGroupDevicesResponse>(DoRequest("QueryDynamicGroupDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDynamicGroupDevicesResponse> QueryDynamicGroupDevicesWithOptionsAsync(QueryDynamicGroupDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDynamicGroupDevicesResponse>(await DoRequestAsync("QueryDynamicGroupDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDynamicGroupDevicesResponse QueryDynamicGroupDevices(QueryDynamicGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDynamicGroupDevicesWithOptions(request, runtime);
        }

        public async Task<QueryDynamicGroupDevicesResponse> QueryDynamicGroupDevicesAsync(QueryDynamicGroupDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDynamicGroupDevicesWithOptionsAsync(request, runtime);
        }

        public QueryEdgeDriverResponse QueryEdgeDriverWithOptions(QueryEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverResponse>(DoRequest("QueryEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeDriverResponse> QueryEdgeDriverWithOptionsAsync(QueryEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverResponse>(await DoRequestAsync("QueryEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeDriverResponse QueryEdgeDriver(QueryEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeDriverResponse> QueryEdgeDriverAsync(QueryEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeDriverWithOptionsAsync(request, runtime);
        }

        public QueryEdgeDriverVersionResponse QueryEdgeDriverVersionWithOptions(QueryEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverVersionResponse>(DoRequest("QueryEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeDriverVersionResponse> QueryEdgeDriverVersionWithOptionsAsync(QueryEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverVersionResponse>(await DoRequestAsync("QueryEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeDriverVersionResponse QueryEdgeDriverVersion(QueryEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<QueryEdgeDriverVersionResponse> QueryEdgeDriverVersionAsync(QueryEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceResponse QueryEdgeInstanceWithOptions(QueryEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceResponse>(DoRequest("QueryEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceResponse> QueryEdgeInstanceWithOptionsAsync(QueryEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceResponse>(await DoRequestAsync("QueryEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceResponse QueryEdgeInstance(QueryEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceResponse> QueryEdgeInstanceAsync(QueryEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceChannelResponse QueryEdgeInstanceChannelWithOptions(QueryEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceChannelResponse>(DoRequest("QueryEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceChannelResponse> QueryEdgeInstanceChannelWithOptionsAsync(QueryEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceChannelResponse>(await DoRequestAsync("QueryEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceChannelResponse QueryEdgeInstanceChannel(QueryEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceChannelResponse> QueryEdgeInstanceChannelAsync(QueryEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDeviceResponse QueryEdgeInstanceDeviceWithOptions(QueryEdgeInstanceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceResponse>(DoRequest("QueryEdgeInstanceDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDeviceResponse> QueryEdgeInstanceDeviceWithOptionsAsync(QueryEdgeInstanceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceResponse>(await DoRequestAsync("QueryEdgeInstanceDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDeviceResponse QueryEdgeInstanceDevice(QueryEdgeInstanceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDeviceWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDeviceResponse> QueryEdgeInstanceDeviceAsync(QueryEdgeInstanceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDeviceWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDeviceByDriverResponse QueryEdgeInstanceDeviceByDriverWithOptions(QueryEdgeInstanceDeviceByDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceByDriverResponse>(DoRequest("QueryEdgeInstanceDeviceByDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDeviceByDriverResponse> QueryEdgeInstanceDeviceByDriverWithOptionsAsync(QueryEdgeInstanceDeviceByDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceByDriverResponse>(await DoRequestAsync("QueryEdgeInstanceDeviceByDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDeviceByDriverResponse QueryEdgeInstanceDeviceByDriver(QueryEdgeInstanceDeviceByDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDeviceByDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDeviceByDriverResponse> QueryEdgeInstanceDeviceByDriverAsync(QueryEdgeInstanceDeviceByDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDeviceByDriverWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDriverResponse QueryEdgeInstanceDriverWithOptions(QueryEdgeInstanceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDriverResponse>(DoRequest("QueryEdgeInstanceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDriverResponse> QueryEdgeInstanceDriverWithOptionsAsync(QueryEdgeInstanceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDriverResponse>(await DoRequestAsync("QueryEdgeInstanceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDriverResponse QueryEdgeInstanceDriver(QueryEdgeInstanceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDriverResponse> QueryEdgeInstanceDriverAsync(QueryEdgeInstanceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDriverWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceGatewayResponse QueryEdgeInstanceGatewayWithOptions(QueryEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceGatewayResponse>(DoRequest("QueryEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceGatewayResponse> QueryEdgeInstanceGatewayWithOptionsAsync(QueryEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceGatewayResponse>(await DoRequestAsync("QueryEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceGatewayResponse QueryEdgeInstanceGateway(QueryEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceGatewayWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceGatewayResponse> QueryEdgeInstanceGatewayAsync(QueryEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceGatewayWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceHistoricDeploymentResponse QueryEdgeInstanceHistoricDeploymentWithOptions(QueryEdgeInstanceHistoricDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceHistoricDeploymentResponse>(DoRequest("QueryEdgeInstanceHistoricDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceHistoricDeploymentResponse> QueryEdgeInstanceHistoricDeploymentWithOptionsAsync(QueryEdgeInstanceHistoricDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceHistoricDeploymentResponse>(await DoRequestAsync("QueryEdgeInstanceHistoricDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceHistoricDeploymentResponse QueryEdgeInstanceHistoricDeployment(QueryEdgeInstanceHistoricDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceHistoricDeploymentWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceHistoricDeploymentResponse> QueryEdgeInstanceHistoricDeploymentAsync(QueryEdgeInstanceHistoricDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceHistoricDeploymentWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceMessageRoutingResponse QueryEdgeInstanceMessageRoutingWithOptions(QueryEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceMessageRoutingResponse>(DoRequest("QueryEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceMessageRoutingResponse> QueryEdgeInstanceMessageRoutingWithOptionsAsync(QueryEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceMessageRoutingResponse>(await DoRequestAsync("QueryEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceMessageRoutingResponse QueryEdgeInstanceMessageRouting(QueryEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceMessageRoutingWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceMessageRoutingResponse> QueryEdgeInstanceMessageRoutingAsync(QueryEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceMessageRoutingWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceSceneRuleResponse QueryEdgeInstanceSceneRuleWithOptions(QueryEdgeInstanceSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceSceneRuleResponse>(DoRequest("QueryEdgeInstanceSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceSceneRuleResponse> QueryEdgeInstanceSceneRuleWithOptionsAsync(QueryEdgeInstanceSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceSceneRuleResponse>(await DoRequestAsync("QueryEdgeInstanceSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceSceneRuleResponse QueryEdgeInstanceSceneRule(QueryEdgeInstanceSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceSceneRuleWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceSceneRuleResponse> QueryEdgeInstanceSceneRuleAsync(QueryEdgeInstanceSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceSceneRuleWithOptionsAsync(request, runtime);
        }

        public QueryImportedDeviceByApplyIdResponse QueryImportedDeviceByApplyIdWithOptions(QueryImportedDeviceByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryImportedDeviceByApplyIdResponse>(DoRequest("QueryImportedDeviceByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryImportedDeviceByApplyIdResponse> QueryImportedDeviceByApplyIdWithOptionsAsync(QueryImportedDeviceByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryImportedDeviceByApplyIdResponse>(await DoRequestAsync("QueryImportedDeviceByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryImportedDeviceByApplyIdResponse QueryImportedDeviceByApplyId(QueryImportedDeviceByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryImportedDeviceByApplyIdWithOptions(request, runtime);
        }

        public async Task<QueryImportedDeviceByApplyIdResponse> QueryImportedDeviceByApplyIdAsync(QueryImportedDeviceByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryImportedDeviceByApplyIdWithOptionsAsync(request, runtime);
        }

        public QueryJobResponse QueryJobWithOptions(QueryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobResponse>(DoRequest("QueryJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryJobResponse> QueryJobWithOptionsAsync(QueryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobResponse>(await DoRequestAsync("QueryJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryJobResponse QueryJob(QueryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobWithOptions(request, runtime);
        }

        public async Task<QueryJobResponse> QueryJobAsync(QueryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobWithOptionsAsync(request, runtime);
        }

        public QueryJobStatisticsResponse QueryJobStatisticsWithOptions(QueryJobStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobStatisticsResponse>(DoRequest("QueryJobStatistics", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<QueryJobStatisticsResponse> QueryJobStatisticsWithOptionsAsync(QueryJobStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobStatisticsResponse>(await DoRequestAsync("QueryJobStatistics", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public QueryJobStatisticsResponse QueryJobStatistics(QueryJobStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobStatisticsWithOptions(request, runtime);
        }

        public async Task<QueryJobStatisticsResponse> QueryJobStatisticsAsync(QueryJobStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobStatisticsWithOptionsAsync(request, runtime);
        }

        public QueryLicenseDeviceListResponse QueryLicenseDeviceListWithOptions(QueryLicenseDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLicenseDeviceListResponse>(DoRequest("QueryLicenseDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryLicenseDeviceListResponse> QueryLicenseDeviceListWithOptionsAsync(QueryLicenseDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLicenseDeviceListResponse>(await DoRequestAsync("QueryLicenseDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryLicenseDeviceListResponse QueryLicenseDeviceList(QueryLicenseDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLicenseDeviceListWithOptions(request, runtime);
        }

        public async Task<QueryLicenseDeviceListResponse> QueryLicenseDeviceListAsync(QueryLicenseDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLicenseDeviceListWithOptionsAsync(request, runtime);
        }

        public QueryLoRaJoinPermissionsResponse QueryLoRaJoinPermissionsWithOptions(QueryLoRaJoinPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLoRaJoinPermissionsResponse>(DoRequest("QueryLoRaJoinPermissions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryLoRaJoinPermissionsResponse> QueryLoRaJoinPermissionsWithOptionsAsync(QueryLoRaJoinPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLoRaJoinPermissionsResponse>(await DoRequestAsync("QueryLoRaJoinPermissions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryLoRaJoinPermissionsResponse QueryLoRaJoinPermissions(QueryLoRaJoinPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLoRaJoinPermissionsWithOptions(request, runtime);
        }

        public async Task<QueryLoRaJoinPermissionsResponse> QueryLoRaJoinPermissionsAsync(QueryLoRaJoinPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLoRaJoinPermissionsWithOptionsAsync(request, runtime);
        }

        public QueryMessageInfoResponse QueryMessageInfoWithOptions(QueryMessageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryMessageInfoResponse>(DoRequest("QueryMessageInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryMessageInfoResponse> QueryMessageInfoWithOptionsAsync(QueryMessageInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryMessageInfoResponse>(await DoRequestAsync("QueryMessageInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryMessageInfoResponse QueryMessageInfo(QueryMessageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessageInfoWithOptions(request, runtime);
        }

        public async Task<QueryMessageInfoResponse> QueryMessageInfoAsync(QueryMessageInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessageInfoWithOptionsAsync(request, runtime);
        }

        public QueryOTAFirmwareResponse QueryOTAFirmwareWithOptions(QueryOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAFirmwareResponse>(DoRequest("QueryOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryOTAFirmwareResponse> QueryOTAFirmwareWithOptionsAsync(QueryOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAFirmwareResponse>(await DoRequestAsync("QueryOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryOTAFirmwareResponse QueryOTAFirmware(QueryOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<QueryOTAFirmwareResponse> QueryOTAFirmwareAsync(QueryOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public QueryOTAJobResponse QueryOTAJobWithOptions(QueryOTAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAJobResponse>(DoRequest("QueryOTAJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryOTAJobResponse> QueryOTAJobWithOptionsAsync(QueryOTAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAJobResponse>(await DoRequestAsync("QueryOTAJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryOTAJobResponse QueryOTAJob(QueryOTAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOTAJobWithOptions(request, runtime);
        }

        public async Task<QueryOTAJobResponse> QueryOTAJobAsync(QueryOTAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOTAJobWithOptionsAsync(request, runtime);
        }

        public QueryPageByApplyIdResponse QueryPageByApplyIdWithOptions(QueryPageByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPageByApplyIdResponse>(DoRequest("QueryPageByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryPageByApplyIdResponse> QueryPageByApplyIdWithOptionsAsync(QueryPageByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPageByApplyIdResponse>(await DoRequestAsync("QueryPageByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryPageByApplyIdResponse QueryPageByApplyId(QueryPageByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPageByApplyIdWithOptions(request, runtime);
        }

        public async Task<QueryPageByApplyIdResponse> QueryPageByApplyIdAsync(QueryPageByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPageByApplyIdWithOptionsAsync(request, runtime);
        }

        public QueryProductResponse QueryProductWithOptions(QueryProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductResponse>(DoRequest("QueryProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductResponse> QueryProductWithOptionsAsync(QueryProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductResponse>(await DoRequestAsync("QueryProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductResponse QueryProduct(QueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductWithOptions(request, runtime);
        }

        public async Task<QueryProductResponse> QueryProductAsync(QueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductWithOptionsAsync(request, runtime);
        }

        public QueryProductCertInfoResponse QueryProductCertInfoWithOptions(QueryProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductCertInfoResponse>(DoRequest("QueryProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductCertInfoResponse> QueryProductCertInfoWithOptionsAsync(QueryProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductCertInfoResponse>(await DoRequestAsync("QueryProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductCertInfoResponse QueryProductCertInfo(QueryProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductCertInfoWithOptions(request, runtime);
        }

        public async Task<QueryProductCertInfoResponse> QueryProductCertInfoAsync(QueryProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductCertInfoWithOptionsAsync(request, runtime);
        }

        public QueryProductListResponse QueryProductListWithOptions(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductListResponse>(DoRequest("QueryProductList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductListResponse> QueryProductListWithOptionsAsync(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductListResponse>(await DoRequestAsync("QueryProductList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductListResponse QueryProductList(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductListWithOptions(request, runtime);
        }

        public async Task<QueryProductListResponse> QueryProductListAsync(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductListWithOptionsAsync(request, runtime);
        }

        public QueryProductTopicResponse QueryProductTopicWithOptions(QueryProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductTopicResponse>(DoRequest("QueryProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductTopicResponse> QueryProductTopicWithOptionsAsync(QueryProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductTopicResponse>(await DoRequestAsync("QueryProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductTopicResponse QueryProductTopic(QueryProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductTopicWithOptions(request, runtime);
        }

        public async Task<QueryProductTopicResponse> QueryProductTopicAsync(QueryProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductTopicWithOptionsAsync(request, runtime);
        }

        public QueryProjectShareDeviceListResponse QueryProjectShareDeviceListWithOptions(QueryProjectShareDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProjectShareDeviceListResponse>(DoRequest("QueryProjectShareDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProjectShareDeviceListResponse> QueryProjectShareDeviceListWithOptionsAsync(QueryProjectShareDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProjectShareDeviceListResponse>(await DoRequestAsync("QueryProjectShareDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProjectShareDeviceListResponse QueryProjectShareDeviceList(QueryProjectShareDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProjectShareDeviceListWithOptions(request, runtime);
        }

        public async Task<QueryProjectShareDeviceListResponse> QueryProjectShareDeviceListAsync(QueryProjectShareDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProjectShareDeviceListWithOptionsAsync(request, runtime);
        }

        public QuerySceneRuleResponse QuerySceneRuleWithOptions(QuerySceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySceneRuleResponse>(DoRequest("QuerySceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySceneRuleResponse> QuerySceneRuleWithOptionsAsync(QuerySceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySceneRuleResponse>(await DoRequestAsync("QuerySceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySceneRuleResponse QuerySceneRule(QuerySceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySceneRuleWithOptions(request, runtime);
        }

        public async Task<QuerySceneRuleResponse> QuerySceneRuleAsync(QuerySceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySceneRuleWithOptionsAsync(request, runtime);
        }

        public QuerySchedulePeriodListResponse QuerySchedulePeriodListWithOptions(QuerySchedulePeriodListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySchedulePeriodListResponse>(DoRequest("QuerySchedulePeriodList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySchedulePeriodListResponse> QuerySchedulePeriodListWithOptionsAsync(QuerySchedulePeriodListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySchedulePeriodListResponse>(await DoRequestAsync("QuerySchedulePeriodList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySchedulePeriodListResponse QuerySchedulePeriodList(QuerySchedulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySchedulePeriodListWithOptions(request, runtime);
        }

        public async Task<QuerySchedulePeriodListResponse> QuerySchedulePeriodListAsync(QuerySchedulePeriodListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySchedulePeriodListWithOptionsAsync(request, runtime);
        }

        public QueryShareTaskDeviceListResponse QueryShareTaskDeviceListWithOptions(QueryShareTaskDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryShareTaskDeviceListResponse>(DoRequest("QueryShareTaskDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryShareTaskDeviceListResponse> QueryShareTaskDeviceListWithOptionsAsync(QueryShareTaskDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryShareTaskDeviceListResponse>(await DoRequestAsync("QueryShareTaskDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryShareTaskDeviceListResponse QueryShareTaskDeviceList(QueryShareTaskDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryShareTaskDeviceListWithOptions(request, runtime);
        }

        public async Task<QueryShareTaskDeviceListResponse> QueryShareTaskDeviceListAsync(QueryShareTaskDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryShareTaskDeviceListWithOptionsAsync(request, runtime);
        }

        public QuerySolutionDeviceGroupPageResponse QuerySolutionDeviceGroupPageWithOptions(QuerySolutionDeviceGroupPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySolutionDeviceGroupPageResponse>(DoRequest("QuerySolutionDeviceGroupPage", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySolutionDeviceGroupPageResponse> QuerySolutionDeviceGroupPageWithOptionsAsync(QuerySolutionDeviceGroupPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySolutionDeviceGroupPageResponse>(await DoRequestAsync("QuerySolutionDeviceGroupPage", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySolutionDeviceGroupPageResponse QuerySolutionDeviceGroupPage(QuerySolutionDeviceGroupPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySolutionDeviceGroupPageWithOptions(request, runtime);
        }

        public async Task<QuerySolutionDeviceGroupPageResponse> QuerySolutionDeviceGroupPageAsync(QuerySolutionDeviceGroupPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySolutionDeviceGroupPageWithOptionsAsync(request, runtime);
        }

        public QuerySoundCodeLabelBatchFailedResultResponse QuerySoundCodeLabelBatchFailedResultWithOptions(QuerySoundCodeLabelBatchFailedResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelBatchFailedResultResponse>(DoRequest("QuerySoundCodeLabelBatchFailedResult", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySoundCodeLabelBatchFailedResultResponse> QuerySoundCodeLabelBatchFailedResultWithOptionsAsync(QuerySoundCodeLabelBatchFailedResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelBatchFailedResultResponse>(await DoRequestAsync("QuerySoundCodeLabelBatchFailedResult", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySoundCodeLabelBatchFailedResultResponse QuerySoundCodeLabelBatchFailedResult(QuerySoundCodeLabelBatchFailedResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundCodeLabelBatchFailedResultWithOptions(request, runtime);
        }

        public async Task<QuerySoundCodeLabelBatchFailedResultResponse> QuerySoundCodeLabelBatchFailedResultAsync(QuerySoundCodeLabelBatchFailedResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundCodeLabelBatchFailedResultWithOptionsAsync(request, runtime);
        }

        public QuerySoundCodeLabelBatchListResponse QuerySoundCodeLabelBatchListWithOptions(QuerySoundCodeLabelBatchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelBatchListResponse>(DoRequest("QuerySoundCodeLabelBatchList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySoundCodeLabelBatchListResponse> QuerySoundCodeLabelBatchListWithOptionsAsync(QuerySoundCodeLabelBatchListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelBatchListResponse>(await DoRequestAsync("QuerySoundCodeLabelBatchList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySoundCodeLabelBatchListResponse QuerySoundCodeLabelBatchList(QuerySoundCodeLabelBatchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundCodeLabelBatchListWithOptions(request, runtime);
        }

        public async Task<QuerySoundCodeLabelBatchListResponse> QuerySoundCodeLabelBatchListAsync(QuerySoundCodeLabelBatchListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundCodeLabelBatchListWithOptionsAsync(request, runtime);
        }

        public QuerySoundCodeLabelListResponse QuerySoundCodeLabelListWithOptions(QuerySoundCodeLabelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelListResponse>(DoRequest("QuerySoundCodeLabelList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySoundCodeLabelListResponse> QuerySoundCodeLabelListWithOptionsAsync(QuerySoundCodeLabelListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeLabelListResponse>(await DoRequestAsync("QuerySoundCodeLabelList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySoundCodeLabelListResponse QuerySoundCodeLabelList(QuerySoundCodeLabelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundCodeLabelListWithOptions(request, runtime);
        }

        public async Task<QuerySoundCodeLabelListResponse> QuerySoundCodeLabelListAsync(QuerySoundCodeLabelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundCodeLabelListWithOptionsAsync(request, runtime);
        }

        public QuerySoundCodeListResponse QuerySoundCodeListWithOptions(QuerySoundCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeListResponse>(DoRequest("QuerySoundCodeList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySoundCodeListResponse> QuerySoundCodeListWithOptionsAsync(QuerySoundCodeListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeListResponse>(await DoRequestAsync("QuerySoundCodeList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySoundCodeListResponse QuerySoundCodeList(QuerySoundCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundCodeListWithOptions(request, runtime);
        }

        public async Task<QuerySoundCodeListResponse> QuerySoundCodeListAsync(QuerySoundCodeListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundCodeListWithOptionsAsync(request, runtime);
        }

        public QuerySoundCodeScheduleListResponse QuerySoundCodeScheduleListWithOptions(QuerySoundCodeScheduleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeScheduleListResponse>(DoRequest("QuerySoundCodeScheduleList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySoundCodeScheduleListResponse> QuerySoundCodeScheduleListWithOptionsAsync(QuerySoundCodeScheduleListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySoundCodeScheduleListResponse>(await DoRequestAsync("QuerySoundCodeScheduleList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySoundCodeScheduleListResponse QuerySoundCodeScheduleList(QuerySoundCodeScheduleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySoundCodeScheduleListWithOptions(request, runtime);
        }

        public async Task<QuerySoundCodeScheduleListResponse> QuerySoundCodeScheduleListAsync(QuerySoundCodeScheduleListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySoundCodeScheduleListWithOptionsAsync(request, runtime);
        }

        public QuerySpeechResponse QuerySpeechWithOptions(QuerySpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechResponse>(DoRequest("QuerySpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechResponse> QuerySpeechWithOptionsAsync(QuerySpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechResponse>(await DoRequestAsync("QuerySpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechResponse QuerySpeech(QuerySpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechWithOptions(request, runtime);
        }

        public async Task<QuerySpeechResponse> QuerySpeechAsync(QuerySpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechWithOptionsAsync(request, runtime);
        }

        public QuerySpeechDeviceResponse QuerySpeechDeviceWithOptions(QuerySpeechDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechDeviceResponse>(DoRequest("QuerySpeechDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechDeviceResponse> QuerySpeechDeviceWithOptionsAsync(QuerySpeechDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechDeviceResponse>(await DoRequestAsync("QuerySpeechDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechDeviceResponse QuerySpeechDevice(QuerySpeechDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechDeviceWithOptions(request, runtime);
        }

        public async Task<QuerySpeechDeviceResponse> QuerySpeechDeviceAsync(QuerySpeechDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechDeviceWithOptionsAsync(request, runtime);
        }

        public QuerySpeechLicenseDeviceListResponse QuerySpeechLicenseDeviceListWithOptions(QuerySpeechLicenseDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechLicenseDeviceListResponse>(DoRequest("QuerySpeechLicenseDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechLicenseDeviceListResponse> QuerySpeechLicenseDeviceListWithOptionsAsync(QuerySpeechLicenseDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechLicenseDeviceListResponse>(await DoRequestAsync("QuerySpeechLicenseDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechLicenseDeviceListResponse QuerySpeechLicenseDeviceList(QuerySpeechLicenseDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechLicenseDeviceListWithOptions(request, runtime);
        }

        public async Task<QuerySpeechLicenseDeviceListResponse> QuerySpeechLicenseDeviceListAsync(QuerySpeechLicenseDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechLicenseDeviceListWithOptionsAsync(request, runtime);
        }

        public QuerySpeechListResponse QuerySpeechListWithOptions(QuerySpeechListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechListResponse>(DoRequest("QuerySpeechList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechListResponse> QuerySpeechListWithOptionsAsync(QuerySpeechListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechListResponse>(await DoRequestAsync("QuerySpeechList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechListResponse QuerySpeechList(QuerySpeechListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechListWithOptions(request, runtime);
        }

        public async Task<QuerySpeechListResponse> QuerySpeechListAsync(QuerySpeechListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechListWithOptionsAsync(request, runtime);
        }

        public QuerySpeechPushJobResponse QuerySpeechPushJobWithOptions(QuerySpeechPushJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobResponse>(DoRequest("QuerySpeechPushJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechPushJobResponse> QuerySpeechPushJobWithOptionsAsync(QuerySpeechPushJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobResponse>(await DoRequestAsync("QuerySpeechPushJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechPushJobResponse QuerySpeechPushJob(QuerySpeechPushJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechPushJobWithOptions(request, runtime);
        }

        public async Task<QuerySpeechPushJobResponse> QuerySpeechPushJobAsync(QuerySpeechPushJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechPushJobWithOptionsAsync(request, runtime);
        }

        public QuerySpeechPushJobDeviceResponse QuerySpeechPushJobDeviceWithOptions(QuerySpeechPushJobDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobDeviceResponse>(DoRequest("QuerySpeechPushJobDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechPushJobDeviceResponse> QuerySpeechPushJobDeviceWithOptionsAsync(QuerySpeechPushJobDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobDeviceResponse>(await DoRequestAsync("QuerySpeechPushJobDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechPushJobDeviceResponse QuerySpeechPushJobDevice(QuerySpeechPushJobDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechPushJobDeviceWithOptions(request, runtime);
        }

        public async Task<QuerySpeechPushJobDeviceResponse> QuerySpeechPushJobDeviceAsync(QuerySpeechPushJobDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechPushJobDeviceWithOptionsAsync(request, runtime);
        }

        public QuerySpeechPushJobSpeechResponse QuerySpeechPushJobSpeechWithOptions(QuerySpeechPushJobSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobSpeechResponse>(DoRequest("QuerySpeechPushJobSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySpeechPushJobSpeechResponse> QuerySpeechPushJobSpeechWithOptionsAsync(QuerySpeechPushJobSpeechRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySpeechPushJobSpeechResponse>(await DoRequestAsync("QuerySpeechPushJobSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySpeechPushJobSpeechResponse QuerySpeechPushJobSpeech(QuerySpeechPushJobSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySpeechPushJobSpeechWithOptions(request, runtime);
        }

        public async Task<QuerySpeechPushJobSpeechResponse> QuerySpeechPushJobSpeechAsync(QuerySpeechPushJobSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySpeechPushJobSpeechWithOptionsAsync(request, runtime);
        }

        public QueryStudioAppDomainListOpenResponse QueryStudioAppDomainListOpenWithOptions(QueryStudioAppDomainListOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppDomainListOpenResponse>(DoRequest("QueryStudioAppDomainListOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryStudioAppDomainListOpenResponse> QueryStudioAppDomainListOpenWithOptionsAsync(QueryStudioAppDomainListOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppDomainListOpenResponse>(await DoRequestAsync("QueryStudioAppDomainListOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryStudioAppDomainListOpenResponse QueryStudioAppDomainListOpen(QueryStudioAppDomainListOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStudioAppDomainListOpenWithOptions(request, runtime);
        }

        public async Task<QueryStudioAppDomainListOpenResponse> QueryStudioAppDomainListOpenAsync(QueryStudioAppDomainListOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStudioAppDomainListOpenWithOptionsAsync(request, runtime);
        }

        public QueryStudioAppListResponse QueryStudioAppListWithOptions(QueryStudioAppListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppListResponse>(DoRequest("QueryStudioAppList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryStudioAppListResponse> QueryStudioAppListWithOptionsAsync(QueryStudioAppListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppListResponse>(await DoRequestAsync("QueryStudioAppList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryStudioAppListResponse QueryStudioAppList(QueryStudioAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStudioAppListWithOptions(request, runtime);
        }

        public async Task<QueryStudioAppListResponse> QueryStudioAppListAsync(QueryStudioAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStudioAppListWithOptionsAsync(request, runtime);
        }

        public QueryStudioAppPageListOpenResponse QueryStudioAppPageListOpenWithOptions(QueryStudioAppPageListOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppPageListOpenResponse>(DoRequest("QueryStudioAppPageListOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryStudioAppPageListOpenResponse> QueryStudioAppPageListOpenWithOptionsAsync(QueryStudioAppPageListOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioAppPageListOpenResponse>(await DoRequestAsync("QueryStudioAppPageListOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryStudioAppPageListOpenResponse QueryStudioAppPageListOpen(QueryStudioAppPageListOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStudioAppPageListOpenWithOptions(request, runtime);
        }

        public async Task<QueryStudioAppPageListOpenResponse> QueryStudioAppPageListOpenAsync(QueryStudioAppPageListOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStudioAppPageListOpenWithOptionsAsync(request, runtime);
        }

        public QueryStudioProjectListResponse QueryStudioProjectListWithOptions(QueryStudioProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioProjectListResponse>(DoRequest("QueryStudioProjectList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryStudioProjectListResponse> QueryStudioProjectListWithOptionsAsync(QueryStudioProjectListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryStudioProjectListResponse>(await DoRequestAsync("QueryStudioProjectList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryStudioProjectListResponse QueryStudioProjectList(QueryStudioProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryStudioProjectListWithOptions(request, runtime);
        }

        public async Task<QueryStudioProjectListResponse> QueryStudioProjectListAsync(QueryStudioProjectListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryStudioProjectListWithOptionsAsync(request, runtime);
        }

        public QuerySubscribeRelationResponse QuerySubscribeRelationWithOptions(QuerySubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySubscribeRelationResponse>(DoRequest("QuerySubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySubscribeRelationResponse> QuerySubscribeRelationWithOptionsAsync(QuerySubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySubscribeRelationResponse>(await DoRequestAsync("QuerySubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySubscribeRelationResponse QuerySubscribeRelation(QuerySubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscribeRelationWithOptions(request, runtime);
        }

        public async Task<QuerySubscribeRelationResponse> QuerySubscribeRelationAsync(QuerySubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscribeRelationWithOptionsAsync(request, runtime);
        }

        public QuerySummarySceneRuleLogResponse QuerySummarySceneRuleLogWithOptions(QuerySummarySceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySummarySceneRuleLogResponse>(DoRequest("QuerySummarySceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySummarySceneRuleLogResponse> QuerySummarySceneRuleLogWithOptionsAsync(QuerySummarySceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySummarySceneRuleLogResponse>(await DoRequestAsync("QuerySummarySceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySummarySceneRuleLogResponse QuerySummarySceneRuleLog(QuerySummarySceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySummarySceneRuleLogWithOptions(request, runtime);
        }

        public async Task<QuerySummarySceneRuleLogResponse> QuerySummarySceneRuleLogAsync(QuerySummarySceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySummarySceneRuleLogWithOptionsAsync(request, runtime);
        }

        public QuerySuperDeviceGroupResponse QuerySuperDeviceGroupWithOptions(QuerySuperDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySuperDeviceGroupResponse>(DoRequest("QuerySuperDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySuperDeviceGroupResponse> QuerySuperDeviceGroupWithOptionsAsync(QuerySuperDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySuperDeviceGroupResponse>(await DoRequestAsync("QuerySuperDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySuperDeviceGroupResponse QuerySuperDeviceGroup(QuerySuperDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySuperDeviceGroupWithOptions(request, runtime);
        }

        public async Task<QuerySuperDeviceGroupResponse> QuerySuperDeviceGroupAsync(QuerySuperDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySuperDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryTaskResponse QueryTaskWithOptions(QueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTaskResponse>(DoRequest("QueryTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTaskResponse> QueryTaskWithOptionsAsync(QueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTaskResponse>(await DoRequestAsync("QueryTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTaskResponse QueryTask(QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskWithOptions(request, runtime);
        }

        public async Task<QueryTaskResponse> QueryTaskAsync(QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskWithOptionsAsync(request, runtime);
        }

        public QueryThingModelResponse QueryThingModelWithOptions(QueryThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelResponse>(DoRequest("QueryThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelResponse> QueryThingModelWithOptionsAsync(QueryThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelResponse>(await DoRequestAsync("QueryThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelResponse QueryThingModel(QueryThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelWithOptions(request, runtime);
        }

        public async Task<QueryThingModelResponse> QueryThingModelAsync(QueryThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelWithOptionsAsync(request, runtime);
        }

        public QueryThingModelExtendConfigResponse QueryThingModelExtendConfigWithOptions(QueryThingModelExtendConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigResponse>(DoRequest("QueryThingModelExtendConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelExtendConfigResponse> QueryThingModelExtendConfigWithOptionsAsync(QueryThingModelExtendConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigResponse>(await DoRequestAsync("QueryThingModelExtendConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelExtendConfigResponse QueryThingModelExtendConfig(QueryThingModelExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelExtendConfigWithOptions(request, runtime);
        }

        public async Task<QueryThingModelExtendConfigResponse> QueryThingModelExtendConfigAsync(QueryThingModelExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelExtendConfigWithOptionsAsync(request, runtime);
        }

        public QueryThingModelExtendConfigPublishedResponse QueryThingModelExtendConfigPublishedWithOptions(QueryThingModelExtendConfigPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigPublishedResponse>(DoRequest("QueryThingModelExtendConfigPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelExtendConfigPublishedResponse> QueryThingModelExtendConfigPublishedWithOptionsAsync(QueryThingModelExtendConfigPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigPublishedResponse>(await DoRequestAsync("QueryThingModelExtendConfigPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelExtendConfigPublishedResponse QueryThingModelExtendConfigPublished(QueryThingModelExtendConfigPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelExtendConfigPublishedWithOptions(request, runtime);
        }

        public async Task<QueryThingModelExtendConfigPublishedResponse> QueryThingModelExtendConfigPublishedAsync(QueryThingModelExtendConfigPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelExtendConfigPublishedWithOptionsAsync(request, runtime);
        }

        public QueryThingModelPublishedResponse QueryThingModelPublishedWithOptions(QueryThingModelPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelPublishedResponse>(DoRequest("QueryThingModelPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelPublishedResponse> QueryThingModelPublishedWithOptionsAsync(QueryThingModelPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelPublishedResponse>(await DoRequestAsync("QueryThingModelPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelPublishedResponse QueryThingModelPublished(QueryThingModelPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelPublishedWithOptions(request, runtime);
        }

        public async Task<QueryThingModelPublishedResponse> QueryThingModelPublishedAsync(QueryThingModelPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelPublishedWithOptionsAsync(request, runtime);
        }

        public QueryTopicReverseRouteTableResponse QueryTopicReverseRouteTableWithOptions(QueryTopicReverseRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicReverseRouteTableResponse>(DoRequest("QueryTopicReverseRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTopicReverseRouteTableResponse> QueryTopicReverseRouteTableWithOptionsAsync(QueryTopicReverseRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicReverseRouteTableResponse>(await DoRequestAsync("QueryTopicReverseRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTopicReverseRouteTableResponse QueryTopicReverseRouteTable(QueryTopicReverseRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTopicReverseRouteTableWithOptions(request, runtime);
        }

        public async Task<QueryTopicReverseRouteTableResponse> QueryTopicReverseRouteTableAsync(QueryTopicReverseRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTopicReverseRouteTableWithOptionsAsync(request, runtime);
        }

        public QueryTopicRouteTableResponse QueryTopicRouteTableWithOptions(QueryTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicRouteTableResponse>(DoRequest("QueryTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTopicRouteTableResponse> QueryTopicRouteTableWithOptionsAsync(QueryTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicRouteTableResponse>(await DoRequestAsync("QueryTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTopicRouteTableResponse QueryTopicRouteTable(QueryTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<QueryTopicRouteTableResponse> QueryTopicRouteTableAsync(QueryTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public QueryVehicleDeviceResponse QueryVehicleDeviceWithOptions(QueryVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryVehicleDeviceResponse>(DoRequest("QueryVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryVehicleDeviceResponse> QueryVehicleDeviceWithOptionsAsync(QueryVehicleDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryVehicleDeviceResponse>(await DoRequestAsync("QueryVehicleDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryVehicleDeviceResponse QueryVehicleDevice(QueryVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVehicleDeviceWithOptions(request, runtime);
        }

        public async Task<QueryVehicleDeviceResponse> QueryVehicleDeviceAsync(QueryVehicleDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVehicleDeviceWithOptionsAsync(request, runtime);
        }

        public RRpcResponse RRpcWithOptions(RRpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RRpcResponse>(DoRequest("RRpc", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RRpcResponse> RRpcWithOptionsAsync(RRpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RRpcResponse>(await DoRequestAsync("RRpc", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RRpcResponse RRpc(RRpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RRpcWithOptions(request, runtime);
        }

        public async Task<RRpcResponse> RRpcAsync(RRpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RRpcWithOptionsAsync(request, runtime);
        }

        public ReBindLicenseDeviceResponse ReBindLicenseDeviceWithOptions(ReBindLicenseDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReBindLicenseDeviceResponse>(DoRequest("ReBindLicenseDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReBindLicenseDeviceResponse> ReBindLicenseDeviceWithOptionsAsync(ReBindLicenseDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReBindLicenseDeviceResponse>(await DoRequestAsync("ReBindLicenseDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReBindLicenseDeviceResponse ReBindLicenseDevice(ReBindLicenseDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReBindLicenseDeviceWithOptions(request, runtime);
        }

        public async Task<ReBindLicenseDeviceResponse> ReBindLicenseDeviceAsync(ReBindLicenseDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReBindLicenseDeviceWithOptionsAsync(request, runtime);
        }

        public RecognizeCarNumResponse RecognizeCarNumWithOptions(RecognizeCarNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeCarNumResponse>(DoRequest("RecognizeCarNum", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RecognizeCarNumResponse> RecognizeCarNumWithOptionsAsync(RecognizeCarNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizeCarNumResponse>(await DoRequestAsync("RecognizeCarNum", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RecognizeCarNumResponse RecognizeCarNum(RecognizeCarNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCarNumWithOptions(request, runtime);
        }

        public async Task<RecognizeCarNumResponse> RecognizeCarNumAsync(RecognizeCarNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCarNumWithOptionsAsync(request, runtime);
        }

        public RecognizePictureGeneralResponse RecognizePictureGeneralWithOptions(RecognizePictureGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizePictureGeneralResponse>(DoRequest("RecognizePictureGeneral", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RecognizePictureGeneralResponse> RecognizePictureGeneralWithOptionsAsync(RecognizePictureGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RecognizePictureGeneralResponse>(await DoRequestAsync("RecognizePictureGeneral", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RecognizePictureGeneralResponse RecognizePictureGeneral(RecognizePictureGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePictureGeneralWithOptions(request, runtime);
        }

        public async Task<RecognizePictureGeneralResponse> RecognizePictureGeneralAsync(RecognizePictureGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePictureGeneralWithOptionsAsync(request, runtime);
        }

        public RefreshDeviceTunnelSharePasswordResponse RefreshDeviceTunnelSharePasswordWithOptions(RefreshDeviceTunnelSharePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RefreshDeviceTunnelSharePasswordResponse>(DoRequest("RefreshDeviceTunnelSharePassword", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RefreshDeviceTunnelSharePasswordResponse> RefreshDeviceTunnelSharePasswordWithOptionsAsync(RefreshDeviceTunnelSharePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RefreshDeviceTunnelSharePasswordResponse>(await DoRequestAsync("RefreshDeviceTunnelSharePassword", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RefreshDeviceTunnelSharePasswordResponse RefreshDeviceTunnelSharePassword(RefreshDeviceTunnelSharePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDeviceTunnelSharePasswordWithOptions(request, runtime);
        }

        public async Task<RefreshDeviceTunnelSharePasswordResponse> RefreshDeviceTunnelSharePasswordAsync(RefreshDeviceTunnelSharePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDeviceTunnelSharePasswordWithOptionsAsync(request, runtime);
        }

        public RefreshStudioAppTokenOpenResponse RefreshStudioAppTokenOpenWithOptions(RefreshStudioAppTokenOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RefreshStudioAppTokenOpenResponse>(DoRequest("RefreshStudioAppTokenOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RefreshStudioAppTokenOpenResponse> RefreshStudioAppTokenOpenWithOptionsAsync(RefreshStudioAppTokenOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RefreshStudioAppTokenOpenResponse>(await DoRequestAsync("RefreshStudioAppTokenOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RefreshStudioAppTokenOpenResponse RefreshStudioAppTokenOpen(RefreshStudioAppTokenOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshStudioAppTokenOpenWithOptions(request, runtime);
        }

        public async Task<RefreshStudioAppTokenOpenResponse> RefreshStudioAppTokenOpenAsync(RefreshStudioAppTokenOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshStudioAppTokenOpenWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(DoRequest("RegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(await DoRequestAsync("RegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        public ReleaseEdgeDriverVersionResponse ReleaseEdgeDriverVersionWithOptions(ReleaseEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEdgeDriverVersionResponse>(DoRequest("ReleaseEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseEdgeDriverVersionResponse> ReleaseEdgeDriverVersionWithOptionsAsync(ReleaseEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEdgeDriverVersionResponse>(await DoRequestAsync("ReleaseEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseEdgeDriverVersionResponse ReleaseEdgeDriverVersion(ReleaseEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<ReleaseEdgeDriverVersionResponse> ReleaseEdgeDriverVersionAsync(ReleaseEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public ReleaseProductResponse ReleaseProductWithOptions(ReleaseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseProductResponse>(DoRequest("ReleaseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseProductResponse> ReleaseProductWithOptionsAsync(ReleaseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseProductResponse>(await DoRequestAsync("ReleaseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseProductResponse ReleaseProduct(ReleaseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseProductWithOptions(request, runtime);
        }

        public async Task<ReleaseProductResponse> ReleaseProductAsync(ReleaseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseProductWithOptionsAsync(request, runtime);
        }

        public RemoveThingTopoResponse RemoveThingTopoWithOptions(RemoveThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveThingTopoResponse>(DoRequest("RemoveThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveThingTopoResponse> RemoveThingTopoWithOptionsAsync(RemoveThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveThingTopoResponse>(await DoRequestAsync("RemoveThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RemoveThingTopoResponse RemoveThingTopo(RemoveThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveThingTopoWithOptions(request, runtime);
        }

        public async Task<RemoveThingTopoResponse> RemoveThingTopoAsync(RemoveThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveThingTopoWithOptionsAsync(request, runtime);
        }

        public ReplaceEdgeInstanceGatewayResponse ReplaceEdgeInstanceGatewayWithOptions(ReplaceEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReplaceEdgeInstanceGatewayResponse>(DoRequest("ReplaceEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReplaceEdgeInstanceGatewayResponse> ReplaceEdgeInstanceGatewayWithOptionsAsync(ReplaceEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReplaceEdgeInstanceGatewayResponse>(await DoRequestAsync("ReplaceEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReplaceEdgeInstanceGatewayResponse ReplaceEdgeInstanceGateway(ReplaceEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceEdgeInstanceGatewayWithOptions(request, runtime);
        }

        public async Task<ReplaceEdgeInstanceGatewayResponse> ReplaceEdgeInstanceGatewayAsync(ReplaceEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceEdgeInstanceGatewayWithOptionsAsync(request, runtime);
        }

        public RerunJobResponse RerunJobWithOptions(RerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RerunJobResponse>(DoRequest("RerunJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RerunJobResponse> RerunJobWithOptionsAsync(RerunJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RerunJobResponse>(await DoRequestAsync("RerunJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RerunJobResponse RerunJob(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunJobWithOptions(request, runtime);
        }

        public async Task<RerunJobResponse> RerunJobAsync(RerunJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunJobWithOptionsAsync(request, runtime);
        }

        public ResetConsumerGroupPositionResponse ResetConsumerGroupPositionWithOptions(ResetConsumerGroupPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetConsumerGroupPositionResponse>(DoRequest("ResetConsumerGroupPosition", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetConsumerGroupPositionResponse> ResetConsumerGroupPositionWithOptionsAsync(ResetConsumerGroupPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetConsumerGroupPositionResponse>(await DoRequestAsync("ResetConsumerGroupPosition", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ResetConsumerGroupPositionResponse ResetConsumerGroupPosition(ResetConsumerGroupPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetConsumerGroupPositionWithOptions(request, runtime);
        }

        public async Task<ResetConsumerGroupPositionResponse> ResetConsumerGroupPositionAsync(ResetConsumerGroupPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetConsumerGroupPositionWithOptionsAsync(request, runtime);
        }

        public ResetThingResponse ResetThingWithOptions(ResetThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetThingResponse>(DoRequest("ResetThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetThingResponse> ResetThingWithOptionsAsync(ResetThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetThingResponse>(await DoRequestAsync("ResetThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ResetThingResponse ResetThing(ResetThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetThingWithOptions(request, runtime);
        }

        public async Task<ResetThingResponse> ResetThingAsync(ResetThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetThingWithOptionsAsync(request, runtime);
        }

        public RetrySoundCodeLabelBatchResponse RetrySoundCodeLabelBatchWithOptions(RetrySoundCodeLabelBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RetrySoundCodeLabelBatchResponse>(DoRequest("RetrySoundCodeLabelBatch", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RetrySoundCodeLabelBatchResponse> RetrySoundCodeLabelBatchWithOptionsAsync(RetrySoundCodeLabelBatchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RetrySoundCodeLabelBatchResponse>(await DoRequestAsync("RetrySoundCodeLabelBatch", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RetrySoundCodeLabelBatchResponse RetrySoundCodeLabelBatch(RetrySoundCodeLabelBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrySoundCodeLabelBatchWithOptions(request, runtime);
        }

        public async Task<RetrySoundCodeLabelBatchResponse> RetrySoundCodeLabelBatchAsync(RetrySoundCodeLabelBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrySoundCodeLabelBatchWithOptionsAsync(request, runtime);
        }

        public ReupgradeOTATaskResponse ReupgradeOTATaskWithOptions(ReupgradeOTATaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReupgradeOTATaskResponse>(DoRequest("ReupgradeOTATask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReupgradeOTATaskResponse> ReupgradeOTATaskWithOptionsAsync(ReupgradeOTATaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReupgradeOTATaskResponse>(await DoRequestAsync("ReupgradeOTATask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReupgradeOTATaskResponse ReupgradeOTATask(ReupgradeOTATaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReupgradeOTATaskWithOptions(request, runtime);
        }

        public async Task<ReupgradeOTATaskResponse> ReupgradeOTATaskAsync(ReupgradeOTATaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReupgradeOTATaskWithOptionsAsync(request, runtime);
        }

        public SaveDevicePropResponse SaveDevicePropWithOptions(SaveDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveDevicePropResponse>(DoRequest("SaveDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SaveDevicePropResponse> SaveDevicePropWithOptionsAsync(SaveDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveDevicePropResponse>(await DoRequestAsync("SaveDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SaveDevicePropResponse SaveDeviceProp(SaveDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDevicePropWithOptions(request, runtime);
        }

        public async Task<SaveDevicePropResponse> SaveDevicePropAsync(SaveDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDevicePropWithOptionsAsync(request, runtime);
        }

        public SaveScriptResponse SaveScriptWithOptions(SaveScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveScriptResponse>(DoRequest("SaveScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SaveScriptResponse> SaveScriptWithOptionsAsync(SaveScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveScriptResponse>(await DoRequestAsync("SaveScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SaveScriptResponse SaveScript(SaveScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveScriptWithOptions(request, runtime);
        }

        public async Task<SaveScriptResponse> SaveScriptAsync(SaveScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveScriptWithOptionsAsync(request, runtime);
        }

        public SetDeviceDesiredPropertyResponse SetDeviceDesiredPropertyWithOptions(SetDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceDesiredPropertyResponse>(DoRequest("SetDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDeviceDesiredPropertyResponse> SetDeviceDesiredPropertyWithOptionsAsync(SetDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceDesiredPropertyResponse>(await DoRequestAsync("SetDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDeviceDesiredPropertyResponse SetDeviceDesiredProperty(SetDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceDesiredPropertyWithOptions(request, runtime);
        }

        public async Task<SetDeviceDesiredPropertyResponse> SetDeviceDesiredPropertyAsync(SetDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceDesiredPropertyWithOptionsAsync(request, runtime);
        }

        public SetDeviceGroupTagsResponse SetDeviceGroupTagsWithOptions(SetDeviceGroupTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceGroupTagsResponse>(DoRequest("SetDeviceGroupTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDeviceGroupTagsResponse> SetDeviceGroupTagsWithOptionsAsync(SetDeviceGroupTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceGroupTagsResponse>(await DoRequestAsync("SetDeviceGroupTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDeviceGroupTagsResponse SetDeviceGroupTags(SetDeviceGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceGroupTagsWithOptions(request, runtime);
        }

        public async Task<SetDeviceGroupTagsResponse> SetDeviceGroupTagsAsync(SetDeviceGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceGroupTagsWithOptionsAsync(request, runtime);
        }

        public SetDevicePropertyResponse SetDevicePropertyWithOptions(SetDevicePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicePropertyResponse>(DoRequest("SetDeviceProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDevicePropertyResponse> SetDevicePropertyWithOptionsAsync(SetDevicePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicePropertyResponse>(await DoRequestAsync("SetDeviceProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDevicePropertyResponse SetDeviceProperty(SetDevicePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDevicePropertyWithOptions(request, runtime);
        }

        public async Task<SetDevicePropertyResponse> SetDevicePropertyAsync(SetDevicePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDevicePropertyWithOptionsAsync(request, runtime);
        }

        public SetDevicesPropertyResponse SetDevicesPropertyWithOptions(SetDevicesPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicesPropertyResponse>(DoRequest("SetDevicesProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDevicesPropertyResponse> SetDevicesPropertyWithOptionsAsync(SetDevicesPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicesPropertyResponse>(await DoRequestAsync("SetDevicesProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDevicesPropertyResponse SetDevicesProperty(SetDevicesPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDevicesPropertyWithOptions(request, runtime);
        }

        public async Task<SetDevicesPropertyResponse> SetDevicesPropertyAsync(SetDevicesPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDevicesPropertyWithOptionsAsync(request, runtime);
        }

        public SetEdgeInstanceDriverConfigsResponse SetEdgeInstanceDriverConfigsWithOptions(SetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetEdgeInstanceDriverConfigsResponse>(DoRequest("SetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetEdgeInstanceDriverConfigsResponse> SetEdgeInstanceDriverConfigsWithOptionsAsync(SetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("SetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetEdgeInstanceDriverConfigsResponse SetEdgeInstanceDriverConfigs(SetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<SetEdgeInstanceDriverConfigsResponse> SetEdgeInstanceDriverConfigsAsync(SetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public SetProductCertInfoResponse SetProductCertInfoWithOptions(SetProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetProductCertInfoResponse>(DoRequest("SetProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetProductCertInfoResponse> SetProductCertInfoWithOptionsAsync(SetProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetProductCertInfoResponse>(await DoRequestAsync("SetProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetProductCertInfoResponse SetProductCertInfo(SetProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetProductCertInfoWithOptions(request, runtime);
        }

        public async Task<SetProductCertInfoResponse> SetProductCertInfoAsync(SetProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetProductCertInfoWithOptionsAsync(request, runtime);
        }

        public SetStudioProjectCooperationResponse SetStudioProjectCooperationWithOptions(SetStudioProjectCooperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetStudioProjectCooperationResponse>(DoRequest("SetStudioProjectCooperation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetStudioProjectCooperationResponse> SetStudioProjectCooperationWithOptionsAsync(SetStudioProjectCooperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetStudioProjectCooperationResponse>(await DoRequestAsync("SetStudioProjectCooperation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetStudioProjectCooperationResponse SetStudioProjectCooperation(SetStudioProjectCooperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetStudioProjectCooperationWithOptions(request, runtime);
        }

        public async Task<SetStudioProjectCooperationResponse> SetStudioProjectCooperationAsync(SetStudioProjectCooperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetStudioProjectCooperationWithOptionsAsync(request, runtime);
        }

        public SetupStudioAppAuthModeOpenResponse SetupStudioAppAuthModeOpenWithOptions(SetupStudioAppAuthModeOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetupStudioAppAuthModeOpenResponse>(DoRequest("SetupStudioAppAuthModeOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetupStudioAppAuthModeOpenResponse> SetupStudioAppAuthModeOpenWithOptionsAsync(SetupStudioAppAuthModeOpenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetupStudioAppAuthModeOpenResponse>(await DoRequestAsync("SetupStudioAppAuthModeOpen", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetupStudioAppAuthModeOpenResponse SetupStudioAppAuthModeOpen(SetupStudioAppAuthModeOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupStudioAppAuthModeOpenWithOptions(request, runtime);
        }

        public async Task<SetupStudioAppAuthModeOpenResponse> SetupStudioAppAuthModeOpenAsync(SetupStudioAppAuthModeOpenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupStudioAppAuthModeOpenWithOptionsAsync(request, runtime);
        }

        public ShareSpeechByCombinationResponse ShareSpeechByCombinationWithOptions(ShareSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ShareSpeechByCombinationResponse>(DoRequest("ShareSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ShareSpeechByCombinationResponse> ShareSpeechByCombinationWithOptionsAsync(ShareSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ShareSpeechByCombinationResponse>(await DoRequestAsync("ShareSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ShareSpeechByCombinationResponse ShareSpeechByCombination(ShareSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ShareSpeechByCombinationWithOptions(request, runtime);
        }

        public async Task<ShareSpeechByCombinationResponse> ShareSpeechByCombinationAsync(ShareSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ShareSpeechByCombinationWithOptionsAsync(request, runtime);
        }

        public SpeechByCombinationResponse SpeechByCombinationWithOptions(SpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechByCombinationResponse>(DoRequest("SpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SpeechByCombinationResponse> SpeechByCombinationWithOptionsAsync(SpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechByCombinationResponse>(await DoRequestAsync("SpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SpeechByCombinationResponse SpeechByCombination(SpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SpeechByCombinationWithOptions(request, runtime);
        }

        public async Task<SpeechByCombinationResponse> SpeechByCombinationAsync(SpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SpeechByCombinationWithOptionsAsync(request, runtime);
        }

        public SpeechBySynthesisResponse SpeechBySynthesisWithOptions(SpeechBySynthesisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechBySynthesisResponse>(DoRequest("SpeechBySynthesis", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SpeechBySynthesisResponse> SpeechBySynthesisWithOptionsAsync(SpeechBySynthesisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechBySynthesisResponse>(await DoRequestAsync("SpeechBySynthesis", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SpeechBySynthesisResponse SpeechBySynthesis(SpeechBySynthesisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SpeechBySynthesisWithOptions(request, runtime);
        }

        public async Task<SpeechBySynthesisResponse> SpeechBySynthesisAsync(SpeechBySynthesisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SpeechBySynthesisWithOptionsAsync(request, runtime);
        }

        public StartParserResponse StartParserWithOptions(StartParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartParserResponse>(DoRequest("StartParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartParserResponse> StartParserWithOptionsAsync(StartParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartParserResponse>(await DoRequestAsync("StartParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StartParserResponse StartParser(StartParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartParserWithOptions(request, runtime);
        }

        public async Task<StartParserResponse> StartParserAsync(StartParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartParserWithOptionsAsync(request, runtime);
        }

        public StartRuleResponse StartRuleWithOptions(StartRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartRuleResponse>(DoRequest("StartRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartRuleResponse> StartRuleWithOptionsAsync(StartRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartRuleResponse>(await DoRequestAsync("StartRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StartRuleResponse StartRule(StartRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRuleWithOptions(request, runtime);
        }

        public async Task<StartRuleResponse> StartRuleAsync(StartRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRuleWithOptionsAsync(request, runtime);
        }

        public StopParserResponse StopParserWithOptions(StopParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopParserResponse>(DoRequest("StopParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopParserResponse> StopParserWithOptionsAsync(StopParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopParserResponse>(await DoRequestAsync("StopParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StopParserResponse StopParser(StopParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopParserWithOptions(request, runtime);
        }

        public async Task<StopParserResponse> StopParserAsync(StopParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopParserWithOptionsAsync(request, runtime);
        }

        public StopRuleResponse StopRuleWithOptions(StopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopRuleResponse>(DoRequest("StopRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopRuleResponse> StopRuleWithOptionsAsync(StopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopRuleResponse>(await DoRequestAsync("StopRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StopRuleResponse StopRule(StopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRuleWithOptions(request, runtime);
        }

        public async Task<StopRuleResponse> StopRuleAsync(StopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRuleWithOptionsAsync(request, runtime);
        }

        public SubscribeTopicResponse SubscribeTopicWithOptions(SubscribeTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeTopicResponse>(DoRequest("SubscribeTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubscribeTopicResponse> SubscribeTopicWithOptionsAsync(SubscribeTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubscribeTopicResponse>(await DoRequestAsync("SubscribeTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SubscribeTopicResponse SubscribeTopic(SubscribeTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeTopicWithOptions(request, runtime);
        }

        public async Task<SubscribeTopicResponse> SubscribeTopicAsync(SubscribeTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeTopicWithOptionsAsync(request, runtime);
        }

        public SyncSpeechByCombinationResponse SyncSpeechByCombinationWithOptions(SyncSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncSpeechByCombinationResponse>(DoRequest("SyncSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SyncSpeechByCombinationResponse> SyncSpeechByCombinationWithOptionsAsync(SyncSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncSpeechByCombinationResponse>(await DoRequestAsync("SyncSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SyncSpeechByCombinationResponse SyncSpeechByCombination(SyncSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncSpeechByCombinationWithOptions(request, runtime);
        }

        public async Task<SyncSpeechByCombinationResponse> SyncSpeechByCombinationAsync(SyncSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncSpeechByCombinationWithOptionsAsync(request, runtime);
        }

        public TestSpeechResponse TestSpeechWithOptions(TestSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            TestSpeechShrinkRequest request = new TestSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<TestSpeechResponse>(DoRequest("TestSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TestSpeechResponse> TestSpeechWithOptionsAsync(TestSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            TestSpeechShrinkRequest request = new TestSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<TestSpeechResponse>(await DoRequestAsync("TestSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public TestSpeechResponse TestSpeech(TestSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestSpeechWithOptions(request, runtime);
        }

        public async Task<TestSpeechResponse> TestSpeechAsync(TestSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestSpeechWithOptionsAsync(request, runtime);
        }

        public TransformClientIdResponse TransformClientIdWithOptions(TransformClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TransformClientIdResponse>(DoRequest("TransformClientId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TransformClientIdResponse> TransformClientIdWithOptionsAsync(TransformClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TransformClientIdResponse>(await DoRequestAsync("TransformClientId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public TransformClientIdResponse TransformClientId(TransformClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransformClientIdWithOptions(request, runtime);
        }

        public async Task<TransformClientIdResponse> TransformClientIdAsync(TransformClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransformClientIdWithOptionsAsync(request, runtime);
        }

        public TriggerSceneRuleResponse TriggerSceneRuleWithOptions(TriggerSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TriggerSceneRuleResponse>(DoRequest("TriggerSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TriggerSceneRuleResponse> TriggerSceneRuleWithOptionsAsync(TriggerSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TriggerSceneRuleResponse>(await DoRequestAsync("TriggerSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public TriggerSceneRuleResponse TriggerSceneRule(TriggerSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerSceneRuleWithOptions(request, runtime);
        }

        public async Task<TriggerSceneRuleResponse> TriggerSceneRuleAsync(TriggerSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerSceneRuleWithOptionsAsync(request, runtime);
        }

        public UnbindApplicationFromEdgeInstanceResponse UnbindApplicationFromEdgeInstanceWithOptions(UnbindApplicationFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindApplicationFromEdgeInstanceResponse>(DoRequest("UnbindApplicationFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindApplicationFromEdgeInstanceResponse> UnbindApplicationFromEdgeInstanceWithOptionsAsync(UnbindApplicationFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindApplicationFromEdgeInstanceResponse>(await DoRequestAsync("UnbindApplicationFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindApplicationFromEdgeInstanceResponse UnbindApplicationFromEdgeInstance(UnbindApplicationFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindApplicationFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindApplicationFromEdgeInstanceResponse> UnbindApplicationFromEdgeInstanceAsync(UnbindApplicationFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindApplicationFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UnbindDriverFromEdgeInstanceResponse UnbindDriverFromEdgeInstanceWithOptions(UnbindDriverFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindDriverFromEdgeInstanceResponse>(DoRequest("UnbindDriverFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindDriverFromEdgeInstanceResponse> UnbindDriverFromEdgeInstanceWithOptionsAsync(UnbindDriverFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindDriverFromEdgeInstanceResponse>(await DoRequestAsync("UnbindDriverFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindDriverFromEdgeInstanceResponse UnbindDriverFromEdgeInstance(UnbindDriverFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDriverFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindDriverFromEdgeInstanceResponse> UnbindDriverFromEdgeInstanceAsync(UnbindDriverFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDriverFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UnbindLicenseProductResponse UnbindLicenseProductWithOptions(UnbindLicenseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindLicenseProductResponse>(DoRequest("UnbindLicenseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindLicenseProductResponse> UnbindLicenseProductWithOptionsAsync(UnbindLicenseProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindLicenseProductResponse>(await DoRequestAsync("UnbindLicenseProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindLicenseProductResponse UnbindLicenseProduct(UnbindLicenseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindLicenseProductWithOptions(request, runtime);
        }

        public async Task<UnbindLicenseProductResponse> UnbindLicenseProductAsync(UnbindLicenseProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindLicenseProductWithOptionsAsync(request, runtime);
        }

        public UnbindRoleFromEdgeInstanceResponse UnbindRoleFromEdgeInstanceWithOptions(UnbindRoleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindRoleFromEdgeInstanceResponse>(DoRequest("UnbindRoleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindRoleFromEdgeInstanceResponse> UnbindRoleFromEdgeInstanceWithOptionsAsync(UnbindRoleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindRoleFromEdgeInstanceResponse>(await DoRequestAsync("UnbindRoleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindRoleFromEdgeInstanceResponse UnbindRoleFromEdgeInstance(UnbindRoleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindRoleFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindRoleFromEdgeInstanceResponse> UnbindRoleFromEdgeInstanceAsync(UnbindRoleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindRoleFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UnbindSceneRuleFromEdgeInstanceResponse UnbindSceneRuleFromEdgeInstanceWithOptions(UnbindSceneRuleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindSceneRuleFromEdgeInstanceResponse>(DoRequest("UnbindSceneRuleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindSceneRuleFromEdgeInstanceResponse> UnbindSceneRuleFromEdgeInstanceWithOptionsAsync(UnbindSceneRuleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindSceneRuleFromEdgeInstanceResponse>(await DoRequestAsync("UnbindSceneRuleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindSceneRuleFromEdgeInstanceResponse UnbindSceneRuleFromEdgeInstance(UnbindSceneRuleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSceneRuleFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindSceneRuleFromEdgeInstanceResponse> UnbindSceneRuleFromEdgeInstanceAsync(UnbindSceneRuleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSceneRuleFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateConsumerGroupResponse UpdateConsumerGroupWithOptions(UpdateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(DoRequest("UpdateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupWithOptionsAsync(UpdateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(await DoRequestAsync("UpdateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateConsumerGroupResponse UpdateConsumerGroup(UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConsumerGroupWithOptions(request, runtime);
        }

        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConsumerGroupWithOptionsAsync(request, runtime);
        }

        public UpdateDestinationResponse UpdateDestinationWithOptions(UpdateDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDestinationResponse>(DoRequest("UpdateDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDestinationResponse> UpdateDestinationWithOptionsAsync(UpdateDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDestinationResponse>(await DoRequestAsync("UpdateDestination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDestinationWithOptions(request, runtime);
        }

        public async Task<UpdateDestinationResponse> UpdateDestinationAsync(UpdateDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDestinationWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceGroupResponse UpdateDeviceGroupWithOptions(UpdateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceGroupResponse>(DoRequest("UpdateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroupWithOptionsAsync(UpdateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceGroupResponse>(await DoRequestAsync("UpdateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDeviceGroupResponse UpdateDeviceGroup(UpdateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroupAsync(UpdateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceGroupWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceShadowResponse UpdateDeviceShadowWithOptions(UpdateDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceShadowResponse>(DoRequest("UpdateDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadowWithOptionsAsync(UpdateDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceShadowResponse>(await DoRequestAsync("UpdateDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDeviceShadowResponse UpdateDeviceShadow(UpdateDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceShadowWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadowAsync(UpdateDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceShadowWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeDriverVersionResponse UpdateEdgeDriverVersionWithOptions(UpdateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeDriverVersionResponse>(DoRequest("UpdateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeDriverVersionResponse> UpdateEdgeDriverVersionWithOptionsAsync(UpdateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeDriverVersionResponse>(await DoRequestAsync("UpdateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeDriverVersionResponse UpdateEdgeDriverVersion(UpdateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeDriverVersionResponse> UpdateEdgeDriverVersionAsync(UpdateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeInstanceResponse UpdateEdgeInstanceWithOptions(UpdateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceResponse>(DoRequest("UpdateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeInstanceResponse> UpdateEdgeInstanceWithOptionsAsync(UpdateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceResponse>(await DoRequestAsync("UpdateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeInstanceResponse UpdateEdgeInstance(UpdateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeInstanceResponse> UpdateEdgeInstanceAsync(UpdateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeInstanceChannelResponse UpdateEdgeInstanceChannelWithOptions(UpdateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceChannelResponse>(DoRequest("UpdateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeInstanceChannelResponse> UpdateEdgeInstanceChannelWithOptionsAsync(UpdateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceChannelResponse>(await DoRequestAsync("UpdateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeInstanceChannelResponse UpdateEdgeInstanceChannel(UpdateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeInstanceChannelResponse> UpdateEdgeInstanceChannelAsync(UpdateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeInstanceMessageRoutingResponse UpdateEdgeInstanceMessageRoutingWithOptions(UpdateEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceMessageRoutingResponse>(DoRequest("UpdateEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeInstanceMessageRoutingResponse> UpdateEdgeInstanceMessageRoutingWithOptionsAsync(UpdateEdgeInstanceMessageRoutingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceMessageRoutingResponse>(await DoRequestAsync("UpdateEdgeInstanceMessageRouting", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeInstanceMessageRoutingResponse UpdateEdgeInstanceMessageRouting(UpdateEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeInstanceMessageRoutingWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeInstanceMessageRoutingResponse> UpdateEdgeInstanceMessageRoutingAsync(UpdateEdgeInstanceMessageRoutingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeInstanceMessageRoutingWithOptionsAsync(request, runtime);
        }

        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            return TeaModel.ToObject<UpdateJobResponse>(DoRequest("UpdateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            return TeaModel.ToObject<UpdateJobResponse>(await DoRequestAsync("UpdateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateJobWithOptions(request, runtime);
        }

        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateJobWithOptionsAsync(request, runtime);
        }

        public UpdateOTAModuleResponse UpdateOTAModuleWithOptions(UpdateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateOTAModuleResponse>(DoRequest("UpdateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateOTAModuleResponse> UpdateOTAModuleWithOptionsAsync(UpdateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateOTAModuleResponse>(await DoRequestAsync("UpdateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateOTAModuleResponse UpdateOTAModule(UpdateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOTAModuleWithOptions(request, runtime);
        }

        public async Task<UpdateOTAModuleResponse> UpdateOTAModuleAsync(UpdateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOTAModuleWithOptionsAsync(request, runtime);
        }

        public UpdateParserResponse UpdateParserWithOptions(UpdateParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateParserResponse>(DoRequest("UpdateParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateParserResponse> UpdateParserWithOptionsAsync(UpdateParserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateParserResponse>(await DoRequestAsync("UpdateParser", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateParserResponse UpdateParser(UpdateParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateParserWithOptions(request, runtime);
        }

        public async Task<UpdateParserResponse> UpdateParserAsync(UpdateParserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateParserWithOptionsAsync(request, runtime);
        }

        public UpdateParserDataSourceResponse UpdateParserDataSourceWithOptions(UpdateParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateParserDataSourceResponse>(DoRequest("UpdateParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateParserDataSourceResponse> UpdateParserDataSourceWithOptionsAsync(UpdateParserDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateParserDataSourceResponse>(await DoRequestAsync("UpdateParserDataSource", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateParserDataSourceResponse UpdateParserDataSource(UpdateParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateParserDataSourceWithOptions(request, runtime);
        }

        public async Task<UpdateParserDataSourceResponse> UpdateParserDataSourceAsync(UpdateParserDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateParserDataSourceWithOptionsAsync(request, runtime);
        }

        public UpdateProductResponse UpdateProductWithOptions(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductResponse>(DoRequest("UpdateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductResponse> UpdateProductWithOptionsAsync(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductResponse>(await DoRequestAsync("UpdateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductWithOptions(request, runtime);
        }

        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductWithOptionsAsync(request, runtime);
        }

        public UpdateProductFilterConfigResponse UpdateProductFilterConfigWithOptions(UpdateProductFilterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductFilterConfigResponse>(DoRequest("UpdateProductFilterConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductFilterConfigResponse> UpdateProductFilterConfigWithOptionsAsync(UpdateProductFilterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductFilterConfigResponse>(await DoRequestAsync("UpdateProductFilterConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductFilterConfigResponse UpdateProductFilterConfig(UpdateProductFilterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductFilterConfigWithOptions(request, runtime);
        }

        public async Task<UpdateProductFilterConfigResponse> UpdateProductFilterConfigAsync(UpdateProductFilterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductFilterConfigWithOptionsAsync(request, runtime);
        }

        public UpdateProductTagsResponse UpdateProductTagsWithOptions(UpdateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTagsResponse>(DoRequest("UpdateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductTagsResponse> UpdateProductTagsWithOptionsAsync(UpdateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTagsResponse>(await DoRequestAsync("UpdateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductTagsResponse UpdateProductTags(UpdateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductTagsWithOptions(request, runtime);
        }

        public async Task<UpdateProductTagsResponse> UpdateProductTagsAsync(UpdateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductTagsWithOptionsAsync(request, runtime);
        }

        public UpdateProductTopicResponse UpdateProductTopicWithOptions(UpdateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTopicResponse>(DoRequest("UpdateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductTopicResponse> UpdateProductTopicWithOptionsAsync(UpdateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTopicResponse>(await DoRequestAsync("UpdateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductTopicResponse UpdateProductTopic(UpdateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductTopicWithOptions(request, runtime);
        }

        public async Task<UpdateProductTopicResponse> UpdateProductTopicAsync(UpdateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductTopicWithOptionsAsync(request, runtime);
        }

        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleResponse>(DoRequest("UpdateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleResponse>(await DoRequestAsync("UpdateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        public UpdateRuleActionResponse UpdateRuleActionWithOptions(UpdateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleActionResponse>(DoRequest("UpdateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRuleActionResponse> UpdateRuleActionWithOptionsAsync(UpdateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleActionResponse>(await DoRequestAsync("UpdateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRuleActionResponse UpdateRuleAction(UpdateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleActionWithOptions(request, runtime);
        }

        public async Task<UpdateRuleActionResponse> UpdateRuleActionAsync(UpdateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleActionWithOptionsAsync(request, runtime);
        }

        public UpdateSceneRuleResponse UpdateSceneRuleWithOptions(UpdateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSceneRuleResponse>(DoRequest("UpdateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSceneRuleResponse> UpdateSceneRuleWithOptionsAsync(UpdateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSceneRuleResponse>(await DoRequestAsync("UpdateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSceneRuleResponse UpdateSceneRule(UpdateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSceneRuleWithOptions(request, runtime);
        }

        public async Task<UpdateSceneRuleResponse> UpdateSceneRuleAsync(UpdateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSceneRuleWithOptionsAsync(request, runtime);
        }

        public UpdateSchedulePeriodResponse UpdateSchedulePeriodWithOptions(UpdateSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSchedulePeriodResponse>(DoRequest("UpdateSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSchedulePeriodResponse> UpdateSchedulePeriodWithOptionsAsync(UpdateSchedulePeriodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSchedulePeriodResponse>(await DoRequestAsync("UpdateSchedulePeriod", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSchedulePeriodResponse UpdateSchedulePeriod(UpdateSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSchedulePeriodWithOptions(request, runtime);
        }

        public async Task<UpdateSchedulePeriodResponse> UpdateSchedulePeriodAsync(UpdateSchedulePeriodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSchedulePeriodWithOptionsAsync(request, runtime);
        }

        public UpdateSoundCodeResponse UpdateSoundCodeWithOptions(UpdateSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeResponse>(DoRequest("UpdateSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSoundCodeResponse> UpdateSoundCodeWithOptionsAsync(UpdateSoundCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeResponse>(await DoRequestAsync("UpdateSoundCode", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSoundCodeResponse UpdateSoundCode(UpdateSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSoundCodeWithOptions(request, runtime);
        }

        public async Task<UpdateSoundCodeResponse> UpdateSoundCodeAsync(UpdateSoundCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSoundCodeWithOptionsAsync(request, runtime);
        }

        public UpdateSoundCodeLabelResponse UpdateSoundCodeLabelWithOptions(UpdateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeLabelResponse>(DoRequest("UpdateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSoundCodeLabelResponse> UpdateSoundCodeLabelWithOptionsAsync(UpdateSoundCodeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeLabelResponse>(await DoRequestAsync("UpdateSoundCodeLabel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSoundCodeLabelResponse UpdateSoundCodeLabel(UpdateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSoundCodeLabelWithOptions(request, runtime);
        }

        public async Task<UpdateSoundCodeLabelResponse> UpdateSoundCodeLabelAsync(UpdateSoundCodeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSoundCodeLabelWithOptionsAsync(request, runtime);
        }

        public UpdateSoundCodeScheduleResponse UpdateSoundCodeScheduleWithOptions(UpdateSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeScheduleResponse>(DoRequest("UpdateSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSoundCodeScheduleResponse> UpdateSoundCodeScheduleWithOptionsAsync(UpdateSoundCodeScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSoundCodeScheduleResponse>(await DoRequestAsync("UpdateSoundCodeSchedule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSoundCodeScheduleResponse UpdateSoundCodeSchedule(UpdateSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSoundCodeScheduleWithOptions(request, runtime);
        }

        public async Task<UpdateSoundCodeScheduleResponse> UpdateSoundCodeScheduleAsync(UpdateSoundCodeScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSoundCodeScheduleWithOptionsAsync(request, runtime);
        }

        public UpdateSpeechResponse UpdateSpeechWithOptions(UpdateSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateSpeechShrinkRequest request = new UpdateSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<UpdateSpeechResponse>(DoRequest("UpdateSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSpeechResponse> UpdateSpeechWithOptionsAsync(UpdateSpeechRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateSpeechShrinkRequest request = new UpdateSpeechShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.SoundCodeConfig))
            {
                request.SoundCodeConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.SoundCodeConfig);
            }
            return TeaModel.ToObject<UpdateSpeechResponse>(await DoRequestAsync("UpdateSpeech", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSpeechResponse UpdateSpeech(UpdateSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSpeechWithOptions(request, runtime);
        }

        public async Task<UpdateSpeechResponse> UpdateSpeechAsync(UpdateSpeechRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSpeechWithOptionsAsync(request, runtime);
        }

        public UpdateSubscribeRelationResponse UpdateSubscribeRelationWithOptions(UpdateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSubscribeRelationResponse>(DoRequest("UpdateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSubscribeRelationResponse> UpdateSubscribeRelationWithOptionsAsync(UpdateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSubscribeRelationResponse>(await DoRequestAsync("UpdateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSubscribeRelationResponse UpdateSubscribeRelation(UpdateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<UpdateSubscribeRelationResponse> UpdateSubscribeRelationAsync(UpdateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public UpdateThingModelResponse UpdateThingModelWithOptions(UpdateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelResponse>(DoRequest("UpdateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateThingModelResponse> UpdateThingModelWithOptionsAsync(UpdateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelResponse>(await DoRequestAsync("UpdateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateThingModelResponse UpdateThingModel(UpdateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateThingModelWithOptions(request, runtime);
        }

        public async Task<UpdateThingModelResponse> UpdateThingModelAsync(UpdateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateThingModelWithOptionsAsync(request, runtime);
        }

        public UpdateThingScriptResponse UpdateThingScriptWithOptions(UpdateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingScriptResponse>(DoRequest("UpdateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateThingScriptResponse> UpdateThingScriptWithOptionsAsync(UpdateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingScriptResponse>(await DoRequestAsync("UpdateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateThingScriptResponse UpdateThingScript(UpdateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateThingScriptWithOptions(request, runtime);
        }

        public async Task<UpdateThingScriptResponse> UpdateThingScriptAsync(UpdateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateThingScriptWithOptionsAsync(request, runtime);
        }

        public WriteDevicesHotStorageDataResponse WriteDevicesHotStorageDataWithOptions(WriteDevicesHotStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<WriteDevicesHotStorageDataResponse>(DoRequest("WriteDevicesHotStorageData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<WriteDevicesHotStorageDataResponse> WriteDevicesHotStorageDataWithOptionsAsync(WriteDevicesHotStorageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<WriteDevicesHotStorageDataResponse>(await DoRequestAsync("WriteDevicesHotStorageData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public WriteDevicesHotStorageDataResponse WriteDevicesHotStorageData(WriteDevicesHotStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WriteDevicesHotStorageDataWithOptions(request, runtime);
        }

        public async Task<WriteDevicesHotStorageDataResponse> WriteDevicesHotStorageDataAsync(WriteDevicesHotStorageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WriteDevicesHotStorageDataWithOptionsAsync(request, runtime);
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

    }
}
