// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Wyota20210420.Models;

namespace AlibabaCloud.SDK.Wyota20210420
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("wyota", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 设备激活
         *
         * @param request ActivateDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateDeviceResponse
         */
        public ActivateDeviceResponse ActivateDeviceWithOptions(ActivateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateDevice",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备激活
         *
         * @param request ActivateDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ActivateDeviceResponse
         */
        public async Task<ActivateDeviceResponse> ActivateDeviceWithOptionsAsync(ActivateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateDevice",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备激活
         *
         * @param request ActivateDeviceRequest
         * @return ActivateDeviceResponse
         */
        public ActivateDeviceResponse ActivateDevice(ActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateDeviceWithOptions(request, runtime);
        }

        /**
         * @summary 设备激活
         *
         * @param request ActivateDeviceRequest
         * @return ActivateDeviceResponse
         */
        public async Task<ActivateDeviceResponse> ActivateDeviceAsync(ActivateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过序列号添加设备
         *
         * @param request AddDeviceFromSNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDeviceFromSNResponse
         */
        public AddDeviceFromSNResponse AddDeviceFromSNWithOptions(AddDeviceFromSNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomProperty))
            {
                body["CustomProperty"] = request.CustomProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContents))
            {
                body["LabelContents"] = request.LabelContents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceFromSN",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceFromSNResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过序列号添加设备
         *
         * @param request AddDeviceFromSNRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDeviceFromSNResponse
         */
        public async Task<AddDeviceFromSNResponse> AddDeviceFromSNWithOptionsAsync(AddDeviceFromSNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomProperty))
            {
                body["CustomProperty"] = request.CustomProperty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContents))
            {
                body["LabelContents"] = request.LabelContents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceFromSN",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceFromSNResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过序列号添加设备
         *
         * @param request AddDeviceFromSNRequest
         * @return AddDeviceFromSNResponse
         */
        public AddDeviceFromSNResponse AddDeviceFromSN(AddDeviceFromSNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeviceFromSNWithOptions(request, runtime);
        }

        /**
         * @summary 通过序列号添加设备
         *
         * @param request AddDeviceFromSNRequest
         * @return AddDeviceFromSNResponse
         */
        public async Task<AddDeviceFromSNResponse> AddDeviceFromSNAsync(AddDeviceFromSNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeviceFromSNWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新增设备座位和标签
         *
         * @param request AddDeviceSeatsAndLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDeviceSeatsAndLabelsResponse
         */
        public AddDeviceSeatsAndLabelsResponse AddDeviceSeatsAndLabelsWithOptions(AddDeviceSeatsAndLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUnique))
            {
                body["IsUnique"] = request.IsUnique;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelList))
            {
                body["LabelList"] = request.LabelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatName))
            {
                body["SeatName"] = request.SeatName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceSeatsAndLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceSeatsAndLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增设备座位和标签
         *
         * @param request AddDeviceSeatsAndLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDeviceSeatsAndLabelsResponse
         */
        public async Task<AddDeviceSeatsAndLabelsResponse> AddDeviceSeatsAndLabelsWithOptionsAsync(AddDeviceSeatsAndLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsUnique))
            {
                body["IsUnique"] = request.IsUnique;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelList))
            {
                body["LabelList"] = request.LabelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatName))
            {
                body["SeatName"] = request.SeatName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDeviceSeatsAndLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDeviceSeatsAndLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增设备座位和标签
         *
         * @param request AddDeviceSeatsAndLabelsRequest
         * @return AddDeviceSeatsAndLabelsResponse
         */
        public AddDeviceSeatsAndLabelsResponse AddDeviceSeatsAndLabels(AddDeviceSeatsAndLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeviceSeatsAndLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 新增设备座位和标签
         *
         * @param request AddDeviceSeatsAndLabelsRequest
         * @return AddDeviceSeatsAndLabelsResponse
         */
        public async Task<AddDeviceSeatsAndLabelsResponse> AddDeviceSeatsAndLabelsAsync(AddDeviceSeatsAndLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeviceSeatsAndLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过CSV文件添加设备
         *
         * @param request AddDevicesFromCSVRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDevicesFromCSVResponse
         */
        public AddDevicesFromCSVResponse AddDevicesFromCSVWithOptions(AddDevicesFromCSVRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatCol))
            {
                body["SeatCol"] = request.SeatCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                body["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDevicesFromCSV",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDevicesFromCSVResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过CSV文件添加设备
         *
         * @param request AddDevicesFromCSVRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDevicesFromCSVResponse
         */
        public async Task<AddDevicesFromCSVResponse> AddDevicesFromCSVWithOptionsAsync(AddDevicesFromCSVRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatCol))
            {
                body["SeatCol"] = request.SeatCol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteName))
            {
                body["SiteName"] = request.SiteName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDevicesFromCSV",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDevicesFromCSVResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过CSV文件添加设备
         *
         * @param request AddDevicesFromCSVRequest
         * @return AddDevicesFromCSVResponse
         */
        public AddDevicesFromCSVResponse AddDevicesFromCSV(AddDevicesFromCSVRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDevicesFromCSVWithOptions(request, runtime);
        }

        /**
         * @summary 通过CSV文件添加设备
         *
         * @param request AddDevicesFromCSVRequest
         * @return AddDevicesFromCSVResponse
         */
        public async Task<AddDevicesFromCSVResponse> AddDevicesFromCSVAsync(AddDevicesFromCSVRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDevicesFromCSVWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加标签
         *
         * @param request AddLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddLabelsResponse
         */
        public AddLabelsResponse AddLabelsWithOptions(AddLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContents))
            {
                body["LabelContents"] = request.LabelContents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加标签
         *
         * @param request AddLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddLabelsResponse
         */
        public async Task<AddLabelsResponse> AddLabelsWithOptionsAsync(AddLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContents))
            {
                body["LabelContents"] = request.LabelContents;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加标签
         *
         * @param request AddLabelsRequest
         * @return AddLabelsResponse
         */
        public AddLabelsResponse AddLabels(AddLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 添加标签
         *
         * @param request AddLabelsRequest
         * @return AddLabelsResponse
         */
        public async Task<AddLabelsResponse> AddLabelsAsync(AddLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新增或更新设备工位
         *
         * @param request AddOrUpdateDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrUpdateDeviceSeatsResponse
         */
        public AddOrUpdateDeviceSeatsResponse AddOrUpdateDeviceSeatsWithOptions(AddOrUpdateDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrUpdateDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateDeviceSeatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 新增或更新设备工位
         *
         * @param request AddOrUpdateDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddOrUpdateDeviceSeatsResponse
         */
        public async Task<AddOrUpdateDeviceSeatsResponse> AddOrUpdateDeviceSeatsWithOptionsAsync(AddOrUpdateDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddOrUpdateDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddOrUpdateDeviceSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 新增或更新设备工位
         *
         * @param request AddOrUpdateDeviceSeatsRequest
         * @return AddOrUpdateDeviceSeatsResponse
         */
        public AddOrUpdateDeviceSeatsResponse AddOrUpdateDeviceSeats(AddOrUpdateDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOrUpdateDeviceSeatsWithOptions(request, runtime);
        }

        /**
         * @summary 新增或更新设备工位
         *
         * @param request AddOrUpdateDeviceSeatsRequest
         * @return AddOrUpdateDeviceSeatsResponse
         */
        public async Task<AddOrUpdateDeviceSeatsResponse> AddOrUpdateDeviceSeatsAsync(AddOrUpdateDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOrUpdateDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加终端
         *
         * @param request AddTerminalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTerminalResponse
         */
        public AddTerminalResponse AddTerminalWithOptions(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加终端
         *
         * @param request AddTerminalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddTerminalResponse
         */
        public async Task<AddTerminalResponse> AddTerminalWithOptionsAsync(AddTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加终端
         *
         * @param request AddTerminalRequest
         * @return AddTerminalResponse
         */
        public AddTerminalResponse AddTerminal(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTerminalWithOptions(request, runtime);
        }

        /**
         * @summary 添加终端
         *
         * @param request AddTerminalRequest
         * @return AddTerminalResponse
         */
        public async Task<AddTerminalResponse> AddTerminalAsync(AddTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTerminalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设备绑定终端用户
         *
         * @param request AttachEndUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachEndUsersResponse
         */
        public AttachEndUsersResponse AttachEndUsersWithOptions(AttachEndUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEndUsers",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEndUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备绑定终端用户
         *
         * @param request AttachEndUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachEndUsersResponse
         */
        public async Task<AttachEndUsersResponse> AttachEndUsersWithOptionsAsync(AttachEndUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachEndUsers",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachEndUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备绑定终端用户
         *
         * @param request AttachEndUsersRequest
         * @return AttachEndUsersResponse
         */
        public AttachEndUsersResponse AttachEndUsers(AttachEndUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachEndUsersWithOptions(request, runtime);
        }

        /**
         * @summary 设备绑定终端用户
         *
         * @param request AttachEndUsersRequest
         * @return AttachEndUsersResponse
         */
        public async Task<AttachEndUsersResponse> AttachEndUsersAsync(AttachEndUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachEndUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request AttachLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLabelResponse
         */
        public AttachLabelResponse AttachLabelWithOptions(AttachLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request AttachLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLabelResponse
         */
        public async Task<AttachLabelResponse> AttachLabelWithOptionsAsync(AttachLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request AttachLabelRequest
         * @return AttachLabelResponse
         */
        public AttachLabelResponse AttachLabel(AttachLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachLabelWithOptions(request, runtime);
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request AttachLabelRequest
         * @return AttachLabelResponse
         */
        public async Task<AttachLabelResponse> AttachLabelAsync(AttachLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量绑定标签
         *
         * @param request AttachLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLabelsResponse
         */
        public AttachLabelsResponse AttachLabelsWithOptions(AttachLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["LabelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量绑定标签
         *
         * @param request AttachLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachLabelsResponse
         */
        public async Task<AttachLabelsResponse> AttachLabelsWithOptionsAsync(AttachLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["LabelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量绑定标签
         *
         * @param request AttachLabelsRequest
         * @return AttachLabelsResponse
         */
        public AttachLabelsResponse AttachLabels(AttachLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 批量绑定标签
         *
         * @param request AttachLabelsRequest
         * @return AttachLabelsResponse
         */
        public async Task<AttachLabelsResponse> AttachLabelsAsync(AttachLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindAccountLessLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAccountLessLoginUserResponse
         */
        public BindAccountLessLoginUserResponse BindAccountLessLoginUserWithOptions(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindAccountLessLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindAccountLessLoginUserResponse
         */
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserWithOptionsAsync(BindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindAccountLessLoginUserRequest
         * @return BindAccountLessLoginUserResponse
         */
        public BindAccountLessLoginUserResponse BindAccountLessLoginUser(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAccountLessLoginUserWithOptions(request, runtime);
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindAccountLessLoginUserRequest
         * @return BindAccountLessLoginUserResponse
         */
        public async Task<BindAccountLessLoginUserResponse> BindAccountLessLoginUserAsync(BindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindPasswordFreeLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindPasswordFreeLoginUserResponse
         */
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUserWithOptions(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindPasswordFreeLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindPasswordFreeLoginUserResponse
         */
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserWithOptionsAsync(BindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindPasswordFreeLoginUserRequest
         * @return BindPasswordFreeLoginUserResponse
         */
        public BindPasswordFreeLoginUserResponse BindPasswordFreeLoginUser(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /**
         * @summary 绑定免账号登录用户
         *
         * @param request BindPasswordFreeLoginUserRequest
         * @return BindPasswordFreeLoginUserResponse
         */
        public async Task<BindPasswordFreeLoginUserResponse> BindPasswordFreeLoginUserAsync(BindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 检查uuid有效性
         *
         * @param request CheckUuidValidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUuidValidResponse
         */
        public CheckUuidValidResponse CheckUuidValidWithOptions(CheckUuidValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bluetooth))
            {
                body["Bluetooth"] = request.Bluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChipId))
            {
                body["ChipId"] = request.ChipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtherMac))
            {
                body["EtherMac"] = request.EtherMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wlan))
            {
                body["Wlan"] = request.Wlan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUuidValid",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUuidValidResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查uuid有效性
         *
         * @param request CheckUuidValidRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckUuidValidResponse
         */
        public async Task<CheckUuidValidResponse> CheckUuidValidWithOptionsAsync(CheckUuidValidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bluetooth))
            {
                body["Bluetooth"] = request.Bluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChipId))
            {
                body["ChipId"] = request.ChipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtherMac))
            {
                body["EtherMac"] = request.EtherMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wlan))
            {
                body["Wlan"] = request.Wlan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckUuidValid",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckUuidValidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查uuid有效性
         *
         * @param request CheckUuidValidRequest
         * @return CheckUuidValidResponse
         */
        public CheckUuidValidResponse CheckUuidValid(CheckUuidValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUuidValidWithOptions(request, runtime);
        }

        /**
         * @summary 检查uuid有效性
         *
         * @param request CheckUuidValidRequest
         * @return CheckUuidValidResponse
         */
        public async Task<CheckUuidValidResponse> CheckUuidValidAsync(CheckUuidValidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUuidValidWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateAppOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppOtaTaskResponse
         */
        public CreateAppOtaTaskResponse CreateAppOtaTaskWithOptions(CreateAppOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionUid))
            {
                query["AppVersionUid"] = request.AppVersionUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                query["ClientIdList"] = request.ClientIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                query["ForceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppOtaTask",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppOtaTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateAppOtaTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppOtaTaskResponse
         */
        public async Task<CreateAppOtaTaskResponse> CreateAppOtaTaskWithOptionsAsync(CreateAppOtaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersionUid))
            {
                query["AppVersionUid"] = request.AppVersionUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdList))
            {
                query["ClientIdList"] = request.ClientIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                query["ForceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Regions))
            {
                query["Regions"] = request.Regions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppOtaTask",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppOtaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateAppOtaTaskRequest
         * @return CreateAppOtaTaskResponse
         */
        public CreateAppOtaTaskResponse CreateAppOtaTask(CreateAppOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppOtaTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建任务
         *
         * @param request CreateAppOtaTaskRequest
         * @return CreateAppOtaTaskResponse
         */
        public async Task<CreateAppOtaTaskResponse> CreateAppOtaTaskAsync(CreateAppOtaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppOtaTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建版本
         *
         * @param request CreateAppOtaVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppOtaVersionResponse
         */
        public CreateAppOtaVersionResponse CreateAppOtaVersionWithOptions(CreateAppOtaVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                query["Arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                query["DownloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                query["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNote))
            {
                query["ReleaseNote"] = request.ReleaseNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNoteEn))
            {
                query["ReleaseNoteEn"] = request.ReleaseNoteEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNoteJp))
            {
                query["ReleaseNoteJp"] = request.ReleaseNoteJp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotRegionId))
            {
                query["SnapshotRegionId"] = request.SnapshotRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                query["VersionType"] = request.VersionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppOtaVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppOtaVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建版本
         *
         * @param request CreateAppOtaVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppOtaVersionResponse
         */
        public async Task<CreateAppOtaVersionResponse> CreateAppOtaVersionWithOptionsAsync(CreateAppOtaVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                query["Arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                query["DownloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Md5))
            {
                query["Md5"] = request.Md5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                query["Os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtaType))
            {
                query["OtaType"] = request.OtaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNote))
            {
                query["ReleaseNote"] = request.ReleaseNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNoteEn))
            {
                query["ReleaseNoteEn"] = request.ReleaseNoteEn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNoteJp))
            {
                query["ReleaseNoteJp"] = request.ReleaseNoteJp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotRegionId))
            {
                query["SnapshotRegionId"] = request.SnapshotRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionType))
            {
                query["VersionType"] = request.VersionType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppOtaVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppOtaVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建版本
         *
         * @param request CreateAppOtaVersionRequest
         * @return CreateAppOtaVersionResponse
         */
        public CreateAppOtaVersionResponse CreateAppOtaVersion(CreateAppOtaVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppOtaVersionWithOptions(request, runtime);
        }

        /**
         * @summary 创建版本
         *
         * @param request CreateAppOtaVersionRequest
         * @return CreateAppOtaVersionResponse
         */
        public async Task<CreateAppOtaVersionResponse> CreateAppOtaVersionAsync(CreateAppOtaVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppOtaVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除版本
         *
         * @param request DeleteAppOtaVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppOtaVersionsResponse
         */
        public DeleteAppOtaVersionsResponse DeleteAppOtaVersionsWithOptions(DeleteAppOtaVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionUidList))
            {
                query["VersionUidList"] = request.VersionUidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppOtaVersions",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppOtaVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除版本
         *
         * @param request DeleteAppOtaVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAppOtaVersionsResponse
         */
        public async Task<DeleteAppOtaVersionsResponse> DeleteAppOtaVersionsWithOptionsAsync(DeleteAppOtaVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionUidList))
            {
                query["VersionUidList"] = request.VersionUidList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppOtaVersions",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppOtaVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除版本
         *
         * @param request DeleteAppOtaVersionsRequest
         * @return DeleteAppOtaVersionsResponse
         */
        public DeleteAppOtaVersionsResponse DeleteAppOtaVersions(DeleteAppOtaVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppOtaVersionsWithOptions(request, runtime);
        }

        /**
         * @summary 删除版本
         *
         * @param request DeleteAppOtaVersionsRequest
         * @return DeleteAppOtaVersionsResponse
         */
        public async Task<DeleteAppOtaVersionsResponse> DeleteAppOtaVersionsAsync(DeleteAppOtaVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppOtaVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除设备
         *
         * @param request DeleteDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDevicesResponse
         */
        public DeleteDevicesResponse DeleteDevicesWithOptions(DeleteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNos))
            {
                body["SerialNos"] = request.SerialNos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除设备
         *
         * @param request DeleteDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDevicesResponse
         */
        public async Task<DeleteDevicesResponse> DeleteDevicesWithOptionsAsync(DeleteDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNos))
            {
                body["SerialNos"] = request.SerialNos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除设备
         *
         * @param request DeleteDevicesRequest
         * @return DeleteDevicesResponse
         */
        public DeleteDevicesResponse DeleteDevices(DeleteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 删除设备
         *
         * @param request DeleteDevicesRequest
         * @return DeleteDevicesResponse
         */
        public async Task<DeleteDevicesResponse> DeleteDevicesAsync(DeleteDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除标签
         *
         * @param request DeleteLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLabelResponse
         */
        public DeleteLabelResponse DeleteLabelWithOptions(DeleteLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除标签
         *
         * @param request DeleteLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLabelResponse
         */
        public async Task<DeleteLabelResponse> DeleteLabelWithOptionsAsync(DeleteLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除标签
         *
         * @param request DeleteLabelRequest
         * @return DeleteLabelResponse
         */
        public DeleteLabelResponse DeleteLabel(DeleteLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLabelWithOptions(request, runtime);
        }

        /**
         * @summary 删除标签
         *
         * @param request DeleteLabelRequest
         * @return DeleteLabelResponse
         */
        public async Task<DeleteLabelResponse> DeleteLabelAsync(DeleteLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询版本
         *
         * @param request DescribeAppOtaVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppOtaVersionResponse
         */
        public DescribeAppOtaVersionResponse DescribeAppOtaVersionWithOptions(DescribeAppOtaVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionUid))
            {
                query["VersionUid"] = request.VersionUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppOtaVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppOtaVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询版本
         *
         * @param request DescribeAppOtaVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppOtaVersionResponse
         */
        public async Task<DescribeAppOtaVersionResponse> DescribeAppOtaVersionWithOptionsAsync(DescribeAppOtaVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                query["Creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionUid))
            {
                query["VersionUid"] = request.VersionUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppOtaVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppOtaVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询版本
         *
         * @param request DescribeAppOtaVersionRequest
         * @return DescribeAppOtaVersionResponse
         */
        public DescribeAppOtaVersionResponse DescribeAppOtaVersion(DescribeAppOtaVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppOtaVersionWithOptions(request, runtime);
        }

        /**
         * @summary 查询版本
         *
         * @param request DescribeAppOtaVersionRequest
         * @return DescribeAppOtaVersionResponse
         */
        public async Task<DescribeAppOtaVersionResponse> DescribeAppOtaVersionAsync(DescribeAppOtaVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppOtaVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询设备座位
         *
         * @param request DescribeDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceSeatsResponse
         */
        public DescribeDeviceSeatsResponse DescribeDeviceSeatsWithOptions(DescribeDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceSeatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询设备座位
         *
         * @param request DescribeDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceSeatsResponse
         */
        public async Task<DescribeDeviceSeatsResponse> DescribeDeviceSeatsWithOptionsAsync(DescribeDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SiteId))
            {
                body["SiteId"] = request.SiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备座位
         *
         * @param request DescribeDeviceSeatsRequest
         * @return DescribeDeviceSeatsResponse
         */
        public DescribeDeviceSeatsResponse DescribeDeviceSeats(DescribeDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceSeatsWithOptions(request, runtime);
        }

        /**
         * @summary 查询设备座位
         *
         * @param request DescribeDeviceSeatsRequest
         * @return DescribeDeviceSeatsResponse
         */
        public async Task<DescribeDeviceSeatsResponse> DescribeDeviceSeatsAsync(DescribeDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询版本信息
         *
         * @param request DescribeDeviceVersionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceVersionDetailResponse
         */
        public DescribeDeviceVersionDetailResponse DescribeDeviceVersionDetailWithOptions(DescribeDeviceVersionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceVersionDetail",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceVersionDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询版本信息
         *
         * @param request DescribeDeviceVersionDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDeviceVersionDetailResponse
         */
        public async Task<DescribeDeviceVersionDetailResponse> DescribeDeviceVersionDetailWithOptionsAsync(DescribeDeviceVersionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                body["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDeviceVersionDetail",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDeviceVersionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询版本信息
         *
         * @param request DescribeDeviceVersionDetailRequest
         * @return DescribeDeviceVersionDetailResponse
         */
        public DescribeDeviceVersionDetailResponse DescribeDeviceVersionDetail(DescribeDeviceVersionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceVersionDetailWithOptions(request, runtime);
        }

        /**
         * @summary 查询版本信息
         *
         * @param request DescribeDeviceVersionDetailRequest
         * @return DescribeDeviceVersionDetailResponse
         */
        public async Task<DescribeDeviceVersionDetailResponse> DescribeDeviceVersionDetailAsync(DescribeDeviceVersionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceVersionDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询设备标签数量
         *
         * @param request DescribeSnLabelCountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSnLabelCountsResponse
         */
        public DescribeSnLabelCountsResponse DescribeSnLabelCountsWithOptions(DescribeSnLabelCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelList))
            {
                body["LabelList"] = request.LabelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneName))
            {
                body["ZoneName"] = request.ZoneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnLabelCounts",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnLabelCountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询设备标签数量
         *
         * @param request DescribeSnLabelCountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSnLabelCountsResponse
         */
        public async Task<DescribeSnLabelCountsResponse> DescribeSnLabelCountsWithOptionsAsync(DescribeSnLabelCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelList))
            {
                body["LabelList"] = request.LabelList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneName))
            {
                body["ZoneName"] = request.ZoneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSnLabelCounts",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSnLabelCountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备标签数量
         *
         * @param request DescribeSnLabelCountsRequest
         * @return DescribeSnLabelCountsResponse
         */
        public DescribeSnLabelCountsResponse DescribeSnLabelCounts(DescribeSnLabelCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnLabelCountsWithOptions(request, runtime);
        }

        /**
         * @summary 查询设备标签数量
         *
         * @param request DescribeSnLabelCountsRequest
         * @return DescribeSnLabelCountsResponse
         */
        public async Task<DescribeSnLabelCountsResponse> DescribeSnLabelCountsAsync(DescribeSnLabelCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnLabelCountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询工作区域
         *
         * @param request DescribeWorkZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWorkZonesResponse
         */
        public DescribeWorkZonesResponse DescribeWorkZonesWithOptions(DescribeWorkZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIdList))
            {
                body["ZoneIdList"] = request.ZoneIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneNameList))
            {
                body["ZoneNameList"] = request.ZoneNameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkZones",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWorkZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询工作区域
         *
         * @param request DescribeWorkZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWorkZonesResponse
         */
        public async Task<DescribeWorkZonesResponse> DescribeWorkZonesWithOptionsAsync(DescribeWorkZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneIdList))
            {
                body["ZoneIdList"] = request.ZoneIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneNameList))
            {
                body["ZoneNameList"] = request.ZoneNameList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkZones",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWorkZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询工作区域
         *
         * @param request DescribeWorkZonesRequest
         * @return DescribeWorkZonesResponse
         */
        public DescribeWorkZonesResponse DescribeWorkZones(DescribeWorkZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWorkZonesWithOptions(request, runtime);
        }

        /**
         * @summary 查询工作区域
         *
         * @param request DescribeWorkZonesRequest
         * @return DescribeWorkZonesResponse
         */
        public async Task<DescribeWorkZonesResponse> DescribeWorkZonesAsync(DescribeWorkZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWorkZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设备解绑终端用户
         *
         * @param request DetachEndUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachEndUsersResponse
         */
        public DetachEndUsersResponse DetachEndUsersWithOptions(DetachEndUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEndUsers",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEndUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备解绑终端用户
         *
         * @param request DetachEndUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachEndUsersResponse
         */
        public async Task<DetachEndUsersResponse> DetachEndUsersWithOptionsAsync(DetachEndUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserIds))
            {
                body["EndUserIds"] = request.EndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachEndUsers",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachEndUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备解绑终端用户
         *
         * @param request DetachEndUsersRequest
         * @return DetachEndUsersResponse
         */
        public DetachEndUsersResponse DetachEndUsers(DetachEndUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachEndUsersWithOptions(request, runtime);
        }

        /**
         * @summary 设备解绑终端用户
         *
         * @param request DetachEndUsersRequest
         * @return DetachEndUsersResponse
         */
        public async Task<DetachEndUsersResponse> DetachEndUsersAsync(DetachEndUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachEndUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request DetachLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLabelResponse
         */
        public DetachLabelResponse DetachLabelWithOptions(DetachLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request DetachLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLabelResponse
         */
        public async Task<DetachLabelResponse> DetachLabelWithOptionsAsync(DetachLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request DetachLabelRequest
         * @return DetachLabelResponse
         */
        public DetachLabelResponse DetachLabel(DetachLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachLabelWithOptions(request, runtime);
        }

        /**
         * @summary 设备绑定标签
         *
         * @param request DetachLabelRequest
         * @return DetachLabelResponse
         */
        public async Task<DetachLabelResponse> DetachLabelAsync(DetachLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量解绑标签
         *
         * @param request DetachLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLabelsResponse
         */
        public DetachLabelsResponse DetachLabelsWithOptions(DetachLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["LabelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量解绑标签
         *
         * @param request DetachLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachLabelsResponse
         */
        public async Task<DetachLabelsResponse> DetachLabelsWithOptionsAsync(DetachLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelIds))
            {
                body["LabelIds"] = request.LabelIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量解绑标签
         *
         * @param request DetachLabelsRequest
         * @return DetachLabelsResponse
         */
        public DetachLabelsResponse DetachLabels(DetachLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 批量解绑标签
         *
         * @param request DetachLabelsRequest
         * @return DetachLabelsResponse
         */
        public async Task<DetachLabelsResponse> DetachLabelsAsync(DetachLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户上传的文件
         *
         * @param request GenerateOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateOssUrlResponse
         */
        public GenerateOssUrlResponse GenerateOssUrlWithOptions(GenerateOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectNameList))
            {
                body["ObjectNameList"] = request.ObjectNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateOssUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOssUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户上传的文件
         *
         * @param request GenerateOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GenerateOssUrlResponse
         */
        public async Task<GenerateOssUrlResponse> GenerateOssUrlWithOptionsAsync(GenerateOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectNameList))
            {
                body["ObjectNameList"] = request.ObjectNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["SessionId"] = request.SessionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateOssUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateOssUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户上传的文件
         *
         * @param request GenerateOssUrlRequest
         * @return GenerateOssUrlResponse
         */
        public GenerateOssUrlResponse GenerateOssUrl(GenerateOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOssUrlWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户上传的文件
         *
         * @param request GenerateOssUrlRequest
         * @return GenerateOssUrlResponse
         */
        public async Task<GenerateOssUrlResponse> GenerateOssUrlAsync(GenerateOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOssUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取应用最新版本
         *
         * @param request GetAppOtaLatestVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppOtaLatestVersionResponse
         */
        public GetAppOtaLatestVersionResponse GetAppOtaLatestVersionWithOptions(GetAppOtaLatestVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                query["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppOtaLatestVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppOtaLatestVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取应用最新版本
         *
         * @param request GetAppOtaLatestVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAppOtaLatestVersionResponse
         */
        public async Task<GetAppOtaLatestVersionResponse> GetAppOtaLatestVersionWithOptionsAsync(GetAppOtaLatestVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                query["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppOtaLatestVersion",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppOtaLatestVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取应用最新版本
         *
         * @param request GetAppOtaLatestVersionRequest
         * @return GetAppOtaLatestVersionResponse
         */
        public GetAppOtaLatestVersionResponse GetAppOtaLatestVersion(GetAppOtaLatestVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppOtaLatestVersionWithOptions(request, runtime);
        }

        /**
         * @summary 获取应用最新版本
         *
         * @param request GetAppOtaLatestVersionRequest
         * @return GetAppOtaLatestVersionResponse
         */
        public async Task<GetAppOtaLatestVersionResponse> GetAppOtaLatestVersionAsync(GetAppOtaLatestVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppOtaLatestVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备配置
         *
         * @param request GetDeviceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceConfigsResponse
         */
        public GetDeviceConfigsResponse GetDeviceConfigsWithOptions(GetDeviceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrclVersion))
            {
                body["UrclVersion"] = request.UrclVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceConfigs",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备配置
         *
         * @param request GetDeviceConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceConfigsResponse
         */
        public async Task<GetDeviceConfigsResponse> GetDeviceConfigsWithOptionsAsync(GetDeviceConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrclVersion))
            {
                body["UrclVersion"] = request.UrclVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceConfigs",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备配置
         *
         * @param request GetDeviceConfigsRequest
         * @return GetDeviceConfigsResponse
         */
        public GetDeviceConfigsResponse GetDeviceConfigs(GetDeviceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceConfigsWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备配置
         *
         * @param request GetDeviceConfigsRequest
         * @return GetDeviceConfigsResponse
         */
        public async Task<GetDeviceConfigsResponse> GetDeviceConfigsAsync(GetDeviceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取是否开启自动升级状态
         *
         * @param request GetDeviceOtaAutoStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaAutoStatusResponse
         */
        public GetDeviceOtaAutoStatusResponse GetDeviceOtaAutoStatusWithOptions(GetDeviceOtaAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaAutoStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaAutoStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取是否开启自动升级状态
         *
         * @param request GetDeviceOtaAutoStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaAutoStatusResponse
         */
        public async Task<GetDeviceOtaAutoStatusResponse> GetDeviceOtaAutoStatusWithOptionsAsync(GetDeviceOtaAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaAutoStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaAutoStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取是否开启自动升级状态
         *
         * @param request GetDeviceOtaAutoStatusRequest
         * @return GetDeviceOtaAutoStatusResponse
         */
        public GetDeviceOtaAutoStatusResponse GetDeviceOtaAutoStatus(GetDeviceOtaAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceOtaAutoStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获取是否开启自动升级状态
         *
         * @param request GetDeviceOtaAutoStatusRequest
         * @return GetDeviceOtaAutoStatusResponse
         */
        public async Task<GetDeviceOtaAutoStatusResponse> GetDeviceOtaAutoStatusAsync(GetDeviceOtaAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceOtaAutoStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaInfoResponse
         */
        public GetDeviceOtaInfoResponse GetDeviceOtaInfoWithOptions(GetDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsVersion))
            {
                body["OsVersion"] = request.OsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersionType))
            {
                body["TargetVersionType"] = request.TargetVersionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaInfoResponse
         */
        public async Task<GetDeviceOtaInfoResponse> GetDeviceOtaInfoWithOptionsAsync(GetDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsVersion))
            {
                body["OsVersion"] = request.OsVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersionType))
            {
                body["TargetVersionType"] = request.TargetVersionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoRequest
         * @return GetDeviceOtaInfoResponse
         */
        public GetDeviceOtaInfoResponse GetDeviceOtaInfo(GetDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceOtaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoRequest
         * @return GetDeviceOtaInfoResponse
         */
        public async Task<GetDeviceOtaInfoResponse> GetDeviceOtaInfoAsync(GetDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceOtaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoTestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaInfoTestResponse
         */
        public GetDeviceOtaInfoTestResponse GetDeviceOtaInfoTestWithOptions(GetDeviceOtaInfoTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaInfoTest",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaInfoTestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoTestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaInfoTestResponse
         */
        public async Task<GetDeviceOtaInfoTestResponse> GetDeviceOtaInfoTestWithOptionsAsync(GetDeviceOtaInfoTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaInfoTest",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaInfoTestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoTestRequest
         * @return GetDeviceOtaInfoTestResponse
         */
        public GetDeviceOtaInfoTestResponse GetDeviceOtaInfoTest(GetDeviceOtaInfoTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceOtaInfoTestWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备升级信息
         *
         * @param request GetDeviceOtaInfoTestRequest
         * @return GetDeviceOtaInfoTestResponse
         */
        public async Task<GetDeviceOtaInfoTestResponse> GetDeviceOtaInfoTestAsync(GetDeviceOtaInfoTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceOtaInfoTestWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取租户任务版本信息
         *
         * @param request GetDeviceOtaTaskVersionInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaTaskVersionInfoResponse
         */
        public GetDeviceOtaTaskVersionInfoResponse GetDeviceOtaTaskVersionInfoWithOptions(GetDeviceOtaTaskVersionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaTaskVersionInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaTaskVersionInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户任务版本信息
         *
         * @param request GetDeviceOtaTaskVersionInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceOtaTaskVersionInfoResponse
         */
        public async Task<GetDeviceOtaTaskVersionInfoResponse> GetDeviceOtaTaskVersionInfoWithOptionsAsync(GetDeviceOtaTaskVersionInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceOtaTaskVersionInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceOtaTaskVersionInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户任务版本信息
         *
         * @param request GetDeviceOtaTaskVersionInfoRequest
         * @return GetDeviceOtaTaskVersionInfoResponse
         */
        public GetDeviceOtaTaskVersionInfoResponse GetDeviceOtaTaskVersionInfo(GetDeviceOtaTaskVersionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceOtaTaskVersionInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取租户任务版本信息
         *
         * @param request GetDeviceOtaTaskVersionInfoRequest
         * @return GetDeviceOtaTaskVersionInfoResponse
         */
        public async Task<GetDeviceOtaTaskVersionInfoResponse> GetDeviceOtaTaskVersionInfoAsync(GetDeviceOtaTaskVersionInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceOtaTaskVersionInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得设备升级详情
         *
         * @param request GetDeviceUpgradeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceUpgradeStatusResponse
         */
        public GetDeviceUpgradeStatusResponse GetDeviceUpgradeStatusWithOptions(GetDeviceUpgradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUid))
            {
                query["TaskUid"] = request.TaskUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceUpgradeStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获得设备升级详情
         *
         * @param request GetDeviceUpgradeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDeviceUpgradeStatusResponse
         */
        public async Task<GetDeviceUpgradeStatusResponse> GetDeviceUpgradeStatusWithOptionsAsync(GetDeviceUpgradeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                query["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUid))
            {
                query["TaskUid"] = request.TaskUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeviceUpgradeStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeviceUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获得设备升级详情
         *
         * @param request GetDeviceUpgradeStatusRequest
         * @return GetDeviceUpgradeStatusResponse
         */
        public GetDeviceUpgradeStatusResponse GetDeviceUpgradeStatus(GetDeviceUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceUpgradeStatusWithOptions(request, runtime);
        }

        /**
         * @summary 获得设备升级详情
         *
         * @param request GetDeviceUpgradeStatusRequest
         * @return GetDeviceUpgradeStatusResponse
         */
        public async Task<GetDeviceUpgradeStatusResponse> GetDeviceUpgradeStatusAsync(GetDeviceUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceUpgradeStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 导出设备工位列表
         *
         * @param request GetExportDeviceInfoOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExportDeviceInfoOssUrlResponse
         */
        public GetExportDeviceInfoOssUrlResponse GetExportDeviceInfoOssUrlWithOptions(GetExportDeviceInfoOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneName))
            {
                body["ZoneName"] = request.ZoneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExportDeviceInfoOssUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExportDeviceInfoOssUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 导出设备工位列表
         *
         * @param request GetExportDeviceInfoOssUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExportDeviceInfoOssUrlResponse
         */
        public async Task<GetExportDeviceInfoOssUrlResponse> GetExportDeviceInfoOssUrlWithOptionsAsync(GetExportDeviceInfoOssUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneName))
            {
                body["ZoneName"] = request.ZoneName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExportDeviceInfoOssUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExportDeviceInfoOssUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 导出设备工位列表
         *
         * @param request GetExportDeviceInfoOssUrlRequest
         * @return GetExportDeviceInfoOssUrlResponse
         */
        public GetExportDeviceInfoOssUrlResponse GetExportDeviceInfoOssUrl(GetExportDeviceInfoOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExportDeviceInfoOssUrlWithOptions(request, runtime);
        }

        /**
         * @summary 导出设备工位列表
         *
         * @param request GetExportDeviceInfoOssUrlRequest
         * @return GetExportDeviceInfoOssUrlResponse
         */
        public async Task<GetExportDeviceInfoOssUrlResponse> GetExportDeviceInfoOssUrlAsync(GetExportDeviceInfoOssUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExportDeviceInfoOssUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询OSS配置信息
         *
         * @param request GetFbOssConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFbOssConfigResponse
         */
        public GetFbOssConfigResponse GetFbOssConfigWithOptions(GetFbOssConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPrefix))
            {
                body["DirPrefix"] = request.DirPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDedicatedLine))
            {
                body["IsDedicatedLine"] = request.IsDedicatedLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFbOssConfig",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFbOssConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询OSS配置信息
         *
         * @param request GetFbOssConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFbOssConfigResponse
         */
        public async Task<GetFbOssConfigResponse> GetFbOssConfigWithOptionsAsync(GetFbOssConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPrefix))
            {
                body["DirPrefix"] = request.DirPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDedicatedLine))
            {
                body["IsDedicatedLine"] = request.IsDedicatedLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFbOssConfig",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFbOssConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询OSS配置信息
         *
         * @param request GetFbOssConfigRequest
         * @return GetFbOssConfigResponse
         */
        public GetFbOssConfigResponse GetFbOssConfig(GetFbOssConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFbOssConfigWithOptions(request, runtime);
        }

        /**
         * @summary 查询OSS配置信息
         *
         * @param request GetFbOssConfigRequest
         * @return GetFbOssConfigResponse
         */
        public async Task<GetFbOssConfigResponse> GetFbOssConfigAsync(GetFbOssConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFbOssConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取OSS配置
         *
         * @param request GetOssConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssConfigResponse
         */
        public GetOssConfigResponse GetOssConfigWithOptions(GetOssConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssConfig",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取OSS配置
         *
         * @param request GetOssConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOssConfigResponse
         */
        public async Task<GetOssConfigResponse> GetOssConfigWithOptionsAsync(GetOssConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOssConfig",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOssConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取OSS配置
         *
         * @param request GetOssConfigRequest
         * @return GetOssConfigResponse
         */
        public GetOssConfigResponse GetOssConfig(GetOssConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOssConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取OSS配置
         *
         * @param request GetOssConfigRequest
         * @return GetOssConfigResponse
         */
        public async Task<GetOssConfigResponse> GetOssConfigAsync(GetOssConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOssConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取版本下载地址
         *
         * @param request GetVersionDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVersionDownloadUrlResponse
         */
        public GetVersionDownloadUrlResponse GetVersionDownloadUrlWithOptions(GetVersionDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVersionDownloadUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVersionDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取版本下载地址
         *
         * @param request GetVersionDownloadUrlRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetVersionDownloadUrlResponse
         */
        public async Task<GetVersionDownloadUrlResponse> GetVersionDownloadUrlWithOptionsAsync(GetVersionDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionName))
            {
                query["VersionName"] = request.VersionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVersionDownloadUrl",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVersionDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取版本下载地址
         *
         * @param request GetVersionDownloadUrlRequest
         * @return GetVersionDownloadUrlResponse
         */
        public GetVersionDownloadUrlResponse GetVersionDownloadUrl(GetVersionDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVersionDownloadUrlWithOptions(request, runtime);
        }

        /**
         * @summary 获取版本下载地址
         *
         * @param request GetVersionDownloadUrlRequest
         * @return GetVersionDownloadUrlResponse
         */
        public async Task<GetVersionDownloadUrlResponse> GetVersionDownloadUrlAsync(GetVersionDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVersionDownloadUrlWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取租户ota任务
         *
         * @param request ListDeviceOtaTaskByTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceOtaTaskByTenantResponse
         */
        public ListDeviceOtaTaskByTenantResponse ListDeviceOtaTaskByTenantWithOptions(ListDeviceOtaTaskByTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceOtaTaskByTenant",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceOtaTaskByTenantResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户ota任务
         *
         * @param request ListDeviceOtaTaskByTenantRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceOtaTaskByTenantResponse
         */
        public async Task<ListDeviceOtaTaskByTenantResponse> ListDeviceOtaTaskByTenantWithOptionsAsync(ListDeviceOtaTaskByTenantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceOtaTaskByTenant",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceOtaTaskByTenantResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户ota任务
         *
         * @param request ListDeviceOtaTaskByTenantRequest
         * @return ListDeviceOtaTaskByTenantResponse
         */
        public ListDeviceOtaTaskByTenantResponse ListDeviceOtaTaskByTenant(ListDeviceOtaTaskByTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceOtaTaskByTenantWithOptions(request, runtime);
        }

        /**
         * @summary 获取租户ota任务
         *
         * @param request ListDeviceOtaTaskByTenantRequest
         * @return ListDeviceOtaTaskByTenantResponse
         */
        public async Task<ListDeviceOtaTaskByTenantResponse> ListDeviceOtaTaskByTenantAsync(ListDeviceOtaTaskByTenantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceOtaTaskByTenantWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询设备座位列表
         *
         * @param request ListDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceSeatsResponse
         */
        public ListDeviceSeatsResponse ListDeviceSeatsWithOptions(ListDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNo))
            {
                body["SeatNo"] = request.SeatNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceSeatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询设备座位列表
         *
         * @param request ListDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDeviceSeatsResponse
         */
        public async Task<ListDeviceSeatsResponse> ListDeviceSeatsWithOptionsAsync(ListDeviceSeatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeatNo))
            {
                body["SeatNo"] = request.SeatNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoList))
            {
                body["SerialNoList"] = request.SerialNoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeviceSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询设备座位列表
         *
         * @param request ListDeviceSeatsRequest
         * @return ListDeviceSeatsResponse
         */
        public ListDeviceSeatsResponse ListDeviceSeats(ListDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceSeatsWithOptions(request, runtime);
        }

        /**
         * @summary 查询设备座位列表
         *
         * @param request ListDeviceSeatsRequest
         * @return ListDeviceSeatsResponse
         */
        public async Task<ListDeviceSeatsResponse> ListDeviceSeatsAsync(ListDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取设备列表
         *
         * @param request ListDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDevicesResponse
         */
        public ListDevicesResponse ListDevicesWithOptions(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIpV4))
            {
                query["DeviceIpV4"] = request.DeviceIpV4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceOS))
            {
                query["DeviceOS"] = request.DeviceOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevicePlatform))
            {
                query["DevicePlatform"] = request.DevicePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                query["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                body["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取设备列表
         *
         * @param request ListDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDevicesResponse
         */
        public async Task<ListDevicesResponse> ListDevicesWithOptionsAsync(ListDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceIpV4))
            {
                query["DeviceIpV4"] = request.DeviceIpV4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceName))
            {
                query["DeviceName"] = request.DeviceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceOS))
            {
                query["DeviceOS"] = request.DeviceOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DevicePlatform))
            {
                query["DevicePlatform"] = request.DevicePlatform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                query["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceGroupId))
            {
                body["DeviceGroupId"] = request.DeviceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndUserId))
            {
                body["EndUserId"] = request.EndUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取设备列表
         *
         * @param request ListDevicesRequest
         * @return ListDevicesResponse
         */
        public ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 获取设备列表
         *
         * @param request ListDevicesRequest
         * @return ListDevicesResponse
         */
        public async Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户问题标签
         *
         * @param request ListFbIssueLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFbIssueLabelsResponse
         */
        public ListFbIssueLabelsResponse ListFbIssueLabelsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFbIssueLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFbIssueLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户问题标签
         *
         * @param request ListFbIssueLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFbIssueLabelsResponse
         */
        public async Task<ListFbIssueLabelsResponse> ListFbIssueLabelsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFbIssueLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFbIssueLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户问题标签
         *
         * @return ListFbIssueLabelsResponse
         */
        public ListFbIssueLabelsResponse ListFbIssueLabels()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFbIssueLabelsWithOptions(runtime);
        }

        /**
         * @summary 查询用户问题标签
         *
         * @return ListFbIssueLabelsResponse
         */
        public async Task<ListFbIssueLabelsResponse> ListFbIssueLabelsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFbIssueLabelsWithOptionsAsync(runtime);
        }

        /**
         * @summary 根据语言类型和调用方查询标签列表
         *
         * @param request ListFbIssueLabelsByLCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFbIssueLabelsByLCResponse
         */
        public ListFbIssueLabelsByLCResponse ListFbIssueLabelsByLCWithOptions(ListFbIssueLabelsByLCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageType))
            {
                body["LanguageType"] = request.LanguageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFbIssueLabelsByLC",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFbIssueLabelsByLCResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据语言类型和调用方查询标签列表
         *
         * @param request ListFbIssueLabelsByLCRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListFbIssueLabelsByLCResponse
         */
        public async Task<ListFbIssueLabelsByLCResponse> ListFbIssueLabelsByLCWithOptionsAsync(ListFbIssueLabelsByLCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                body["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LanguageType))
            {
                body["LanguageType"] = request.LanguageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFbIssueLabelsByLC",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFbIssueLabelsByLCResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据语言类型和调用方查询标签列表
         *
         * @param request ListFbIssueLabelsByLCRequest
         * @return ListFbIssueLabelsByLCResponse
         */
        public ListFbIssueLabelsByLCResponse ListFbIssueLabelsByLC(ListFbIssueLabelsByLCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFbIssueLabelsByLCWithOptions(request, runtime);
        }

        /**
         * @summary 根据语言类型和调用方查询标签列表
         *
         * @param request ListFbIssueLabelsByLCRequest
         * @return ListFbIssueLabelsByLCResponse
         */
        public async Task<ListFbIssueLabelsByLCResponse> ListFbIssueLabelsByLCAsync(ListFbIssueLabelsByLCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFbIssueLabelsByLCWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取标签列表
         *
         * @param request ListLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLabelsResponse
         */
        public ListLabelsResponse ListLabelsWithOptions(ListLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLabelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取标签列表
         *
         * @param request ListLabelsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLabelsResponse
         */
        public async Task<ListLabelsResponse> ListLabelsWithOptionsAsync(ListLabelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLabels",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLabelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取标签列表
         *
         * @param request ListLabelsRequest
         * @return ListLabelsResponse
         */
        public ListLabelsResponse ListLabels(ListLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLabelsWithOptions(request, runtime);
        }

        /**
         * @summary 获取标签列表
         *
         * @param request ListLabelsRequest
         * @return ListLabelsResponse
         */
        public async Task<ListLabelsResponse> ListLabelsAsync(ListLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLabelsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取租户升级设备信息
         *
         * @param request ListTenantDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantDeviceOtaInfoResponse
         */
        public ListTenantDeviceOtaInfoResponse ListTenantDeviceOtaInfoWithOptions(ListTenantDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantDeviceOtaInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取租户升级设备信息
         *
         * @param request ListTenantDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantDeviceOtaInfoResponse
         */
        public async Task<ListTenantDeviceOtaInfoResponse> ListTenantDeviceOtaInfoWithOptionsAsync(ListTenantDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantDeviceOtaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取租户升级设备信息
         *
         * @param request ListTenantDeviceOtaInfoRequest
         * @return ListTenantDeviceOtaInfoResponse
         */
        public ListTenantDeviceOtaInfoResponse ListTenantDeviceOtaInfo(ListTenantDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTenantDeviceOtaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 获取租户升级设备信息
         *
         * @param request ListTenantDeviceOtaInfoRequest
         * @return ListTenantDeviceOtaInfoResponse
         */
        public async Task<ListTenantDeviceOtaInfoResponse> ListTenantDeviceOtaInfoAsync(ListTenantDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTenantDeviceOtaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询终端列表
         *
         * @param request ListTerminalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTerminalResponse
         */
        public ListTerminalResponse ListTerminalWithOptions(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询终端列表
         *
         * @param request ListTerminalRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTerminalResponse
         */
        public async Task<ListTerminalResponse> ListTerminalWithOptionsAsync(ListTerminalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InManage))
            {
                body["InManage"] = request.InManage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv4))
            {
                body["Ipv4"] = request.Ipv4;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocationInfo))
            {
                body["LocationInfo"] = request.LocationInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminal",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询终端列表
         *
         * @param request ListTerminalRequest
         * @return ListTerminalResponse
         */
        public ListTerminalResponse ListTerminal(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTerminalWithOptions(request, runtime);
        }

        /**
         * @summary 查询终端列表
         *
         * @param request ListTerminalRequest
         * @return ListTerminalResponse
         */
        public async Task<ListTerminalResponse> ListTerminalAsync(ListTerminalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTerminalWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询终端基本信息
         *
         * @param request ListTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTerminalsResponse
         */
        public ListTerminalsResponse ListTerminalsWithOptions(ListTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量查询终端基本信息
         *
         * @param request ListTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTerminalsResponse
         */
        public async Task<ListTerminalsResponse> ListTerminalsWithOptionsAsync(ListTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumbers))
            {
                query["SerialNumbers"] = request.SerialNumbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                query["Uuids"] = request.Uuids;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchKeyword))
            {
                body["SearchKeyword"] = request.SearchKeyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalGroupId))
            {
                body["TerminalGroupId"] = request.TerminalGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量查询终端基本信息
         *
         * @param request ListTerminalsRequest
         * @return ListTerminalsResponse
         */
        public ListTerminalsResponse ListTerminals(ListTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTerminalsWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询终端基本信息
         *
         * @param request ListTerminalsRequest
         * @return ListTerminalsResponse
         */
        public async Task<ListTerminalsResponse> ListTerminalsAsync(ListTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTerminalsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询可信设备列表
         *
         * @param request ListTrustDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrustDevicesResponse
         */
        public ListTrustDevicesResponse ListTrustDevicesWithOptions(ListTrustDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrustDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrustDevicesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询可信设备列表
         *
         * @param request ListTrustDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTrustDevicesResponse
         */
        public async Task<ListTrustDevicesResponse> ListTrustDevicesWithOptionsAsync(ListTrustDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCustomId))
            {
                body["UserCustomId"] = request.UserCustomId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrustDevices",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrustDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询可信设备列表
         *
         * @param request ListTrustDevicesRequest
         * @return ListTrustDevicesResponse
         */
        public ListTrustDevicesResponse ListTrustDevices(ListTrustDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrustDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 查询可信设备列表
         *
         * @param request ListTrustDevicesRequest
         * @return ListTrustDevicesResponse
         */
        public async Task<ListTrustDevicesResponse> ListTrustDevicesAsync(ListTrustDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrustDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询问题反馈列表
         *
         * @param request ListUserFbAcIssuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserFbAcIssuesResponse
         */
        public ListUserFbAcIssuesResponse ListUserFbAcIssuesWithOptions(ListUserFbAcIssuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                body["ErrorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueId))
            {
                body["IssueId"] = request.IssueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserFbAcIssues",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserFbAcIssuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询问题反馈列表
         *
         * @param request ListUserFbAcIssuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserFbAcIssuesResponse
         */
        public async Task<ListUserFbAcIssuesResponse> ListUserFbAcIssuesWithOptionsAsync(ListUserFbAcIssuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMessage))
            {
                body["ErrorMessage"] = request.ErrorMessage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueId))
            {
                body["IssueId"] = request.IssueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                body["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserFbAcIssues",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserFbAcIssuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询问题反馈列表
         *
         * @param request ListUserFbAcIssuesRequest
         * @return ListUserFbAcIssuesResponse
         */
        public ListUserFbAcIssuesResponse ListUserFbAcIssues(ListUserFbAcIssuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserFbAcIssuesWithOptions(request, runtime);
        }

        /**
         * @summary 查询问题反馈列表
         *
         * @param request ListUserFbAcIssuesRequest
         * @return ListUserFbAcIssuesResponse
         */
        public async Task<ListUserFbAcIssuesResponse> ListUserFbAcIssuesAsync(ListUserFbAcIssuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserFbAcIssuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户反馈问题列表
         *
         * @param request ListUserFbIssuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserFbIssuesResponse
         */
        public ListUserFbIssuesResponse ListUserFbIssuesWithOptions(ListUserFbIssuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientModel))
            {
                body["ClientModel"] = request.ClientModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSn))
            {
                body["ClientSn"] = request.ClientSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                body["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FbType))
            {
                body["FbType"] = request.FbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueId))
            {
                body["IssueId"] = request.IssueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueLabel))
            {
                body["IssueLabel"] = request.IssueLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WasRead))
            {
                body["WasRead"] = request.WasRead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserFbIssues",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserFbIssuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询用户反馈问题列表
         *
         * @param request ListUserFbIssuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserFbIssuesResponse
         */
        public async Task<ListUserFbIssuesResponse> ListUserFbIssuesWithOptionsAsync(ListUserFbIssuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientModel))
            {
                body["ClientModel"] = request.ClientModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSn))
            {
                body["ClientSn"] = request.ClientSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                body["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FbType))
            {
                body["FbType"] = request.FbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueId))
            {
                body["IssueId"] = request.IssueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueLabel))
            {
                body["IssueLabel"] = request.IssueLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WasRead))
            {
                body["WasRead"] = request.WasRead;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserFbIssues",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserFbIssuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户反馈问题列表
         *
         * @param request ListUserFbIssuesRequest
         * @return ListUserFbIssuesResponse
         */
        public ListUserFbIssuesResponse ListUserFbIssues(ListUserFbIssuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserFbIssuesWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户反馈问题列表
         *
         * @param request ListUserFbIssuesRequest
         * @return ListUserFbIssuesResponse
         */
        public async Task<ListUserFbIssuesResponse> ListUserFbIssuesAsync(ListUserFbIssuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserFbIssuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改设备安全入网类型
         *
         * @param request ModifyDevicesSecureNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDevicesSecureNetworkTypeResponse
         */
        public ModifyDevicesSecureNetworkTypeResponse ModifyDevicesSecureNetworkTypeWithOptions(ModifyDevicesSecureNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDevices))
            {
                body["AllDevices"] = request.AllDevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNos))
            {
                body["SerialNos"] = request.SerialNos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDevicesSecureNetworkType",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDevicesSecureNetworkTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改设备安全入网类型
         *
         * @param request ModifyDevicesSecureNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDevicesSecureNetworkTypeResponse
         */
        public async Task<ModifyDevicesSecureNetworkTypeResponse> ModifyDevicesSecureNetworkTypeWithOptionsAsync(ModifyDevicesSecureNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDevices))
            {
                body["AllDevices"] = request.AllDevices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNos))
            {
                body["SerialNos"] = request.SerialNos;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDevicesSecureNetworkType",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDevicesSecureNetworkTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改设备安全入网类型
         *
         * @param request ModifyDevicesSecureNetworkTypeRequest
         * @return ModifyDevicesSecureNetworkTypeResponse
         */
        public ModifyDevicesSecureNetworkTypeResponse ModifyDevicesSecureNetworkType(ModifyDevicesSecureNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDevicesSecureNetworkTypeWithOptions(request, runtime);
        }

        /**
         * @summary 修改设备安全入网类型
         *
         * @param request ModifyDevicesSecureNetworkTypeRequest
         * @return ModifyDevicesSecureNetworkTypeResponse
         */
        public async Task<ModifyDevicesSecureNetworkTypeResponse> ModifyDevicesSecureNetworkTypeAsync(ModifyDevicesSecureNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDevicesSecureNetworkTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 匿名api修改安全入网配置
         *
         * @param request ModifySecureNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecureNetworkTypeResponse
         */
        public ModifySecureNetworkTypeResponse ModifySecureNetworkTypeWithOptions(ModifySecureNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecureNetworkType",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecureNetworkTypeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 匿名api修改安全入网配置
         *
         * @param request ModifySecureNetworkTypeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySecureNetworkTypeResponse
         */
        public async Task<ModifySecureNetworkTypeResponse> ModifySecureNetworkTypeWithOptionsAsync(ModifySecureNetworkTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecureNetworkType))
            {
                body["SecureNetworkType"] = request.SecureNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySecureNetworkType",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySecureNetworkTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 匿名api修改安全入网配置
         *
         * @param request ModifySecureNetworkTypeRequest
         * @return ModifySecureNetworkTypeResponse
         */
        public ModifySecureNetworkTypeResponse ModifySecureNetworkType(ModifySecureNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecureNetworkTypeWithOptions(request, runtime);
        }

        /**
         * @summary 匿名api修改安全入网配置
         *
         * @param request ModifySecureNetworkTypeRequest
         * @return ModifySecureNetworkTypeResponse
         */
        public async Task<ModifySecureNetworkTypeResponse> ModifySecureNetworkTypeAsync(ModifySecureNetworkTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecureNetworkTypeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设备注册
         *
         * @param request RegisterDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bluetooth))
            {
                body["Bluetooth"] = request.Bluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChipId))
            {
                body["ChipId"] = request.ChipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtherMac))
            {
                body["EtherMac"] = request.EtherMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                body["Storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wlan))
            {
                body["Wlan"] = request.Wlan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDevice",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设备注册
         *
         * @param request RegisterDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bluetooth))
            {
                body["Bluetooth"] = request.Bluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuildId))
            {
                body["BuildId"] = request.BuildId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChipId))
            {
                body["ChipId"] = request.ChipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomId))
            {
                body["CustomId"] = request.CustomId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtherMac))
            {
                body["EtherMac"] = request.EtherMac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Storage))
            {
                body["Storage"] = request.Storage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                body["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Wlan))
            {
                body["Wlan"] = request.Wlan;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterDevice",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设备注册
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        /**
         * @summary 设备注册
         *
         * @param request RegisterDeviceRequest
         * @return RegisterDeviceResponse
         */
        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 上报升级信息
         *
         * @param request ReportAppOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportAppOtaInfoResponse
         */
        public ReportAppOtaInfoResponse ReportAppOtaInfoWithOptions(ReportAppOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                query["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUid))
            {
                query["TaskUid"] = request.TaskUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportAppOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportAppOtaInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 上报升级信息
         *
         * @param request ReportAppOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportAppOtaInfoResponse
         */
        public async Task<ReportAppOtaInfoResponse> ReportAppOtaInfoWithOptionsAsync(ReportAppOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                query["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientUid))
            {
                query["ClientUid"] = request.ClientUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                query["Project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUid))
            {
                query["TaskUid"] = request.TaskUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportAppOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportAppOtaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 上报升级信息
         *
         * @param request ReportAppOtaInfoRequest
         * @return ReportAppOtaInfoResponse
         */
        public ReportAppOtaInfoResponse ReportAppOtaInfo(ReportAppOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportAppOtaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 上报升级信息
         *
         * @param request ReportAppOtaInfoRequest
         * @return ReportAppOtaInfoResponse
         */
        public async Task<ReportAppOtaInfoResponse> ReportAppOtaInfoAsync(ReportAppOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportAppOtaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 升级信息上报
         *
         * @param request ReportDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportDeviceOtaInfoResponse
         */
        public ReportDeviceOtaInfoResponse ReportDeviceOtaInfoWithOptions(ReportDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportDeviceOtaInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 升级信息上报
         *
         * @param request ReportDeviceOtaInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportDeviceOtaInfoResponse
         */
        public async Task<ReportDeviceOtaInfoResponse> ReportDeviceOtaInfoWithOptionsAsync(ReportDeviceOtaInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseVersion))
            {
                body["BaseVersion"] = request.BaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                body["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                body["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                body["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportDeviceOtaInfo",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportDeviceOtaInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 升级信息上报
         *
         * @param request ReportDeviceOtaInfoRequest
         * @return ReportDeviceOtaInfoResponse
         */
        public ReportDeviceOtaInfoResponse ReportDeviceOtaInfo(ReportDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportDeviceOtaInfoWithOptions(request, runtime);
        }

        /**
         * @summary 升级信息上报
         *
         * @param request ReportDeviceOtaInfoRequest
         * @return ReportDeviceOtaInfoResponse
         */
        public async Task<ReportDeviceOtaInfoResponse> ReportDeviceOtaInfoAsync(ReportDeviceOtaInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportDeviceOtaInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 应用中心用户问题反馈
         *
         * @param tmpReq ReportUserFbAcIssueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportUserFbAcIssueResponse
         */
        public ReportUserFbAcIssueResponse ReportUserFbAcIssueWithOptions(ReportUserFbAcIssueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportUserFbAcIssueShrinkRequest request = new ReportUserFbAcIssueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileList))
            {
                request.FileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileList, "FileList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileListShrink))
            {
                body["FileList"] = request.FileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportUserFbAcIssue",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportUserFbAcIssueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 应用中心用户问题反馈
         *
         * @param tmpReq ReportUserFbAcIssueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportUserFbAcIssueResponse
         */
        public async Task<ReportUserFbAcIssueResponse> ReportUserFbAcIssueWithOptionsAsync(ReportUserFbAcIssueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportUserFbAcIssueShrinkRequest request = new ReportUserFbAcIssueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileList))
            {
                request.FileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileList, "FileList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileListShrink))
            {
                body["FileList"] = request.FileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportUserFbAcIssue",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportUserFbAcIssueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 应用中心用户问题反馈
         *
         * @param request ReportUserFbAcIssueRequest
         * @return ReportUserFbAcIssueResponse
         */
        public ReportUserFbAcIssueResponse ReportUserFbAcIssue(ReportUserFbAcIssueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportUserFbAcIssueWithOptions(request, runtime);
        }

        /**
         * @summary 应用中心用户问题反馈
         *
         * @param request ReportUserFbAcIssueRequest
         * @return ReportUserFbAcIssueResponse
         */
        public async Task<ReportUserFbAcIssueResponse> ReportUserFbAcIssueAsync(ReportUserFbAcIssueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportUserFbAcIssueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 上报用户反馈问题
         *
         * @param tmpReq ReportUserFbIssueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportUserFbIssueResponse
         */
        public ReportUserFbIssueResponse ReportUserFbIssueWithOptions(ReportUserFbIssueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportUserFbIssueShrinkRequest request = new ReportUserFbIssueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileList))
            {
                request.FileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileList, "FileList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientModel))
            {
                body["ClientModel"] = request.ClientModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOsName))
            {
                body["ClientOsName"] = request.ClientOsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSn))
            {
                body["ClientSn"] = request.ClientSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                body["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                body["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FbType))
            {
                body["FbType"] = request.FbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileListShrink))
            {
                body["FileList"] = request.FileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueLabel))
            {
                body["IssueLabel"] = request.IssueLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurTime))
            {
                body["OccurTime"] = request.OccurTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelNo))
            {
                body["TelNo"] = request.TelNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportUserFbIssue",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportUserFbIssueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 上报用户反馈问题
         *
         * @param tmpReq ReportUserFbIssueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReportUserFbIssueResponse
         */
        public async Task<ReportUserFbIssueResponse> ReportUserFbIssueWithOptionsAsync(ReportUserFbIssueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ReportUserFbIssueShrinkRequest request = new ReportUserFbIssueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FileList))
            {
                request.FileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FileList, "FileList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientModel))
            {
                body["ClientModel"] = request.ClientModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientOsName))
            {
                body["ClientOsName"] = request.ClientOsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSn))
            {
                body["ClientSn"] = request.ClientSn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                body["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomerId))
            {
                body["CustomerId"] = request.CustomerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopId))
            {
                body["DesktopId"] = request.DesktopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DesktopType))
            {
                body["DesktopType"] = request.DesktopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["ErrorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FbType))
            {
                body["FbType"] = request.FbType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileListShrink))
            {
                body["FileList"] = request.FileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueLabel))
            {
                body["IssueLabel"] = request.IssueLabel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OccurTime))
            {
                body["OccurTime"] = request.OccurTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedA))
            {
                body["ReservedA"] = request.ReservedA;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedB))
            {
                body["ReservedB"] = request.ReservedB;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelNo))
            {
                body["TelNo"] = request.TelNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserEmail))
            {
                body["UserEmail"] = request.UserEmail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                body["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WyId))
            {
                body["WyId"] = request.WyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReportUserFbIssue",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReportUserFbIssueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 上报用户反馈问题
         *
         * @param request ReportUserFbIssueRequest
         * @return ReportUserFbIssueResponse
         */
        public ReportUserFbIssueResponse ReportUserFbIssue(ReportUserFbIssueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportUserFbIssueWithOptions(request, runtime);
        }

        /**
         * @summary 上报用户反馈问题
         *
         * @param request ReportUserFbIssueRequest
         * @return ReportUserFbIssueResponse
         */
        public async Task<ReportUserFbIssueResponse> ReportUserFbIssueAsync(ReportUserFbIssueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportUserFbIssueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 向终端发送运维命令
         *
         * @param request SendOpsMessageToTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendOpsMessageToTerminalsResponse
         */
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminalsWithOptions(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 向终端发送运维命令
         *
         * @param request SendOpsMessageToTerminalsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendOpsMessageToTerminalsResponse
         */
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsWithOptionsAsync(SendOpsMessageToTerminalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delay))
            {
                query["Delay"] = request.Delay;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsAction))
            {
                body["OpsAction"] = request.OpsAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuids))
            {
                bodyFlat["Uuids"] = request.Uuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WaitForAck))
            {
                body["WaitForAck"] = request.WaitForAck;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendOpsMessageToTerminals",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendOpsMessageToTerminalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 向终端发送运维命令
         *
         * @param request SendOpsMessageToTerminalsRequest
         * @return SendOpsMessageToTerminalsResponse
         */
        public SendOpsMessageToTerminalsResponse SendOpsMessageToTerminals(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendOpsMessageToTerminalsWithOptions(request, runtime);
        }

        /**
         * @summary 向终端发送运维命令
         *
         * @param request SendOpsMessageToTerminalsRequest
         * @return SendOpsMessageToTerminalsResponse
         */
        public async Task<SendOpsMessageToTerminalsResponse> SendOpsMessageToTerminalsAsync(SendOpsMessageToTerminalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendOpsMessageToTerminalsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置租户ota自动开启/关闭
         *
         * @param request SetDeviceOtaAutoStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeviceOtaAutoStatusResponse
         */
        public SetDeviceOtaAutoStatusResponse SetDeviceOtaAutoStatusWithOptions(SetDeviceOtaAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdate))
            {
                body["AutoUpdate"] = request.AutoUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdateTimeSchedule))
            {
                body["AutoUpdateTimeSchedule"] = request.AutoUpdateTimeSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                body["ForceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceOtaAutoStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceOtaAutoStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置租户ota自动开启/关闭
         *
         * @param request SetDeviceOtaAutoStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeviceOtaAutoStatusResponse
         */
        public async Task<SetDeviceOtaAutoStatusResponse> SetDeviceOtaAutoStatusWithOptionsAsync(SetDeviceOtaAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdate))
            {
                body["AutoUpdate"] = request.AutoUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoUpdateTimeSchedule))
            {
                body["AutoUpdateTimeSchedule"] = request.AutoUpdateTimeSchedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                body["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceUpgrade))
            {
                body["ForceUpgrade"] = request.ForceUpgrade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceOtaAutoStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceOtaAutoStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置租户ota自动开启/关闭
         *
         * @param request SetDeviceOtaAutoStatusRequest
         * @return SetDeviceOtaAutoStatusResponse
         */
        public SetDeviceOtaAutoStatusResponse SetDeviceOtaAutoStatus(SetDeviceOtaAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceOtaAutoStatusWithOptions(request, runtime);
        }

        /**
         * @summary 设置租户ota自动开启/关闭
         *
         * @param request SetDeviceOtaAutoStatusRequest
         * @return SetDeviceOtaAutoStatusResponse
         */
        public async Task<SetDeviceOtaAutoStatusResponse> SetDeviceOtaAutoStatusAsync(SetDeviceOtaAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceOtaAutoStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 租户设置设备ota任务的状态
         *
         * @param request SetDeviceOtaTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeviceOtaTaskStatusResponse
         */
        public SetDeviceOtaTaskStatusResponse SetDeviceOtaTaskStatusWithOptions(SetDeviceOtaTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceOtaTaskStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceOtaTaskStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 租户设置设备ota任务的状态
         *
         * @param request SetDeviceOtaTaskStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDeviceOtaTaskStatusResponse
         */
        public async Task<SetDeviceOtaTaskStatusResponse> SetDeviceOtaTaskStatusWithOptionsAsync(SetDeviceOtaTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetDeviceOtaTaskStatus",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDeviceOtaTaskStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 租户设置设备ota任务的状态
         *
         * @param request SetDeviceOtaTaskStatusRequest
         * @return SetDeviceOtaTaskStatusResponse
         */
        public SetDeviceOtaTaskStatusResponse SetDeviceOtaTaskStatus(SetDeviceOtaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceOtaTaskStatusWithOptions(request, runtime);
        }

        /**
         * @summary 租户设置设备ota任务的状态
         *
         * @param request SetDeviceOtaTaskStatusRequest
         * @return SetDeviceOtaTaskStatusResponse
         */
        public async Task<SetDeviceOtaTaskStatusResponse> SetDeviceOtaTaskStatusAsync(SetDeviceOtaTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceOtaTaskStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑免账号登录用户
         *
         * @param request UnbindAccountLessLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindAccountLessLoginUserResponse
         */
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUserWithOptions(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑免账号登录用户
         *
         * @param request UnbindAccountLessLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindAccountLessLoginUserResponse
         */
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserWithOptionsAsync(UnbindAccountLessLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindAccountLessLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindAccountLessLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑免账号登录用户
         *
         * @param request UnbindAccountLessLoginUserRequest
         * @return UnbindAccountLessLoginUserResponse
         */
        public UnbindAccountLessLoginUserResponse UnbindAccountLessLoginUser(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAccountLessLoginUserWithOptions(request, runtime);
        }

        /**
         * @summary 解绑免账号登录用户
         *
         * @param request UnbindAccountLessLoginUserRequest
         * @return UnbindAccountLessLoginUserResponse
         */
        public async Task<UnbindAccountLessLoginUserResponse> UnbindAccountLessLoginUserAsync(UnbindAccountLessLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAccountLessLoginUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑设备座位
         *
         * @param tmpReq UnbindDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindDeviceSeatsResponse
         */
        public UnbindDeviceSeatsResponse UnbindDeviceSeatsWithOptions(UnbindDeviceSeatsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceSeatsShrinkRequest request = new UnbindDeviceSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SerialNoList))
            {
                request.SerialNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SerialNoList, "SerialNoList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoListShrink))
            {
                body["SerialNoList"] = request.SerialNoListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceSeatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑设备座位
         *
         * @param tmpReq UnbindDeviceSeatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindDeviceSeatsResponse
         */
        public async Task<UnbindDeviceSeatsResponse> UnbindDeviceSeatsWithOptionsAsync(UnbindDeviceSeatsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UnbindDeviceSeatsShrinkRequest request = new UnbindDeviceSeatsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SerialNoList))
            {
                request.SerialNoListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SerialNoList, "SerialNoList", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNoListShrink))
            {
                body["SerialNoList"] = request.SerialNoListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindDeviceSeats",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindDeviceSeatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑设备座位
         *
         * @param request UnbindDeviceSeatsRequest
         * @return UnbindDeviceSeatsResponse
         */
        public UnbindDeviceSeatsResponse UnbindDeviceSeats(UnbindDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDeviceSeatsWithOptions(request, runtime);
        }

        /**
         * @summary 解绑设备座位
         *
         * @param request UnbindDeviceSeatsRequest
         * @return UnbindDeviceSeatsResponse
         */
        public async Task<UnbindDeviceSeatsResponse> UnbindDeviceSeatsAsync(UnbindDeviceSeatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDeviceSeatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解绑免密登录用户
         *
         * @param request UnbindPasswordFreeLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindPasswordFreeLoginUserResponse
         */
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUserWithOptions(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解绑免密登录用户
         *
         * @param request UnbindPasswordFreeLoginUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindPasswordFreeLoginUserResponse
         */
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserWithOptionsAsync(UnbindPasswordFreeLoginUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNumber))
            {
                body["SerialNumber"] = request.SerialNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindPasswordFreeLoginUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindPasswordFreeLoginUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解绑免密登录用户
         *
         * @param request UnbindPasswordFreeLoginUserRequest
         * @return UnbindPasswordFreeLoginUserResponse
         */
        public UnbindPasswordFreeLoginUserResponse UnbindPasswordFreeLoginUser(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPasswordFreeLoginUserWithOptions(request, runtime);
        }

        /**
         * @summary 解绑免密登录用户
         *
         * @param request UnbindPasswordFreeLoginUserRequest
         * @return UnbindPasswordFreeLoginUserResponse
         */
        public async Task<UnbindPasswordFreeLoginUserResponse> UnbindPasswordFreeLoginUserAsync(UnbindPasswordFreeLoginUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPasswordFreeLoginUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新设备别名
         *
         * @param request UpdateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAliasWithOptions(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新设备别名
         *
         * @param request UpdateAliasRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasWithOptionsAsync(UpdateAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlias",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新设备别名
         *
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAliasWithOptions(request, runtime);
        }

        /**
         * @summary 更新设备别名
         *
         * @param request UpdateAliasRequest
         * @return UpdateAliasResponse
         */
        public async Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAliasWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新设备绑定的终端用户
         *
         * @param request UpdateDeviceBindedEndUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeviceBindedEndUserResponse
         */
        public UpdateDeviceBindedEndUserResponse UpdateDeviceBindedEndUserWithOptions(UpdateDeviceBindedEndUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAdEndUsers))
            {
                body["SourceAdEndUsers"] = request.SourceAdEndUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndUserIds))
            {
                body["SourceEndUserIds"] = request.SourceEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetAdEndUsers))
            {
                body["TargetAdEndUsers"] = request.TargetAdEndUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEndUserIds))
            {
                body["TargetEndUserIds"] = request.TargetEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceBindedEndUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceBindedEndUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量更新设备绑定的终端用户
         *
         * @param request UpdateDeviceBindedEndUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDeviceBindedEndUserResponse
         */
        public async Task<UpdateDeviceBindedEndUserResponse> UpdateDeviceBindedEndUserWithOptionsAsync(UpdateDeviceBindedEndUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SerialNo))
            {
                body["SerialNo"] = request.SerialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceAdEndUsers))
            {
                body["SourceAdEndUsers"] = request.SourceAdEndUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceEndUserIds))
            {
                body["SourceEndUserIds"] = request.SourceEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetAdEndUsers))
            {
                body["TargetAdEndUsers"] = request.TargetAdEndUsers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetEndUserIds))
            {
                body["TargetEndUserIds"] = request.TargetEndUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                body["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeviceBindedEndUser",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeviceBindedEndUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量更新设备绑定的终端用户
         *
         * @param request UpdateDeviceBindedEndUserRequest
         * @return UpdateDeviceBindedEndUserResponse
         */
        public UpdateDeviceBindedEndUserResponse UpdateDeviceBindedEndUser(UpdateDeviceBindedEndUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceBindedEndUserWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新设备绑定的终端用户
         *
         * @param request UpdateDeviceBindedEndUserRequest
         * @return UpdateDeviceBindedEndUserResponse
         */
        public async Task<UpdateDeviceBindedEndUserResponse> UpdateDeviceBindedEndUserAsync(UpdateDeviceBindedEndUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceBindedEndUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改标签
         *
         * @param request UpdateLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLabelResponse
         */
        public UpdateLabelResponse UpdateLabelWithOptions(UpdateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLabelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改标签
         *
         * @param request UpdateLabelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLabelResponse
         */
        public async Task<UpdateLabelResponse> UpdateLabelWithOptionsAsync(UpdateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelContent))
            {
                body["LabelContent"] = request.LabelContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                body["LabelId"] = request.LabelId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLabel",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改标签
         *
         * @param request UpdateLabelRequest
         * @return UpdateLabelResponse
         */
        public UpdateLabelResponse UpdateLabel(UpdateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLabelWithOptions(request, runtime);
        }

        /**
         * @summary 修改标签
         *
         * @param request UpdateLabelRequest
         * @return UpdateLabelResponse
         */
        public async Task<UpdateLabelResponse> UpdateLabelAsync(UpdateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLabelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改终端策略
         *
         * @param request UpdateTerminalPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTerminalPolicyResponse
         */
        public UpdateTerminalPolicyResponse UpdateTerminalPolicyWithOptions(UpdateTerminalPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundModeTitle))
            {
                body["BackgroundModeTitle"] = request.BackgroundModeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayLayout))
            {
                body["DisplayLayout"] = request.DisplayLayout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayResolution))
            {
                body["DisplayResolution"] = request.DisplayResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayScaleRatio))
            {
                body["DisplayScaleRatio"] = request.DisplayScaleRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLockScreen))
            {
                body["EnableAutoLockScreen"] = request.EnableAutoLockScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLogin))
            {
                body["EnableAutoLogin"] = request.EnableAutoLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackgroundMode))
            {
                body["EnableBackgroundMode"] = request.EnableBackgroundMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBluetooth))
            {
                body["EnableBluetooth"] = request.EnableBluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableModifyPassword))
            {
                body["EnableModifyPassword"] = request.EnableModifyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScheduledReboot))
            {
                body["EnableScheduledReboot"] = request.EnableScheduledReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScheduledShutdown))
            {
                body["EnableScheduledShutdown"] = request.EnableScheduledShutdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSwitchPersonal))
            {
                body["EnableSwitchPersonal"] = request.EnableSwitchPersonal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWlan))
            {
                body["EnableWlan"] = request.EnableWlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                body["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeoutAction))
            {
                body["IdleTimeoutAction"] = request.IdleTimeoutAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefine))
            {
                body["PowerButtonDefine"] = request.PowerButtonDefine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefineForAs))
            {
                body["PowerButtonDefineForAs"] = request.PowerButtonDefineForAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefineForNs))
            {
                body["PowerButtonDefineForNs"] = request.PowerButtonDefineForNs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerOnBehavior))
            {
                body["PowerOnBehavior"] = request.PowerOnBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledReboot))
            {
                body["ScheduledReboot"] = request.ScheduledReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledShutdown))
            {
                body["ScheduledShutdown"] = request.ScheduledShutdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingLock))
            {
                body["SettingLock"] = request.SettingLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalPolicyId))
            {
                body["TerminalPolicyId"] = request.TerminalPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTerminalPolicy",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTerminalPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改终端策略
         *
         * @param request UpdateTerminalPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTerminalPolicyResponse
         */
        public async Task<UpdateTerminalPolicyResponse> UpdateTerminalPolicyWithOptionsAsync(UpdateTerminalPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackgroundModeTitle))
            {
                body["BackgroundModeTitle"] = request.BackgroundModeTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayLayout))
            {
                body["DisplayLayout"] = request.DisplayLayout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayResolution))
            {
                body["DisplayResolution"] = request.DisplayResolution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayScaleRatio))
            {
                body["DisplayScaleRatio"] = request.DisplayScaleRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLockScreen))
            {
                body["EnableAutoLockScreen"] = request.EnableAutoLockScreen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLogin))
            {
                body["EnableAutoLogin"] = request.EnableAutoLogin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBackgroundMode))
            {
                body["EnableBackgroundMode"] = request.EnableBackgroundMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableBluetooth))
            {
                body["EnableBluetooth"] = request.EnableBluetooth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableModifyPassword))
            {
                body["EnableModifyPassword"] = request.EnableModifyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScheduledReboot))
            {
                body["EnableScheduledReboot"] = request.EnableScheduledReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScheduledShutdown))
            {
                body["EnableScheduledShutdown"] = request.EnableScheduledShutdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSwitchPersonal))
            {
                body["EnableSwitchPersonal"] = request.EnableSwitchPersonal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableWlan))
            {
                body["EnableWlan"] = request.EnableWlan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                body["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeoutAction))
            {
                body["IdleTimeoutAction"] = request.IdleTimeoutAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefine))
            {
                body["PowerButtonDefine"] = request.PowerButtonDefine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefineForAs))
            {
                body["PowerButtonDefineForAs"] = request.PowerButtonDefineForAs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerButtonDefineForNs))
            {
                body["PowerButtonDefineForNs"] = request.PowerButtonDefineForNs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerOnBehavior))
            {
                body["PowerOnBehavior"] = request.PowerOnBehavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledReboot))
            {
                body["ScheduledReboot"] = request.ScheduledReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledShutdown))
            {
                body["ScheduledShutdown"] = request.ScheduledShutdown;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettingLock))
            {
                body["SettingLock"] = request.SettingLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminalPolicyId))
            {
                body["TerminalPolicyId"] = request.TerminalPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTerminalPolicy",
                Version = "2021-04-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTerminalPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改终端策略
         *
         * @param request UpdateTerminalPolicyRequest
         * @return UpdateTerminalPolicyResponse
         */
        public UpdateTerminalPolicyResponse UpdateTerminalPolicy(UpdateTerminalPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTerminalPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 修改终端策略
         *
         * @param request UpdateTerminalPolicyRequest
         * @return UpdateTerminalPolicyResponse
         */
        public async Task<UpdateTerminalPolicyResponse> UpdateTerminalPolicyAsync(UpdateTerminalPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTerminalPolicyWithOptionsAsync(request, runtime);
        }

    }
}
