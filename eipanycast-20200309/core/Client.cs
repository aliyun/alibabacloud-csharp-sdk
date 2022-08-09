// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eipanycast20200309.Models;

namespace AlibabaCloud.SDK.Eipanycast20200309
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eipanycast", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AllocateAnycastEipAddressResponse AllocateAnycastEipAddressWithOptions(AllocateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AllocateAnycastEipAddressResponse> AllocateAnycastEipAddressWithOptionsAsync(AllocateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AllocateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AllocateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AllocateAnycastEipAddressResponse AllocateAnycastEipAddress(AllocateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateAnycastEipAddressWithOptions(request, runtime);
        }

        public async Task<AllocateAnycastEipAddressResponse> AllocateAnycastEipAddressAsync(AllocateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        public AssociateAnycastEipAddressResponse AssociateAnycastEipAddressWithOptions(AssociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocations))
            {
                query["PopLocations"] = request.PopLocations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateAnycastEipAddressResponse> AssociateAnycastEipAddressWithOptionsAsync(AssociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocations))
            {
                query["PopLocations"] = request.PopLocations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateAnycastEipAddressResponse AssociateAnycastEipAddress(AssociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAnycastEipAddressWithOptions(request, runtime);
        }

        public async Task<AssociateAnycastEipAddressResponse> AssociateAnycastEipAddressAsync(AssociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        public DescribeAnycastEipAddressResponse DescribeAnycastEipAddressWithOptions(DescribeAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAnycastEipAddressResponse> DescribeAnycastEipAddressWithOptionsAsync(DescribeAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAnycastEipAddressResponse DescribeAnycastEipAddress(DescribeAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastEipAddressWithOptions(request, runtime);
        }

        public async Task<DescribeAnycastEipAddressResponse> DescribeAnycastEipAddressAsync(DescribeAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        public DescribeAnycastPopLocationsResponse DescribeAnycastPopLocationsWithOptions(DescribeAnycastPopLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastPopLocations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastPopLocationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAnycastPopLocationsResponse> DescribeAnycastPopLocationsWithOptionsAsync(DescribeAnycastPopLocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastPopLocations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastPopLocationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAnycastPopLocationsResponse DescribeAnycastPopLocations(DescribeAnycastPopLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastPopLocationsWithOptions(request, runtime);
        }

        public async Task<DescribeAnycastPopLocationsResponse> DescribeAnycastPopLocationsAsync(DescribeAnycastPopLocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastPopLocationsWithOptionsAsync(request, runtime);
        }

        public DescribeAnycastServerRegionsResponse DescribeAnycastServerRegionsWithOptions(DescribeAnycastServerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastServerRegions",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastServerRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAnycastServerRegionsResponse> DescribeAnycastServerRegionsWithOptionsAsync(DescribeAnycastServerRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAnycastServerRegions",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAnycastServerRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAnycastServerRegionsResponse DescribeAnycastServerRegions(DescribeAnycastServerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAnycastServerRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeAnycastServerRegionsResponse> DescribeAnycastServerRegionsAsync(DescribeAnycastServerRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAnycastServerRegionsWithOptionsAsync(request, runtime);
        }

        public ListAnycastEipAddressesResponse ListAnycastEipAddressesWithOptions(ListAnycastEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastEipAddress))
            {
                query["AnycastEipAddress"] = request.AnycastEipAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastIds))
            {
                query["AnycastIds"] = request.AnycastIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceIds))
            {
                query["BindInstanceIds"] = request.BindInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnycastEipAddresses",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnycastEipAddressesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAnycastEipAddressesResponse> ListAnycastEipAddressesWithOptionsAsync(ListAnycastEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastEipAddress))
            {
                query["AnycastEipAddress"] = request.AnycastEipAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastIds))
            {
                query["AnycastIds"] = request.AnycastIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceIds))
            {
                query["BindInstanceIds"] = request.BindInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessStatus))
            {
                query["BusinessStatus"] = request.BusinessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceChargeType))
            {
                query["InstanceChargeType"] = request.InstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetChargeType))
            {
                query["InternetChargeType"] = request.InternetChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceLocation))
            {
                query["ServiceLocation"] = request.ServiceLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnycastEipAddresses",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnycastEipAddressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAnycastEipAddressesResponse ListAnycastEipAddresses(ListAnycastEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnycastEipAddressesWithOptions(request, runtime);
        }

        public async Task<ListAnycastEipAddressesResponse> ListAnycastEipAddressesAsync(ListAnycastEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnycastEipAddressesWithOptionsAsync(request, runtime);
        }

        public ModifyAnycastEipAddressAttributeResponse ModifyAnycastEipAddressAttributeWithOptions(ModifyAnycastEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
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
                Action = "ModifyAnycastEipAddressAttribute",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAnycastEipAddressAttributeResponse> ModifyAnycastEipAddressAttributeWithOptionsAsync(ModifyAnycastEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
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
                Action = "ModifyAnycastEipAddressAttribute",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAnycastEipAddressAttributeResponse ModifyAnycastEipAddressAttribute(ModifyAnycastEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAnycastEipAddressAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyAnycastEipAddressAttributeResponse> ModifyAnycastEipAddressAttributeAsync(ModifyAnycastEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAnycastEipAddressAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyAnycastEipAddressSpecResponse ModifyAnycastEipAddressSpecWithOptions(ModifyAnycastEipAddressSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressSpec",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressSpecResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAnycastEipAddressSpecResponse> ModifyAnycastEipAddressSpecWithOptionsAsync(ModifyAnycastEipAddressSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAnycastEipAddressSpec",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAnycastEipAddressSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAnycastEipAddressSpecResponse ModifyAnycastEipAddressSpec(ModifyAnycastEipAddressSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAnycastEipAddressSpecWithOptions(request, runtime);
        }

        public async Task<ModifyAnycastEipAddressSpecResponse> ModifyAnycastEipAddressSpecAsync(ModifyAnycastEipAddressSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAnycastEipAddressSpecWithOptionsAsync(request, runtime);
        }

        public ReleaseAnycastEipAddressResponse ReleaseAnycastEipAddressWithOptions(ReleaseAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReleaseAnycastEipAddressResponse> ReleaseAnycastEipAddressWithOptionsAsync(ReleaseAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReleaseAnycastEipAddressResponse ReleaseAnycastEipAddress(ReleaseAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseAnycastEipAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseAnycastEipAddressResponse> ReleaseAnycastEipAddressAsync(ReleaseAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        public UnassociateAnycastEipAddressResponse UnassociateAnycastEipAddressWithOptions(UnassociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateAnycastEipAddressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnassociateAnycastEipAddressResponse> UnassociateAnycastEipAddressWithOptionsAsync(UnassociateAnycastEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceRegionId))
            {
                query["BindInstanceRegionId"] = request.BindInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceType))
            {
                query["BindInstanceType"] = request.BindInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateAnycastEipAddress",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateAnycastEipAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnassociateAnycastEipAddressResponse UnassociateAnycastEipAddress(UnassociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateAnycastEipAddressWithOptions(request, runtime);
        }

        public async Task<UnassociateAnycastEipAddressResponse> UnassociateAnycastEipAddressAsync(UnassociateAnycastEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateAnycastEipAddressWithOptionsAsync(request, runtime);
        }

        public UpdateAnycastEipAddressAssociationsResponse UpdateAnycastEipAddressAssociationsWithOptions(UpdateAnycastEipAddressAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationAddList))
            {
                query["PopLocationAddList"] = request.PopLocationAddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationDeleteList))
            {
                query["PopLocationDeleteList"] = request.PopLocationDeleteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnycastEipAddressAssociations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAnycastEipAddressAssociationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAnycastEipAddressAssociationsResponse> UpdateAnycastEipAddressAssociationsWithOptionsAsync(UpdateAnycastEipAddressAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnycastId))
            {
                query["AnycastId"] = request.AnycastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationMode))
            {
                query["AssociationMode"] = request.AssociationMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindInstanceId))
            {
                query["BindInstanceId"] = request.BindInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationAddList))
            {
                query["PopLocationAddList"] = request.PopLocationAddList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PopLocationDeleteList))
            {
                query["PopLocationDeleteList"] = request.PopLocationDeleteList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnycastEipAddressAssociations",
                Version = "2020-03-09",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAnycastEipAddressAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAnycastEipAddressAssociationsResponse UpdateAnycastEipAddressAssociations(UpdateAnycastEipAddressAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAnycastEipAddressAssociationsWithOptions(request, runtime);
        }

        public async Task<UpdateAnycastEipAddressAssociationsResponse> UpdateAnycastEipAddressAssociationsAsync(UpdateAnycastEipAddressAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAnycastEipAddressAssociationsWithOptionsAsync(request, runtime);
        }

    }
}
