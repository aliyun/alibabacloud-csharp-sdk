// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListOnDemandConfigsResponseBody : TeaModel {
        /// <summary>
        /// $.parameters[9].schema.enumValueTitles
        /// </summary>
        [NameInMap("configs")]
        [Validation(Required=false)]
        public List<OnDemandConfig> Configs { get; set; }

        /// <summary>
        /// {"name":"ListOnDemandConfigs","product":"FC-Open","version":"2021-04-06","path":"/2021-04-06/on-demand-configs","deprecated":0,"method":"GET","protocol":"HTTP|HTTPS","hidden":0,"timeout":10000,"parameter_type":"Single","params":"[{\"name\":\"prefix\",\"position\":\"Query\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The prefix that the names of returned resources must contain. If the name prefix is a, the names of returned resources must start with a. \",\"description\":\"The prefix that the names of returned resources must contain. If the name prefix is a, the names of returned resources must start with a. \",\"example\":\"prefix_text\"},{\"name\":\"startKey\",\"position\":\"Query\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The returned resources are sorted in alphabetical order, and the resources that include and follow the resource specified by the startKey parameter are returned. \",\"description\":\"The returned resources are sorted in alphabetical order, and the resources that include and follow the resource specified by the startKey parameter are returned. \",\"example\":\"nextservice\"},{\"name\":\"nextToken\",\"position\":\"Query\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The token used to obtain more results. If the number of resources exceeds the limit, the nextToken parameter is returned. You can include the parameter in subsequent calls to obtain more results. You do not need to provide this parameter in the first call. \",\"description\":\"The token used to obtain more results. If the number of resources exceeds the limit, the nextToken parameter is returned. You can include the parameter in subsequent calls to obtain more results. You do not need to provide this parameter in the first call. \",\"example\":\"8bj81uI8n****\"},{\"name\":\"limit\",\"position\":\"Query\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"Integer\",\"title\":\"The maximum number of resources to return. Default value: 20. Maximum value: 100. The number of returned resources is less than or equal to the specified number. \",\"description\":\"The maximum number of resources to return. Default value: 20. Maximum value: 100. The number of returned resources is less than or equal to the specified number. \",\"example\":\"20\"},{\"name\":\"X-Fc-Account-Id\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The ID of your Alibaba Cloud account. \",\"example\":\"188077086902****\"},{\"name\":\"X-Fc-Date\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The time when Function Compute API is called. \",\"example\":\"2020-12-1210:00:00\"},{\"name\":\"X-Fc-Trace-Id\",\"position\":\"Header\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"description\":\"The trace ID of the invocation request of Function Compute. \",\"example\":\"rid281s******\"}]","response_headers":"[]","response":"{\"type\":\"Object\",\"children\":[{\"name\":\"configs\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"Array\",\"subType\":\"Object\",\"example\":\"[{\"maximumInstanceCount\": 10, \"resource\": \"services/serviceName-bb7f36eb-7f1b-4c42-8f64-401b32ecbf31.aliasName/functions/functionName\"}]\",\"description\":\"The information about the on-demand configuration. \",\"children\":[{\"name\":\"resource\",\"required\":false,\"checkBlank\":false,\"visibility\":\"public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The details of the function.\",\"description\":\"The description of the resource. \",\"example\":\"123#serviceName#alias#functionName\"},{\"name\":\"maximumInstanceCount\",\"required\":false,\"checkBlank\":false,\"visibility\":\"public\",\"deprecated\":false,\"type\":\"Long\",\"title\":\"todo\",\"description\":\"The maximum number of on-demand instances. \",\"example\":\"10\"}],\"title\":\"The information about the provisioned configuration.\"},{\"name\":\"nextToken\",\"required\":false,\"checkBlank\":false,\"visibility\":\"Public\",\"deprecated\":false,\"type\":\"String\",\"title\":\"The token used to obtain more results. If this parameter is left empty, all the results are returned. \",\"description\":\"The token used to obtain more results. If this parameter is left empty, all the results are returned. \",\"example\":\"next_token\"}],\"title\":\"Schema of Response\",\"description\":\"The returned data. \"}","errors":"{}"}
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
