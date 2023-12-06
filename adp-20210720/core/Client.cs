// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Adp20210720.Models;

namespace AlibabaCloud.SDK.Adp20210720
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("adp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddEnvironmentNodesResponse AddEnvironmentNodesWithOptions(string uid, AddEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDisk))
            {
                body["applicationDisk"] = request.ApplicationDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                body["dataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtcdDisk))
            {
                body["etcdDisk"] = request.EtcdDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["hostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPrivateIPs))
            {
                body["masterPrivateIPs"] = request.MasterPrivateIPs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                body["os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootPassword))
            {
                body["rootPassword"] = request.RootPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDisk))
            {
                body["systemDisk"] = request.SystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemDisk))
            {
                body["tridentSystemDisk"] = request.TridentSystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemSizeDisk))
            {
                body["tridentSystemSizeDisk"] = request.TridentSystemSizeDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPrivateIPs))
            {
                body["workerPrivateIPs"] = request.WorkerPrivateIPs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEnvironmentNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEnvironmentNodesResponse> AddEnvironmentNodesWithOptionsAsync(string uid, AddEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDisk))
            {
                body["applicationDisk"] = request.ApplicationDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                body["cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDisk))
            {
                body["dataDisk"] = request.DataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtcdDisk))
            {
                body["etcdDisk"] = request.EtcdDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["hostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPrivateIPs))
            {
                body["masterPrivateIPs"] = request.MasterPrivateIPs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                body["memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Os))
            {
                body["os"] = request.Os;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootPassword))
            {
                body["rootPassword"] = request.RootPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDisk))
            {
                body["systemDisk"] = request.SystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemDisk))
            {
                body["tridentSystemDisk"] = request.TridentSystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemSizeDisk))
            {
                body["tridentSystemSizeDisk"] = request.TridentSystemSizeDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPrivateIPs))
            {
                body["workerPrivateIPs"] = request.WorkerPrivateIPs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEnvironmentNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEnvironmentNodesResponse AddEnvironmentNodes(string uid, AddEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddEnvironmentNodesWithOptions(uid, request, headers, runtime);
        }

        public async Task<AddEnvironmentNodesResponse> AddEnvironmentNodesAsync(string uid, AddEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddEnvironmentNodesWithOptionsAsync(uid, request, headers, runtime);
        }

        public AddEnvironmentProductVersionsResponse AddEnvironmentProductVersionsWithOptions(string uid, AddEnvironmentProductVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionInfoList))
            {
                body["productVersionInfoList"] = request.ProductVersionInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUIDList))
            {
                body["productVersionUIDList"] = request.ProductVersionUIDList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnvironmentProductVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEnvironmentProductVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEnvironmentProductVersionsResponse> AddEnvironmentProductVersionsWithOptionsAsync(string uid, AddEnvironmentProductVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionInfoList))
            {
                body["productVersionInfoList"] = request.ProductVersionInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUIDList))
            {
                body["productVersionUIDList"] = request.ProductVersionUIDList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEnvironmentProductVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEnvironmentProductVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEnvironmentProductVersionsResponse AddEnvironmentProductVersions(string uid, AddEnvironmentProductVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddEnvironmentProductVersionsWithOptions(uid, request, headers, runtime);
        }

        public async Task<AddEnvironmentProductVersionsResponse> AddEnvironmentProductVersionsAsync(string uid, AddEnvironmentProductVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddEnvironmentProductVersionsWithOptionsAsync(uid, request, headers, runtime);
        }

        public AddProductComponentVersionResponse AddProductComponentVersionWithOptions(string uid, string componentVersionUID, AddProductComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionSpecUID))
            {
                body["componentVersionSpecUID"] = request.ComponentVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionSpecValues))
            {
                body["componentVersionSpecValues"] = request.ComponentVersionSpecValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentVersionUID),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProductComponentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddProductComponentVersionResponse> AddProductComponentVersionWithOptionsAsync(string uid, string componentVersionUID, AddProductComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionSpecUID))
            {
                body["componentVersionSpecUID"] = request.ComponentVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionSpecValues))
            {
                body["componentVersionSpecValues"] = request.ComponentVersionSpecValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentVersionUID),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProductComponentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddProductComponentVersionResponse AddProductComponentVersion(string uid, string componentVersionUID, AddProductComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddProductComponentVersionWithOptions(uid, componentVersionUID, request, headers, runtime);
        }

        public async Task<AddProductComponentVersionResponse> AddProductComponentVersionAsync(string uid, string componentVersionUID, AddProductComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddProductComponentVersionWithOptionsAsync(uid, componentVersionUID, request, headers, runtime);
        }

        public AddProductVersionConfigResponse AddProductVersionConfigWithOptions(string uid, AddProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                body["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentReleaseName))
            {
                body["parentComponentReleaseName"] = request.ParentComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProductVersionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddProductVersionConfigResponse> AddProductVersionConfigWithOptionsAsync(string uid, AddProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                body["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentReleaseName))
            {
                body["parentComponentReleaseName"] = request.ParentComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddProductVersionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddProductVersionConfigResponse AddProductVersionConfig(string uid, AddProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddProductVersionConfigWithOptions(uid, request, headers, runtime);
        }

        public async Task<AddProductVersionConfigResponse> AddProductVersionConfigAsync(string uid, AddProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddProductVersionConfigWithOptionsAsync(uid, request, headers, runtime);
        }

        public AddResourceSnapshotResponse AddResourceSnapshotWithOptions(AddResourceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddResourceSnapshot",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resource-snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResourceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddResourceSnapshotResponse> AddResourceSnapshotWithOptionsAsync(AddResourceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddResourceSnapshot",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resource-snapshots",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddResourceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddResourceSnapshotResponse AddResourceSnapshot(AddResourceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AddResourceSnapshotWithOptions(request, headers, runtime);
        }

        public async Task<AddResourceSnapshotResponse> AddResourceSnapshotAsync(AddResourceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AddResourceSnapshotWithOptionsAsync(request, headers, runtime);
        }

        public BatchAddEnvironmentNodesResponse BatchAddEnvironmentNodesWithOptions(string uid, BatchAddEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["overwrite"] = request.Overwrite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/batch/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddEnvironmentNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchAddEnvironmentNodesResponse> BatchAddEnvironmentNodesWithOptionsAsync(string uid, BatchAddEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                body["instanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overwrite))
            {
                body["overwrite"] = request.Overwrite;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/batch/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddEnvironmentNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchAddEnvironmentNodesResponse BatchAddEnvironmentNodes(string uid, BatchAddEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchAddEnvironmentNodesWithOptions(uid, request, headers, runtime);
        }

        public async Task<BatchAddEnvironmentNodesResponse> BatchAddEnvironmentNodesAsync(string uid, BatchAddEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchAddEnvironmentNodesWithOptionsAsync(uid, request, headers, runtime);
        }

        public BatchAddProductVersionConfigResponse BatchAddProductVersionConfigWithOptions(string uid, BatchAddProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionConfigList))
            {
                body["productVersionConfigList"] = request.ProductVersionConfigList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/batch/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddProductVersionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchAddProductVersionConfigResponse> BatchAddProductVersionConfigWithOptionsAsync(string uid, BatchAddProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionConfigList))
            {
                body["productVersionConfigList"] = request.ProductVersionConfigList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchAddProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/batch/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchAddProductVersionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchAddProductVersionConfigResponse BatchAddProductVersionConfig(string uid, BatchAddProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchAddProductVersionConfigWithOptions(uid, request, headers, runtime);
        }

        public async Task<BatchAddProductVersionConfigResponse> BatchAddProductVersionConfigAsync(string uid, BatchAddProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchAddProductVersionConfigWithOptionsAsync(uid, request, headers, runtime);
        }

        public CreateDeliverableResponse CreateDeliverableWithOptions(CreateDeliverableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliverableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDeliverableResponse> CreateDeliverableWithOptionsAsync(CreateDeliverableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliverableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDeliverableResponse CreateDeliverable(CreateDeliverableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDeliverableWithOptions(request, headers, runtime);
        }

        public async Task<CreateDeliverableResponse> CreateDeliverableAsync(CreateDeliverableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDeliverableWithOptionsAsync(request, headers, runtime);
        }

        public CreateDeliveryInstanceResponse CreateDeliveryInstanceWithOptions(CreateDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                body["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableConfigUID))
            {
                body["deliverableConfigUID"] = request.DeliverableConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                body["envUID"] = request.EnvUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateUID))
            {
                body["templateUID"] = request.TemplateUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDeliveryInstanceResponse> CreateDeliveryInstanceWithOptionsAsync(CreateDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                body["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableConfigUID))
            {
                body["deliverableConfigUID"] = request.DeliverableConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                body["envUID"] = request.EnvUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateUID))
            {
                body["templateUID"] = request.TemplateUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDeliveryInstanceResponse CreateDeliveryInstance(CreateDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDeliveryInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateDeliveryInstanceResponse> CreateDeliveryInstanceAsync(CreateDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDeliveryInstanceWithOptionsAsync(request, headers, runtime);
        }

        public CreateDeliveryPackageResponse CreateDeliveryPackageWithOptions(CreateDeliveryPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInstanceUID))
            {
                body["deliveryInstanceUID"] = request.DeliveryInstanceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginDeliverableUID))
            {
                body["originDeliverableUID"] = request.OriginDeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                body["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDeliveryPackageResponse> CreateDeliveryPackageWithOptionsAsync(CreateDeliveryPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryInstanceUID))
            {
                body["deliveryInstanceUID"] = request.DeliveryInstanceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginDeliverableUID))
            {
                body["originDeliverableUID"] = request.OriginDeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                body["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                body["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDeliveryPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDeliveryPackageResponse CreateDeliveryPackage(CreateDeliveryPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDeliveryPackageWithOptions(request, headers, runtime);
        }

        public async Task<CreateDeliveryPackageResponse> CreateDeliveryPackageAsync(CreateDeliveryPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDeliveryPackageWithOptionsAsync(request, headers, runtime);
        }

        public CreateEnvironmentResponse CreateEnvironmentWithOptions(CreateEnvironmentRequest request, CreateEnvironmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredAt))
            {
                body["expiredAt"] = request.ExpiredAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformList))
            {
                body["platformList"] = request.PlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorConfig))
            {
                body["vendorConfig"] = request.VendorConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                body["vendorType"] = request.VendorType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEnvironmentResponse> CreateEnvironmentWithOptionsAsync(CreateEnvironmentRequest request, CreateEnvironmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpiredAt))
            {
                body["expiredAt"] = request.ExpiredAt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformList))
            {
                body["platformList"] = request.PlatformList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorConfig))
            {
                body["vendorConfig"] = request.VendorConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                body["vendorType"] = request.VendorType;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEnvironmentHeaders headers = new CreateEnvironmentHeaders();
            return CreateEnvironmentWithOptions(request, headers, runtime);
        }

        public async Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateEnvironmentHeaders headers = new CreateEnvironmentHeaders();
            return await CreateEnvironmentWithOptionsAsync(request, headers, runtime);
        }

        public CreateEnvironmentLicenseResponse CreateEnvironmentLicenseWithOptions(string uid, CreateEnvironmentLicenseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                body["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseQuota))
            {
                body["licenseQuota"] = request.LicenseQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineFingerprint))
            {
                body["machineFingerprint"] = request.MachineFingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEnvironmentLicenseResponse> CreateEnvironmentLicenseWithOptionsAsync(string uid, CreateEnvironmentLicenseRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyName))
            {
                body["companyName"] = request.CompanyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contact))
            {
                body["contact"] = request.Contact;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireTime))
            {
                body["expireTime"] = request.ExpireTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseQuota))
            {
                body["licenseQuota"] = request.LicenseQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineFingerprint))
            {
                body["machineFingerprint"] = request.MachineFingerprint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scenario))
            {
                body["scenario"] = request.Scenario;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEnvironmentLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEnvironmentLicenseResponse CreateEnvironmentLicense(string uid, CreateEnvironmentLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEnvironmentLicenseWithOptions(uid, request, headers, runtime);
        }

        public async Task<CreateEnvironmentLicenseResponse> CreateEnvironmentLicenseAsync(string uid, CreateEnvironmentLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEnvironmentLicenseWithOptionsAsync(uid, request, headers, runtime);
        }

        public CreateFoundationReferenceResponse CreateFoundationReferenceWithOptions(CreateFoundationReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfig))
            {
                body["clusterConfig"] = request.ClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentConfigs))
            {
                body["componentConfigs"] = request.ComponentConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceConfigs))
            {
                body["foundationReferenceConfigs"] = request.FoundationReferenceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginFoundationReferenceUID))
            {
                body["originFoundationReferenceUID"] = request.OriginFoundationReferenceUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFoundationReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFoundationReferenceResponse> CreateFoundationReferenceWithOptionsAsync(CreateFoundationReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfig))
            {
                body["clusterConfig"] = request.ClusterConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentConfigs))
            {
                body["componentConfigs"] = request.ComponentConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceConfigs))
            {
                body["foundationReferenceConfigs"] = request.FoundationReferenceConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginFoundationReferenceUID))
            {
                body["originFoundationReferenceUID"] = request.OriginFoundationReferenceUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFoundationReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFoundationReferenceResponse CreateFoundationReference(CreateFoundationReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateFoundationReferenceWithOptions(request, headers, runtime);
        }

        public async Task<CreateFoundationReferenceResponse> CreateFoundationReferenceAsync(CreateFoundationReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateFoundationReferenceWithOptionsAsync(request, headers, runtime);
        }

        public CreateProductResponse CreateProductWithOptions(CreateProductRequest request, CreateProductHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                body["categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["vendor"] = request.Vendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutProductVersion))
            {
                body["withoutProductVersion"] = request.WithoutProductVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProductResponse> CreateProductWithOptionsAsync(CreateProductRequest request, CreateProductHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                body["categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["vendor"] = request.Vendor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutProductVersion))
            {
                body["withoutProductVersion"] = request.WithoutProductVersion;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProductHeaders headers = new CreateProductHeaders();
            return CreateProductWithOptions(request, headers, runtime);
        }

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProductHeaders headers = new CreateProductHeaders();
            return await CreateProductWithOptionsAsync(request, headers, runtime);
        }

        public CreateProductDeploymentResponse CreateProductDeploymentWithOptions(CreateProductDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                body["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageConfig))
            {
                body["packageConfig"] = request.PackageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                body["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductDeployment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductDeploymentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProductDeploymentResponse> CreateProductDeploymentWithOptionsAsync(CreateProductDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                body["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageConfig))
            {
                body["packageConfig"] = request.PackageConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                body["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductDeployment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProductDeploymentResponse CreateProductDeployment(CreateProductDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProductDeploymentWithOptions(request, headers, runtime);
        }

        public async Task<CreateProductDeploymentResponse> CreateProductDeploymentAsync(CreateProductDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProductDeploymentWithOptionsAsync(request, headers, runtime);
        }

        public CreateProductVersionResponse CreateProductVersionWithOptions(string uid, CreateProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseProductVersionUID))
            {
                query["baseProductVersionUID"] = request.BaseProductVersionUID;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutBaseProductVersion))
            {
                body["withoutBaseProductVersion"] = request.WithoutBaseProductVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateProductVersionResponse> CreateProductVersionWithOptionsAsync(string uid, CreateProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseProductVersionUID))
            {
                query["baseProductVersionUID"] = request.BaseProductVersionUID;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutBaseProductVersion))
            {
                body["withoutBaseProductVersion"] = request.WithoutBaseProductVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateProductVersionResponse CreateProductVersion(string uid, CreateProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProductVersionWithOptions(uid, request, headers, runtime);
        }

        public async Task<CreateProductVersionResponse> CreateProductVersionAsync(string uid, CreateProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProductVersionWithOptionsAsync(uid, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request CreateProductVersionPackageRequest
          * @param headers CreateProductVersionPackageHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateProductVersionPackageResponse
         */
        // Deprecated
        public CreateProductVersionPackageResponse CreateProductVersionPackageWithOptions(string uid, CreateProductVersionPackageRequest request, CreateProductVersionPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterEngineType))
            {
                query["clusterEngineType"] = request.ClusterEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldFoundationReferenceUID))
            {
                query["oldFoundationReferenceUID"] = request.OldFoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                query["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                query["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageToolType))
            {
                query["packageToolType"] = request.PackageToolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductVersionPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductVersionPackageResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request CreateProductVersionPackageRequest
          * @param headers CreateProductVersionPackageHeaders
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateProductVersionPackageResponse
         */
        // Deprecated
        public async Task<CreateProductVersionPackageResponse> CreateProductVersionPackageWithOptionsAsync(string uid, CreateProductVersionPackageRequest request, CreateProductVersionPackageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterEngineType))
            {
                query["clusterEngineType"] = request.ClusterEngineType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldFoundationReferenceUID))
            {
                query["oldFoundationReferenceUID"] = request.OldFoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                query["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                query["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageToolType))
            {
                query["packageToolType"] = request.PackageToolType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ClientToken))
            {
                realHeaders["ClientToken"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ClientToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProductVersionPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProductVersionPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request CreateProductVersionPackageRequest
          * @return CreateProductVersionPackageResponse
         */
        // Deprecated
        public CreateProductVersionPackageResponse CreateProductVersionPackage(string uid, CreateProductVersionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProductVersionPackageHeaders headers = new CreateProductVersionPackageHeaders();
            return CreateProductVersionPackageWithOptions(uid, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request CreateProductVersionPackageRequest
          * @return CreateProductVersionPackageResponse
         */
        // Deprecated
        public async Task<CreateProductVersionPackageResponse> CreateProductVersionPackageAsync(string uid, CreateProductVersionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProductVersionPackageHeaders headers = new CreateProductVersionPackageHeaders();
            return await CreateProductVersionPackageWithOptionsAsync(uid, request, headers, runtime);
        }

        public DeleteEnvironmentResponse DeleteEnvironmentWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEnvironmentResponse DeleteEnvironment(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentWithOptions(uid, headers, runtime);
        }

        public async Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentWithOptionsAsync(uid, headers, runtime);
        }

        public DeleteEnvironmentLicenseResponse DeleteEnvironmentLicenseWithOptions(string uid, string licenseUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(licenseUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEnvironmentLicenseResponse> DeleteEnvironmentLicenseWithOptionsAsync(string uid, string licenseUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(licenseUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEnvironmentLicenseResponse DeleteEnvironmentLicense(string uid, string licenseUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentLicenseWithOptions(uid, licenseUID, headers, runtime);
        }

        public async Task<DeleteEnvironmentLicenseResponse> DeleteEnvironmentLicenseAsync(string uid, string licenseUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentLicenseWithOptionsAsync(uid, licenseUID, headers, runtime);
        }

        public DeleteEnvironmentNodeResponse DeleteEnvironmentNodeWithOptions(string uid, string nodeUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentNodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEnvironmentNodeResponse> DeleteEnvironmentNodeWithOptionsAsync(string uid, string nodeUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEnvironmentNodeResponse DeleteEnvironmentNode(string uid, string nodeUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentNodeWithOptions(uid, nodeUID, headers, runtime);
        }

        public async Task<DeleteEnvironmentNodeResponse> DeleteEnvironmentNodeAsync(string uid, string nodeUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentNodeWithOptionsAsync(uid, nodeUID, headers, runtime);
        }

        public DeleteEnvironmentProductVersionResponse DeleteEnvironmentProductVersionWithOptions(string uid, string productVersionUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productVersionUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEnvironmentProductVersionResponse> DeleteEnvironmentProductVersionWithOptionsAsync(string uid, string productVersionUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEnvironmentProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(productVersionUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEnvironmentProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEnvironmentProductVersionResponse DeleteEnvironmentProductVersion(string uid, string productVersionUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEnvironmentProductVersionWithOptions(uid, productVersionUID, headers, runtime);
        }

        public async Task<DeleteEnvironmentProductVersionResponse> DeleteEnvironmentProductVersionAsync(string uid, string productVersionUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEnvironmentProductVersionWithOptionsAsync(uid, productVersionUID, headers, runtime);
        }

        public DeleteProductResponse DeleteProductWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProductResponse DeleteProduct(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductWithOptions(uid, headers, runtime);
        }

        public async Task<DeleteProductResponse> DeleteProductAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductWithOptionsAsync(uid, headers, runtime);
        }

        public DeleteProductComponentVersionResponse DeleteProductComponentVersionWithOptions(string uid, string relationUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductComponentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProductComponentVersionResponse> DeleteProductComponentVersionWithOptionsAsync(string uid, string relationUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductComponentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProductComponentVersionResponse DeleteProductComponentVersion(string uid, string relationUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductComponentVersionWithOptions(uid, relationUID, headers, runtime);
        }

        public async Task<DeleteProductComponentVersionResponse> DeleteProductComponentVersionAsync(string uid, string relationUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductComponentVersionWithOptionsAsync(uid, relationUID, headers, runtime);
        }

        public DeleteProductInstanceConfigResponse DeleteProductInstanceConfigWithOptions(string configUID, DeleteProductInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductInstanceConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProductInstanceConfigResponse> DeleteProductInstanceConfigWithOptionsAsync(string configUID, DeleteProductInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductInstanceConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProductInstanceConfigResponse DeleteProductInstanceConfig(string configUID, DeleteProductInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductInstanceConfigWithOptions(configUID, request, headers, runtime);
        }

        public async Task<DeleteProductInstanceConfigResponse> DeleteProductInstanceConfigAsync(string configUID, DeleteProductInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductInstanceConfigWithOptionsAsync(configUID, request, headers, runtime);
        }

        public DeleteProductVersionResponse DeleteProductVersionWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProductVersionResponse> DeleteProductVersionWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProductVersionResponse DeleteProductVersion(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductVersionWithOptions(uid, headers, runtime);
        }

        public async Task<DeleteProductVersionResponse> DeleteProductVersionAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductVersionWithOptionsAsync(uid, headers, runtime);
        }

        public DeleteProductVersionConfigResponse DeleteProductVersionConfigWithOptions(string uid, string configUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductVersionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteProductVersionConfigResponse> DeleteProductVersionConfigWithOptionsAsync(string uid, string configUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProductVersionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteProductVersionConfigResponse DeleteProductVersionConfig(string uid, string configUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProductVersionConfigWithOptions(uid, configUID, headers, runtime);
        }

        public async Task<DeleteProductVersionConfigResponse> DeleteProductVersionConfigAsync(string uid, string configUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProductVersionConfigWithOptionsAsync(uid, configUID, headers, runtime);
        }

        public GenerateProductInstanceDeploymentConfigResponse GenerateProductInstanceDeploymentConfigWithOptions(GenerateProductInstanceDeploymentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                body["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                body["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUIDList))
            {
                body["productVersionUIDList"] = request.ProductVersionUIDList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProductInstanceDeploymentConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/package-configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProductInstanceDeploymentConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateProductInstanceDeploymentConfigResponse> GenerateProductInstanceDeploymentConfigWithOptionsAsync(GenerateProductInstanceDeploymentConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                body["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                body["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUIDList))
            {
                body["productVersionUIDList"] = request.ProductVersionUIDList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateProductInstanceDeploymentConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/package-configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateProductInstanceDeploymentConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateProductInstanceDeploymentConfigResponse GenerateProductInstanceDeploymentConfig(GenerateProductInstanceDeploymentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GenerateProductInstanceDeploymentConfigWithOptions(request, headers, runtime);
        }

        public async Task<GenerateProductInstanceDeploymentConfigResponse> GenerateProductInstanceDeploymentConfigAsync(GenerateProductInstanceDeploymentConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GenerateProductInstanceDeploymentConfigWithOptionsAsync(request, headers, runtime);
        }

        public GetComponentResponse GetComponentWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComponent",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComponentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetComponentResponse> GetComponentWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComponent",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComponentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetComponentResponse GetComponent(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComponentWithOptions(uid, headers, runtime);
        }

        public async Task<GetComponentResponse> GetComponentAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComponentWithOptionsAsync(uid, headers, runtime);
        }

        public GetComponentVersionResponse GetComponentVersionWithOptions(string uid, string versionUID, GetComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutChartContent))
            {
                query["withoutChartContent"] = request.WithoutChartContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComponentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetComponentVersionResponse> GetComponentVersionWithOptionsAsync(string uid, string versionUID, GetComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithoutChartContent))
            {
                query["withoutChartContent"] = request.WithoutChartContent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComponentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetComponentVersionResponse GetComponentVersion(string uid, string versionUID, GetComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComponentVersionWithOptions(uid, versionUID, request, headers, runtime);
        }

        public async Task<GetComponentVersionResponse> GetComponentVersionAsync(string uid, string versionUID, GetComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComponentVersionWithOptionsAsync(uid, versionUID, request, headers, runtime);
        }

        public GetDeliverableResponse GetDeliverableWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliverableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeliverableResponse> GetDeliverableWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliverableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeliverableResponse GetDeliverable(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeliverableWithOptions(uid, headers, runtime);
        }

        public async Task<GetDeliverableResponse> GetDeliverableAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeliverableWithOptionsAsync(uid, headers, runtime);
        }

        public GetDeliveryPackageResponse GetDeliveryPackageWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDeliveryPackageResponse> GetDeliveryPackageWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDeliveryPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDeliveryPackageResponse GetDeliveryPackage(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDeliveryPackageWithOptions(uid, headers, runtime);
        }

        public async Task<GetDeliveryPackageResponse> GetDeliveryPackageAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDeliveryPackageWithOptionsAsync(uid, headers, runtime);
        }

        public GetEnvironmentResponse GetEnvironmentWithOptions(string uid, GetEnvironmentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetEnvironmentShrinkRequest request = new GetEnvironmentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEnvironmentResponse> GetEnvironmentWithOptionsAsync(string uid, GetEnvironmentRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetEnvironmentShrinkRequest request = new GetEnvironmentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEnvironmentResponse GetEnvironment(string uid, GetEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentWithOptions(uid, request, headers, runtime);
        }

        public async Task<GetEnvironmentResponse> GetEnvironmentAsync(string uid, GetEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentWithOptionsAsync(uid, request, headers, runtime);
        }

        public GetEnvironmentDeliveryInstanceResponse GetEnvironmentDeliveryInstanceWithOptions(GetEnvironmentDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                query["envUID"] = request.EnvUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentDeliveryInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEnvironmentDeliveryInstanceResponse> GetEnvironmentDeliveryInstanceWithOptionsAsync(GetEnvironmentDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                query["envUID"] = request.EnvUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentDeliveryInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEnvironmentDeliveryInstanceResponse GetEnvironmentDeliveryInstance(GetEnvironmentDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentDeliveryInstanceWithOptions(request, headers, runtime);
        }

        public async Task<GetEnvironmentDeliveryInstanceResponse> GetEnvironmentDeliveryInstanceAsync(GetEnvironmentDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentDeliveryInstanceWithOptionsAsync(request, headers, runtime);
        }

        public GetEnvironmentLicenseResponse GetEnvironmentLicenseWithOptions(string uid, string licenseUID, GetEnvironmentLicenseRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetEnvironmentLicenseShrinkRequest request = new GetEnvironmentLicenseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(licenseUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEnvironmentLicenseResponse> GetEnvironmentLicenseWithOptionsAsync(string uid, string licenseUID, GetEnvironmentLicenseRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetEnvironmentLicenseShrinkRequest request = new GetEnvironmentLicenseShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentLicense",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(licenseUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEnvironmentLicenseResponse GetEnvironmentLicense(string uid, string licenseUID, GetEnvironmentLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentLicenseWithOptions(uid, licenseUID, request, headers, runtime);
        }

        public async Task<GetEnvironmentLicenseResponse> GetEnvironmentLicenseAsync(string uid, string licenseUID, GetEnvironmentLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentLicenseWithOptionsAsync(uid, licenseUID, request, headers, runtime);
        }

        public GetEnvironmentNodeResponse GetEnvironmentNodeWithOptions(string uid, string nodeUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentNodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetEnvironmentNodeResponse> GetEnvironmentNodeWithOptionsAsync(string uid, string nodeUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEnvironmentNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetEnvironmentNodeResponse GetEnvironmentNode(string uid, string nodeUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEnvironmentNodeWithOptions(uid, nodeUID, headers, runtime);
        }

        public async Task<GetEnvironmentNodeResponse> GetEnvironmentNodeAsync(string uid, string nodeUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEnvironmentNodeWithOptionsAsync(uid, nodeUID, headers, runtime);
        }

        public GetFoundationComponentReferenceResponse GetFoundationComponentReferenceWithOptions(string componentReferenceUID, string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationComponentReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentReferenceUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationComponentReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFoundationComponentReferenceResponse> GetFoundationComponentReferenceWithOptionsAsync(string componentReferenceUID, string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationComponentReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentReferenceUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationComponentReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFoundationComponentReferenceResponse GetFoundationComponentReference(string componentReferenceUID, string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFoundationComponentReferenceWithOptions(componentReferenceUID, uid, headers, runtime);
        }

        public async Task<GetFoundationComponentReferenceResponse> GetFoundationComponentReferenceAsync(string componentReferenceUID, string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFoundationComponentReferenceWithOptionsAsync(componentReferenceUID, uid, headers, runtime);
        }

        public GetFoundationReferenceResponse GetFoundationReferenceWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFoundationReferenceResponse> GetFoundationReferenceWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFoundationReferenceResponse GetFoundationReference(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFoundationReferenceWithOptions(uid, headers, runtime);
        }

        public async Task<GetFoundationReferenceResponse> GetFoundationReferenceAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFoundationReferenceWithOptionsAsync(uid, headers, runtime);
        }

        public GetFoundationVersionResponse GetFoundationVersionWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetFoundationVersionResponse> GetFoundationVersionWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetFoundationVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFoundationVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetFoundationVersionResponse GetFoundationVersion(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetFoundationVersionWithOptions(uid, headers, runtime);
        }

        public async Task<GetFoundationVersionResponse> GetFoundationVersionAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetFoundationVersionWithOptionsAsync(uid, headers, runtime);
        }

        public GetProductResponse GetProductWithOptions(string uid, GetProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIconURL))
            {
                query["withIconURL"] = request.WithIconURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductResponse> GetProductWithOptionsAsync(string uid, GetProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithIconURL))
            {
                query["withIconURL"] = request.WithIconURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductResponse GetProduct(string uid, GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductWithOptions(uid, request, headers, runtime);
        }

        public async Task<GetProductResponse> GetProductAsync(string uid, GetProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductWithOptionsAsync(uid, request, headers, runtime);
        }

        public GetProductComponentVersionResponse GetProductComponentVersionWithOptions(string relationUID, string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductComponentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductComponentVersionResponse> GetProductComponentVersionWithOptionsAsync(string relationUID, string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductComponentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductComponentVersionResponse GetProductComponentVersion(string relationUID, string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductComponentVersionWithOptions(relationUID, uid, headers, runtime);
        }

        public async Task<GetProductComponentVersionResponse> GetProductComponentVersionAsync(string relationUID, string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductComponentVersionWithOptionsAsync(relationUID, uid, headers, runtime);
        }

        public GetProductDeploymentResponse GetProductDeploymentWithOptions(string deploymentUID, GetProductDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithParamConfig))
            {
                query["withParamConfig"] = request.WithParamConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductDeployment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductDeploymentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductDeploymentResponse> GetProductDeploymentWithOptionsAsync(string deploymentUID, GetProductDeploymentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithParamConfig))
            {
                query["withParamConfig"] = request.WithParamConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductDeployment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(deploymentUID),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductDeploymentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductDeploymentResponse GetProductDeployment(string deploymentUID, GetProductDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductDeploymentWithOptions(deploymentUID, request, headers, runtime);
        }

        public async Task<GetProductDeploymentResponse> GetProductDeploymentAsync(string deploymentUID, GetProductDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductDeploymentWithOptionsAsync(deploymentUID, request, headers, runtime);
        }

        public GetProductVersionResponse GetProductVersionWithOptions(string uid, GetProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentationURL))
            {
                query["withDocumentationURL"] = request.WithDocumentationURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtendResourceURL))
            {
                query["withExtendResourceURL"] = request.WithExtendResourceURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductVersionResponse> GetProductVersionWithOptionsAsync(string uid, GetProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithDocumentationURL))
            {
                query["withDocumentationURL"] = request.WithDocumentationURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtendResourceURL))
            {
                query["withExtendResourceURL"] = request.WithExtendResourceURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductVersionResponse GetProductVersion(string uid, GetProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductVersionWithOptions(uid, request, headers, runtime);
        }

        public async Task<GetProductVersionResponse> GetProductVersionAsync(string uid, GetProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductVersionWithOptionsAsync(uid, request, headers, runtime);
        }

        public GetProductVersionDifferencesResponse GetProductVersionDifferencesWithOptions(string uid, string versionUID, GetProductVersionDifferencesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreVersionUID))
            {
                query["preVersionUID"] = request.PreVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersionDifferences",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionUID) + "/differences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionDifferencesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductVersionDifferencesResponse> GetProductVersionDifferencesWithOptionsAsync(string uid, string versionUID, GetProductVersionDifferencesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreVersionUID))
            {
                query["preVersionUID"] = request.PreVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersionDifferences",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/integration/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(versionUID) + "/differences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionDifferencesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductVersionDifferencesResponse GetProductVersionDifferences(string uid, string versionUID, GetProductVersionDifferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductVersionDifferencesWithOptions(uid, versionUID, request, headers, runtime);
        }

        public async Task<GetProductVersionDifferencesResponse> GetProductVersionDifferencesAsync(string uid, string versionUID, GetProductVersionDifferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductVersionDifferencesWithOptionsAsync(uid, versionUID, request, headers, runtime);
        }

        public GetProductVersionPackageResponse GetProductVersionPackageWithOptions(string uid, GetProductVersionPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldFoundationReferenceUID))
            {
                query["oldFoundationReferenceUID"] = request.OldFoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                query["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                query["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                query["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithURL))
            {
                query["withURL"] = request.WithURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersionPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetProductVersionPackageResponse> GetProductVersionPackageWithOptionsAsync(string uid, GetProductVersionPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldFoundationReferenceUID))
            {
                query["oldFoundationReferenceUID"] = request.OldFoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                query["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageContentType))
            {
                query["packageContentType"] = request.PackageContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["packageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUID))
            {
                query["packageUID"] = request.PackageUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithURL))
            {
                query["withURL"] = request.WithURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProductVersionPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProductVersionPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetProductVersionPackageResponse GetProductVersionPackage(string uid, GetProductVersionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProductVersionPackageWithOptions(uid, request, headers, runtime);
        }

        public async Task<GetProductVersionPackageResponse> GetProductVersionPackageAsync(string uid, GetProductVersionPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProductVersionPackageWithOptionsAsync(uid, request, headers, runtime);
        }

        public GetResourceSnapshotResponse GetResourceSnapshotWithOptions(GetResourceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceSnapshot",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resource-snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceSnapshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetResourceSnapshotResponse> GetResourceSnapshotWithOptionsAsync(GetResourceSnapshotRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceSnapshot",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resource-snapshots",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetResourceSnapshotResponse GetResourceSnapshot(GetResourceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceSnapshotWithOptions(request, headers, runtime);
        }

        public async Task<GetResourceSnapshotResponse> GetResourceSnapshotAsync(GetResourceSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceSnapshotWithOptionsAsync(request, headers, runtime);
        }

        public GetWorkflowStatusResponse GetWorkflowStatusWithOptions(GetWorkflowStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                query["workflowType"] = request.WorkflowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xuid))
            {
                query["xuid"] = request.Xuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowStatus",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/workflows/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWorkflowStatusResponse> GetWorkflowStatusWithOptionsAsync(GetWorkflowStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                query["workflowType"] = request.WorkflowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xuid))
            {
                query["xuid"] = request.Xuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWorkflowStatus",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/workflows/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWorkflowStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWorkflowStatusResponse GetWorkflowStatus(GetWorkflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWorkflowStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetWorkflowStatusResponse> GetWorkflowStatusAsync(GetWorkflowStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWorkflowStatusWithOptionsAsync(request, headers, runtime);
        }

        public InitEnvironmentResourceResponse InitEnvironmentResourceWithOptions(string uid, InitEnvironmentResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyID))
            {
                body["accessKeyID"] = request.AccessKeyID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["securityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitEnvironmentResource",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitEnvironmentResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InitEnvironmentResourceResponse> InitEnvironmentResourceWithOptionsAsync(string uid, InitEnvironmentResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeyID))
            {
                body["accessKeyID"] = request.AccessKeyID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessKeySecret))
            {
                body["accessKeySecret"] = request.AccessKeySecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityToken))
            {
                body["securityToken"] = request.SecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InitEnvironmentResource",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<InitEnvironmentResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InitEnvironmentResourceResponse InitEnvironmentResource(string uid, InitEnvironmentResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InitEnvironmentResourceWithOptions(uid, request, headers, runtime);
        }

        public async Task<InitEnvironmentResourceResponse> InitEnvironmentResourceAsync(string uid, InitEnvironmentResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InitEnvironmentResourceWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListComponentVersionsResponse ListComponentVersionsWithOptions(string uid, ListComponentVersionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComponentVersionsShrinkRequest request = new ListComponentVersionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListComponentVersionsResponse> ListComponentVersionsWithOptionsAsync(string uid, ListComponentVersionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListComponentVersionsShrinkRequest request = new ListComponentVersionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListComponentVersionsResponse ListComponentVersions(string uid, ListComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListComponentVersionsWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListComponentVersionsResponse> ListComponentVersionsAsync(string uid, ListComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListComponentVersionsWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListComponentsResponse ListComponentsWithOptions(ListComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListComponentsResponse> ListComponentsWithOptionsAsync(ListComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Public))
            {
                query["public"] = request.Public;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListComponentsWithOptions(request, headers, runtime);
        }

        public async Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListComponentsWithOptionsAsync(request, headers, runtime);
        }

        public ListDeliveryInstanceChangeRecordsResponse ListDeliveryInstanceChangeRecordsWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryInstanceChangeRecords",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/delivery-records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryInstanceChangeRecordsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeliveryInstanceChangeRecordsResponse> ListDeliveryInstanceChangeRecordsWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryInstanceChangeRecords",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/delivery-records",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryInstanceChangeRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeliveryInstanceChangeRecordsResponse ListDeliveryInstanceChangeRecords(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeliveryInstanceChangeRecordsWithOptions(uid, headers, runtime);
        }

        public async Task<ListDeliveryInstanceChangeRecordsResponse> ListDeliveryInstanceChangeRecordsAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeliveryInstanceChangeRecordsWithOptionsAsync(uid, headers, runtime);
        }

        public ListDeliveryPackageResponse ListDeliveryPackageWithOptions(ListDeliveryPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                query["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDeliveryPackageResponse> ListDeliveryPackageWithOptionsAsync(ListDeliveryPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                query["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["platform"] = request.Platform;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDeliveryPackage",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDeliveryPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDeliveryPackageResponse ListDeliveryPackage(ListDeliveryPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDeliveryPackageWithOptions(request, headers, runtime);
        }

        public async Task<ListDeliveryPackageResponse> ListDeliveryPackageAsync(ListDeliveryPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDeliveryPackageWithOptionsAsync(request, headers, runtime);
        }

        public ListEnvironmentLicensesResponse ListEnvironmentLicensesWithOptions(string uid, ListEnvironmentLicensesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentLicenses",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentLicensesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnvironmentLicensesResponse> ListEnvironmentLicensesWithOptionsAsync(string uid, ListEnvironmentLicensesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentLicenses",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/licenses",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentLicensesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnvironmentLicensesResponse ListEnvironmentLicenses(string uid, ListEnvironmentLicensesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentLicensesWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListEnvironmentLicensesResponse> ListEnvironmentLicensesAsync(string uid, ListEnvironmentLicensesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentLicensesWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListEnvironmentNodesResponse ListEnvironmentNodesWithOptions(string uid, ListEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnvironmentNodesResponse> ListEnvironmentNodesWithOptionsAsync(string uid, ListEnvironmentNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentNodes",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnvironmentNodesResponse ListEnvironmentNodes(string uid, ListEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentNodesWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListEnvironmentNodesResponse> ListEnvironmentNodesAsync(string uid, ListEnvironmentNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentNodesWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListEnvironmentTunnelsResponse ListEnvironmentTunnelsWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentTunnels",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentTunnelsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnvironmentTunnelsResponse> ListEnvironmentTunnelsWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironmentTunnels",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentTunnelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnvironmentTunnelsResponse ListEnvironmentTunnels(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentTunnelsWithOptions(uid, headers, runtime);
        }

        public async Task<ListEnvironmentTunnelsResponse> ListEnvironmentTunnelsAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentTunnelsWithOptionsAsync(uid, headers, runtime);
        }

        public ListEnvironmentsResponse ListEnvironmentsWithOptions(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationType))
            {
                query["foundationType"] = request.FoundationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                query["vendorType"] = request.VendorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEnvironmentsResponse> ListEnvironmentsWithOptionsAsync(ListEnvironmentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterUID))
            {
                query["clusterUID"] = request.ClusterUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationType))
            {
                query["foundationType"] = request.FoundationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["instanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorType))
            {
                query["vendorType"] = request.VendorType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnvironments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnvironmentsWithOptions(request, headers, runtime);
        }

        public async Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnvironmentsWithOptionsAsync(request, headers, runtime);
        }

        public ListFoundationComponentVersionsResponse ListFoundationComponentVersionsWithOptions(string uid, ListFoundationComponentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyEnabled))
            {
                query["onlyEnabled"] = request.OnlyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentRelationUID))
            {
                query["parentComponentRelationUID"] = request.ParentComponentRelationUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationComponentVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFoundationComponentVersionsResponse> ListFoundationComponentVersionsWithOptionsAsync(string uid, ListFoundationComponentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyEnabled))
            {
                query["onlyEnabled"] = request.OnlyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentRelationUID))
            {
                query["parentComponentRelationUID"] = request.ParentComponentRelationUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationComponentVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFoundationComponentVersionsResponse ListFoundationComponentVersions(string uid, ListFoundationComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFoundationComponentVersionsWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListFoundationComponentVersionsResponse> ListFoundationComponentVersionsAsync(string uid, ListFoundationComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFoundationComponentVersionsWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListFoundationReferenceComponentsResponse ListFoundationReferenceComponentsWithOptions(ListFoundationReferenceComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                query["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyEnabled))
            {
                query["onlyEnabled"] = request.OnlyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentReferenceUID))
            {
                query["parentComponentReferenceUID"] = request.ParentComponentReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationReferenceComponents",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationReferenceComponentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFoundationReferenceComponentsResponse> ListFoundationReferenceComponentsWithOptionsAsync(ListFoundationReferenceComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationReferenceUID))
            {
                query["foundationReferenceUID"] = request.FoundationReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                query["foundationVersionUID"] = request.FoundationVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyEnabled))
            {
                query["onlyEnabled"] = request.OnlyEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentReferenceUID))
            {
                query["parentComponentReferenceUID"] = request.ParentComponentReferenceUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationReferenceComponents",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationReferenceComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFoundationReferenceComponentsResponse ListFoundationReferenceComponents(ListFoundationReferenceComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFoundationReferenceComponentsWithOptions(request, headers, runtime);
        }

        public async Task<ListFoundationReferenceComponentsResponse> ListFoundationReferenceComponentsAsync(ListFoundationReferenceComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFoundationReferenceComponentsWithOptionsAsync(request, headers, runtime);
        }

        public ListFoundationVersionsResponse ListFoundationVersionsWithOptions(ListFoundationVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyDefault))
            {
                query["onlyDefault"] = request.OnlyDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirect))
            {
                query["sortDirect"] = request.SortDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["sortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListFoundationVersionsResponse> ListFoundationVersionsWithOptionsAsync(ListFoundationVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyDefault))
            {
                query["onlyDefault"] = request.OnlyDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirect))
            {
                query["sortDirect"] = request.SortDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["sortKey"] = request.SortKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFoundationVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFoundationVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListFoundationVersionsResponse ListFoundationVersions(ListFoundationVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFoundationVersionsWithOptions(request, headers, runtime);
        }

        public async Task<ListFoundationVersionsResponse> ListFoundationVersionsAsync(ListFoundationVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFoundationVersionsWithOptionsAsync(request, headers, runtime);
        }

        public ListProductComponentVersionsResponse ListProductComponentVersionsWithOptions(string uid, ListProductComponentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                query["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirect))
            {
                query["sortDirect"] = request.SortDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["sortKey"] = request.SortKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductComponentVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductComponentVersionsResponse> ListProductComponentVersionsWithOptionsAsync(string uid, ListProductComponentVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                query["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirect))
            {
                query["sortDirect"] = request.SortDirect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKey))
            {
                query["sortKey"] = request.SortKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductComponentVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/component-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductComponentVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductComponentVersionsResponse ListProductComponentVersions(string uid, ListProductComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductComponentVersionsWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListProductComponentVersionsResponse> ListProductComponentVersionsAsync(string uid, ListProductComponentVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductComponentVersionsWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListProductDeploymentsResponse ListProductDeploymentsWithOptions(ListProductDeploymentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductDeployments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductDeploymentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductDeploymentsResponse> ListProductDeploymentsWithOptionsAsync(ListProductDeploymentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductDeployments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/deployments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductDeploymentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductDeploymentsResponse ListProductDeployments(ListProductDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductDeploymentsWithOptions(request, headers, runtime);
        }

        public async Task<ListProductDeploymentsResponse> ListProductDeploymentsAsync(ListProductDeploymentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductDeploymentsWithOptionsAsync(request, headers, runtime);
        }

        public ListProductEnvironmentsResponse ListProductEnvironmentsWithOptions(string uid, ListProductEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductEnvironmentsShrinkRequest request = new ListProductEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleProductVersionUID))
            {
                query["compatibleProductVersionUID"] = request.CompatibleProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvType))
            {
                query["envType"] = request.EnvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionSpecUID))
            {
                query["productVersionSpecUID"] = request.ProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductEnvironments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductEnvironmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductEnvironmentsResponse> ListProductEnvironmentsWithOptionsAsync(string uid, ListProductEnvironmentsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductEnvironmentsShrinkRequest request = new ListProductEnvironmentsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompatibleProductVersionUID))
            {
                query["compatibleProductVersionUID"] = request.CompatibleProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvType))
            {
                query["envType"] = request.EnvType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionSpecUID))
            {
                query["productVersionSpecUID"] = request.ProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductEnvironments",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/hosting/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/environments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductEnvironmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductEnvironmentsResponse ListProductEnvironments(string uid, ListProductEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductEnvironmentsWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListProductEnvironmentsResponse> ListProductEnvironmentsAsync(string uid, ListProductEnvironmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductEnvironmentsWithOptionsAsync(uid, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListProductFoundationReferencesResponse
         */
        // Deprecated
        public ListProductFoundationReferencesResponse ListProductFoundationReferencesWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductFoundationReferences",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation-references",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductFoundationReferencesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListProductFoundationReferencesResponse
         */
        // Deprecated
        public async Task<ListProductFoundationReferencesResponse> ListProductFoundationReferencesWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductFoundationReferences",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation-references",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductFoundationReferencesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @return ListProductFoundationReferencesResponse
         */
        // Deprecated
        public ListProductFoundationReferencesResponse ListProductFoundationReferences(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductFoundationReferencesWithOptions(uid, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @return ListProductFoundationReferencesResponse
         */
        // Deprecated
        public async Task<ListProductFoundationReferencesResponse> ListProductFoundationReferencesAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductFoundationReferencesWithOptionsAsync(uid, headers, runtime);
        }

        public ListProductInstanceConfigsResponse ListProductInstanceConfigsWithOptions(ListProductInstanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                query["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["paramType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductInstanceConfigs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductInstanceConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductInstanceConfigsResponse> ListProductInstanceConfigsWithOptionsAsync(ListProductInstanceConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                query["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                query["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamType))
            {
                query["paramType"] = request.ParamType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductInstanceConfigs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductInstanceConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductInstanceConfigsResponse ListProductInstanceConfigs(ListProductInstanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductInstanceConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListProductInstanceConfigsResponse> ListProductInstanceConfigsAsync(ListProductInstanceConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductInstanceConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListProductInstancesResponse ListProductInstancesWithOptions(ListProductInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductInstancesShrinkRequest request = new ListProductInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                query["envUID"] = request.EnvUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductInstances",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductInstancesResponse> ListProductInstancesWithOptionsAsync(ListProductInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductInstancesShrinkRequest request = new ListProductInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvUID))
            {
                query["envUID"] = request.EnvUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                query["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductInstances",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductInstancesResponse ListProductInstances(ListProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductInstancesWithOptions(request, headers, runtime);
        }

        public async Task<ListProductInstancesResponse> ListProductInstancesAsync(ListProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductInstancesWithOptionsAsync(request, headers, runtime);
        }

        public ListProductVersionConfigsResponse ListProductVersionConfigsWithOptions(string uid, ListProductVersionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                query["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductVersionConfigs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductVersionConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductVersionConfigsResponse> ListProductVersionConfigsWithOptionsAsync(string uid, ListProductVersionConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentReleaseName))
            {
                query["componentReleaseName"] = request.ComponentReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigType))
            {
                query["configType"] = request.ConfigType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                query["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductVersionConfigs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductVersionConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductVersionConfigsResponse ListProductVersionConfigs(string uid, ListProductVersionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductVersionConfigsWithOptions(uid, request, headers, runtime);
        }

        public async Task<ListProductVersionConfigsResponse> ListProductVersionConfigsAsync(string uid, ListProductVersionConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductVersionConfigsWithOptionsAsync(uid, request, headers, runtime);
        }

        public ListProductVersionsResponse ListProductVersionsWithOptions(ListProductVersionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductVersionsShrinkRequest request = new ListProductVersionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupportedFoundationTypes))
            {
                request.SupportedFoundationTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupportedFoundationTypes, "supportedFoundationTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUID))
            {
                query["productUID"] = request.ProductUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Released))
            {
                query["released"] = request.Released;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedFoundationTypesShrink))
            {
                query["supportedFoundationTypes"] = request.SupportedFoundationTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductVersionsResponse> ListProductVersionsWithOptionsAsync(ListProductVersionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProductVersionsShrinkRequest request = new ListProductVersionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Platforms))
            {
                request.PlatformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Platforms, "platforms", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SupportedFoundationTypes))
            {
                request.SupportedFoundationTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SupportedFoundationTypes, "supportedFoundationTypes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlatformsShrink))
            {
                query["platforms"] = request.PlatformsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductUID))
            {
                query["productUID"] = request.ProductUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Released))
            {
                query["released"] = request.Released;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportedFoundationTypesShrink))
            {
                query["supportedFoundationTypes"] = request.SupportedFoundationTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProductVersions",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductVersionsResponse ListProductVersions(ListProductVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductVersionsWithOptions(request, headers, runtime);
        }

        public async Task<ListProductVersionsResponse> ListProductVersionsAsync(ListProductVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductVersionsWithOptionsAsync(request, headers, runtime);
        }

        public ListProductsResponse ListProductsWithOptions(ListProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Fuzzy))
            {
                query["fuzzy"] = request.Fuzzy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProducts",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProductsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProductsWithOptions(request, headers, runtime);
        }

        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProductsWithOptionsAsync(request, headers, runtime);
        }

        public ListWorkflowTaskLogsResponse ListWorkflowTaskLogsWithOptions(string stepName, string taskName, ListWorkflowTaskLogsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkflowTaskLogsShrinkRequest request = new ListWorkflowTaskLogsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterValues))
            {
                request.FilterValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterValues, "filterValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValuesShrink))
            {
                query["filterValues"] = request.FilterValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                query["workflowType"] = request.WorkflowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xuid))
            {
                query["xuid"] = request.Xuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowTaskLogs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/workflows/steps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(stepName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkflowTaskLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListWorkflowTaskLogsResponse> ListWorkflowTaskLogsWithOptionsAsync(string stepName, string taskName, ListWorkflowTaskLogsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWorkflowTaskLogsShrinkRequest request = new ListWorkflowTaskLogsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterValues))
            {
                request.FilterValuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterValues, "filterValues", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterValuesShrink))
            {
                query["filterValues"] = request.FilterValuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["orderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                query["workflowType"] = request.WorkflowType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Xuid))
            {
                query["xuid"] = request.Xuid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkflowTaskLogs",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/workflows/steps/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(stepName) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskName) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkflowTaskLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListWorkflowTaskLogsResponse ListWorkflowTaskLogs(string stepName, string taskName, ListWorkflowTaskLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWorkflowTaskLogsWithOptions(stepName, taskName, request, headers, runtime);
        }

        public async Task<ListWorkflowTaskLogsResponse> ListWorkflowTaskLogsAsync(string stepName, string taskName, ListWorkflowTaskLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWorkflowTaskLogsWithOptionsAsync(stepName, taskName, request, headers, runtime);
        }

        public PutEnvironmentTunnelResponse PutEnvironmentTunnelWithOptions(string uid, PutEnvironmentTunnelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelConfig))
            {
                body["tunnelConfig"] = request.TunnelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelType))
            {
                body["tunnelType"] = request.TunnelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnvironmentTunnel",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnvironmentTunnelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutEnvironmentTunnelResponse> PutEnvironmentTunnelWithOptionsAsync(string uid, PutEnvironmentTunnelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelConfig))
            {
                body["tunnelConfig"] = request.TunnelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelType))
            {
                body["tunnelType"] = request.TunnelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnvironmentTunnel",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnvironmentTunnelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutEnvironmentTunnelResponse PutEnvironmentTunnel(string uid, PutEnvironmentTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutEnvironmentTunnelWithOptions(uid, request, headers, runtime);
        }

        public async Task<PutEnvironmentTunnelResponse> PutEnvironmentTunnelAsync(string uid, PutEnvironmentTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutEnvironmentTunnelWithOptionsAsync(uid, request, headers, runtime);
        }

        public PutProductInstanceConfigResponse PutProductInstanceConfigWithOptions(PutProductInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentUID))
            {
                body["componentUID"] = request.ComponentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigUID))
            {
                body["configUID"] = request.ConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentName))
            {
                body["parentComponentName"] = request.ParentComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProductInstanceConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProductInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutProductInstanceConfigResponse> PutProductInstanceConfigWithOptionsAsync(PutProductInstanceConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentUID))
            {
                body["componentUID"] = request.ComponentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigUID))
            {
                body["configUID"] = request.ConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnvironmentUID))
            {
                body["environmentUID"] = request.EnvironmentUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentName))
            {
                body["parentComponentName"] = request.ParentComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                body["scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProductInstanceConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-instances/configs",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProductInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutProductInstanceConfigResponse PutProductInstanceConfig(PutProductInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProductInstanceConfigWithOptions(request, headers, runtime);
        }

        public async Task<PutProductInstanceConfigResponse> PutProductInstanceConfigAsync(PutProductInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProductInstanceConfigWithOptionsAsync(request, headers, runtime);
        }

        public SetEnvironmentFoundationReferenceResponse SetEnvironmentFoundationReferenceWithOptions(string uid, string foundationReferenceUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEnvironmentFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(foundationReferenceUID),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEnvironmentFoundationReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetEnvironmentFoundationReferenceResponse> SetEnvironmentFoundationReferenceWithOptionsAsync(string uid, string foundationReferenceUID, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetEnvironmentFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(foundationReferenceUID),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetEnvironmentFoundationReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetEnvironmentFoundationReferenceResponse SetEnvironmentFoundationReference(string uid, string foundationReferenceUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SetEnvironmentFoundationReferenceWithOptions(uid, foundationReferenceUID, headers, runtime);
        }

        public async Task<SetEnvironmentFoundationReferenceResponse> SetEnvironmentFoundationReferenceAsync(string uid, string foundationReferenceUID)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SetEnvironmentFoundationReferenceWithOptionsAsync(uid, foundationReferenceUID, headers, runtime);
        }

        public UpdateDeliverableResponse UpdateDeliverableWithOptions(string uid, UpdateDeliverableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliverableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDeliverableResponse> UpdateDeliverableWithOptionsAsync(string uid, UpdateDeliverableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Foundation))
            {
                body["foundation"] = request.Foundation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Products))
            {
                body["products"] = request.Products;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliverable",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/deliverables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliverableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDeliverableResponse UpdateDeliverable(string uid, UpdateDeliverableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDeliverableWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateDeliverableResponse> UpdateDeliverableAsync(string uid, UpdateDeliverableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDeliverableWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateDeliveryInstanceResponse UpdateDeliveryInstanceWithOptions(string uid, UpdateDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableConfigUID))
            {
                body["deliverableConfigUID"] = request.DeliverableConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDeliveryInstanceResponse> UpdateDeliveryInstanceWithOptionsAsync(string uid, UpdateDeliveryInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableConfigUID))
            {
                body["deliverableConfigUID"] = request.DeliverableConfigUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliverableUID))
            {
                body["deliverableUID"] = request.DeliverableUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Desc))
            {
                body["desc"] = request.Desc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDeliveryInstance",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/delivery/delivery-instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDeliveryInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDeliveryInstanceResponse UpdateDeliveryInstance(string uid, UpdateDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDeliveryInstanceWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateDeliveryInstanceResponse> UpdateDeliveryInstanceAsync(string uid, UpdateDeliveryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDeliveryInstanceWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateEnvironmentResponse UpdateEnvironmentWithOptions(string uid, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfigs))
            {
                body["advancedConfigs"] = request.AdvancedConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorConfig))
            {
                body["vendorConfig"] = request.VendorConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentWithOptionsAsync(string uid, UpdateEnvironmentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedConfigs))
            {
                body["advancedConfigs"] = request.AdvancedConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VendorConfig))
            {
                body["vendorConfig"] = request.VendorConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironment",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEnvironmentResponse UpdateEnvironment(string uid, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(string uid, UpdateEnvironmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateEnvironmentNodeResponse UpdateEnvironmentNodeWithOptions(string uid, string nodeUID, UpdateEnvironmentNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDisk))
            {
                body["applicationDisk"] = request.ApplicationDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtcdDisk))
            {
                body["etcdDisk"] = request.EtcdDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootPassword))
            {
                body["rootPassword"] = request.RootPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemDisk))
            {
                body["tridentSystemDisk"] = request.TridentSystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemSizeDisk))
            {
                body["tridentSystemSizeDisk"] = request.TridentSystemSizeDisk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentNodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEnvironmentNodeResponse> UpdateEnvironmentNodeWithOptionsAsync(string uid, string nodeUID, UpdateEnvironmentNodeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationDisk))
            {
                body["applicationDisk"] = request.ApplicationDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtcdDisk))
            {
                body["etcdDisk"] = request.EtcdDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootPassword))
            {
                body["rootPassword"] = request.RootPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemDisk))
            {
                body["tridentSystemDisk"] = request.TridentSystemDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TridentSystemSizeDisk))
            {
                body["tridentSystemSizeDisk"] = request.TridentSystemSizeDisk;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironmentNode",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/nodes/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodeUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEnvironmentNodeResponse UpdateEnvironmentNode(string uid, string nodeUID, UpdateEnvironmentNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentNodeWithOptions(uid, nodeUID, request, headers, runtime);
        }

        public async Task<UpdateEnvironmentNodeResponse> UpdateEnvironmentNodeAsync(string uid, string nodeUID, UpdateEnvironmentNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentNodeWithOptionsAsync(uid, nodeUID, request, headers, runtime);
        }

        public UpdateEnvironmentProductVersionResponse UpdateEnvironmentProductVersionWithOptions(string uid, UpdateEnvironmentProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionSpecUID))
            {
                body["oldProductVersionSpecUID"] = request.OldProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                body["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionSpecUID))
            {
                body["productVersionSpecUID"] = request.ProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironmentProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEnvironmentProductVersionResponse> UpdateEnvironmentProductVersionWithOptionsAsync(string uid, UpdateEnvironmentProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionSpecUID))
            {
                body["oldProductVersionSpecUID"] = request.OldProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldProductVersionUID))
            {
                body["oldProductVersionUID"] = request.OldProductVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionSpecUID))
            {
                body["productVersionSpecUID"] = request.ProductVersionSpecUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductVersionUID))
            {
                body["productVersionUID"] = request.ProductVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnvironmentProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/product-versions",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnvironmentProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEnvironmentProductVersionResponse UpdateEnvironmentProductVersion(string uid, UpdateEnvironmentProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnvironmentProductVersionWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateEnvironmentProductVersionResponse> UpdateEnvironmentProductVersionAsync(string uid, UpdateEnvironmentProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnvironmentProductVersionWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateFoundationComponentReferenceResponse UpdateFoundationComponentReferenceWithOptions(string uid, string componentReferenceUID, UpdateFoundationComponentReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentOrchestrationValues))
            {
                body["componentOrchestrationValues"] = request.ComponentOrchestrationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFoundationComponentReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentReferenceUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFoundationComponentReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFoundationComponentReferenceResponse> UpdateFoundationComponentReferenceWithOptionsAsync(string uid, string componentReferenceUID, UpdateFoundationComponentReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentOrchestrationValues))
            {
                body["componentOrchestrationValues"] = request.ComponentOrchestrationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFoundationComponentReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentReferenceUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFoundationComponentReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFoundationComponentReferenceResponse UpdateFoundationComponentReference(string uid, string componentReferenceUID, UpdateFoundationComponentReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFoundationComponentReferenceWithOptions(uid, componentReferenceUID, request, headers, runtime);
        }

        public async Task<UpdateFoundationComponentReferenceResponse> UpdateFoundationComponentReferenceAsync(string uid, string componentReferenceUID, UpdateFoundationComponentReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFoundationComponentReferenceWithOptionsAsync(uid, componentReferenceUID, request, headers, runtime);
        }

        public UpdateFoundationReferenceResponse UpdateFoundationReferenceWithOptions(string uid, UpdateFoundationReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfig))
            {
                body["clusterConfig"] = request.ClusterConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFoundationReferenceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateFoundationReferenceResponse> UpdateFoundationReferenceWithOptionsAsync(string uid, UpdateFoundationReferenceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterConfig))
            {
                body["clusterConfig"] = request.ClusterConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFoundationReference",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/foundation-references/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateFoundationReferenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateFoundationReferenceResponse UpdateFoundationReference(string uid, UpdateFoundationReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateFoundationReferenceWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateFoundationReferenceResponse> UpdateFoundationReferenceAsync(string uid, UpdateFoundationReferenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateFoundationReferenceWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateProductResponse UpdateProductWithOptions(string uid, UpdateProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                body["categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProductResponse> UpdateProductWithOptionsAsync(string uid, UpdateProductRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Categories))
            {
                body["categories"] = request.Categories;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                body["vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProduct",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/products/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProductResponse UpdateProduct(string uid, UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProductWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateProductResponse> UpdateProductAsync(string uid, UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProductWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateProductComponentVersionResponse UpdateProductComponentVersionWithOptions(string uid, string relationUID, UpdateProductComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentOrchestrationValues))
            {
                body["componentOrchestrationValues"] = request.ComponentOrchestrationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentSpecificationUid))
            {
                body["componentSpecificationUid"] = request.ComponentSpecificationUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentSpecificationValues))
            {
                body["componentSpecificationValues"] = request.ComponentSpecificationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComponentVersionUID))
            {
                body["newComponentVersionUID"] = request.NewComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsetComponentVersionSpec))
            {
                body["unsetComponentVersionSpec"] = request.UnsetComponentVersionSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductComponentVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProductComponentVersionResponse> UpdateProductComponentVersionWithOptionsAsync(string uid, string relationUID, UpdateProductComponentVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentOrchestrationValues))
            {
                body["componentOrchestrationValues"] = request.ComponentOrchestrationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentSpecificationUid))
            {
                body["componentSpecificationUid"] = request.ComponentSpecificationUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentSpecificationValues))
            {
                body["componentSpecificationValues"] = request.ComponentSpecificationValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewComponentVersionUID))
            {
                body["newComponentVersionUID"] = request.NewComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                body["policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseName))
            {
                body["releaseName"] = request.ReleaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsetComponentVersionSpec))
            {
                body["unsetComponentVersionSpec"] = request.UnsetComponentVersionSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductComponentVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/relations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(relationUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductComponentVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProductComponentVersionResponse UpdateProductComponentVersion(string uid, string relationUID, UpdateProductComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProductComponentVersionWithOptions(uid, relationUID, request, headers, runtime);
        }

        public async Task<UpdateProductComponentVersionResponse> UpdateProductComponentVersionAsync(string uid, string relationUID, UpdateProductComponentVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProductComponentVersionWithOptionsAsync(uid, relationUID, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request UpdateProductFoundationVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateProductFoundationVersionResponse
         */
        // Deprecated
        public UpdateProductFoundationVersionResponse UpdateProductFoundationVersionWithOptions(string uid, UpdateProductFoundationVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductFoundationVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductFoundationVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request UpdateProductFoundationVersionRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateProductFoundationVersionResponse
         */
        // Deprecated
        public async Task<UpdateProductFoundationVersionResponse> UpdateProductFoundationVersionWithOptionsAsync(string uid, UpdateProductFoundationVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FoundationVersionUID))
            {
                body["foundationVersionUID"] = request.FoundationVersionUID;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductFoundationVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/foundation",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductFoundationVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request UpdateProductFoundationVersionRequest
          * @return UpdateProductFoundationVersionResponse
         */
        // Deprecated
        public UpdateProductFoundationVersionResponse UpdateProductFoundationVersion(string uid, UpdateProductFoundationVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProductFoundationVersionWithOptions(uid, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request UpdateProductFoundationVersionRequest
          * @return UpdateProductFoundationVersionResponse
         */
        // Deprecated
        public async Task<UpdateProductFoundationVersionResponse> UpdateProductFoundationVersionAsync(string uid, UpdateProductFoundationVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProductFoundationVersionWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateProductVersionResponse UpdateProductVersionWithOptions(string uid, UpdateProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuousIntegration))
            {
                body["continuousIntegration"] = request.ContinuousIntegration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                body["entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProductVersionResponse> UpdateProductVersionWithOptionsAsync(string uid, UpdateProductVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContinuousIntegration))
            {
                body["continuousIntegration"] = request.ContinuousIntegration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Entry))
            {
                body["entry"] = request.Entry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductVersion",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProductVersionResponse UpdateProductVersion(string uid, UpdateProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProductVersionWithOptions(uid, request, headers, runtime);
        }

        public async Task<UpdateProductVersionResponse> UpdateProductVersionAsync(string uid, UpdateProductVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProductVersionWithOptionsAsync(uid, request, headers, runtime);
        }

        public UpdateProductVersionConfigResponse UpdateProductVersionConfigWithOptions(string uid, string configUID, UpdateProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductVersionConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateProductVersionConfigResponse> UpdateProductVersionConfigWithOptionsAsync(string uid, string configUID, UpdateProductVersionConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentVersionUID))
            {
                body["componentVersionUID"] = request.ComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentComponentVersionUID))
            {
                body["parentComponentVersionUID"] = request.ParentComponentVersionUID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValueType))
            {
                body["valueType"] = request.ValueType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProductVersionConfig",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/product-versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/configs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(configUID),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProductVersionConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateProductVersionConfigResponse UpdateProductVersionConfig(string uid, string configUID, UpdateProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProductVersionConfigWithOptions(uid, configUID, request, headers, runtime);
        }

        public async Task<UpdateProductVersionConfigResponse> UpdateProductVersionConfigAsync(string uid, string configUID, UpdateProductVersionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProductVersionConfigWithOptionsAsync(uid, configUID, request, headers, runtime);
        }

        public ValidateEnvironmentTunnelResponse ValidateEnvironmentTunnelWithOptions(string uid, ValidateEnvironmentTunnelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelConfig))
            {
                body["tunnelConfig"] = request.TunnelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelType))
            {
                body["tunnelType"] = request.TunnelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateEnvironmentTunnel",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels/validation",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateEnvironmentTunnelResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ValidateEnvironmentTunnelResponse> ValidateEnvironmentTunnelWithOptionsAsync(string uid, ValidateEnvironmentTunnelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelConfig))
            {
                body["tunnelConfig"] = request.TunnelConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TunnelType))
            {
                body["tunnelType"] = request.TunnelType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ValidateEnvironmentTunnel",
                Version = "2021-07-20",
                Protocol = "HTTPS",
                Pathname = "/api/v2/environments/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/tunnels/validation",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ValidateEnvironmentTunnelResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ValidateEnvironmentTunnelResponse ValidateEnvironmentTunnel(string uid, ValidateEnvironmentTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ValidateEnvironmentTunnelWithOptions(uid, request, headers, runtime);
        }

        public async Task<ValidateEnvironmentTunnelResponse> ValidateEnvironmentTunnelAsync(string uid, ValidateEnvironmentTunnelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ValidateEnvironmentTunnelWithOptionsAsync(uid, request, headers, runtime);
        }

    }
}
