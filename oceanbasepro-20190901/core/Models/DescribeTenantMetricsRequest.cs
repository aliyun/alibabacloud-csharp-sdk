// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantMetricsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 2021-06-13T15:40:43Z
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// {"name":"DescribeTenantMetrics","product":"OceanBasePro","version":"2019-09-01","path":"/","deprecated":0,"method":"POST|GET","protocol":"HTTP|HTTPS","hidden":0,"timeout":10000,"parameter_type":"Single","params":"[{\\"name\\":\\"Action\\",\\"position\\":\\"Query\\",\\"required\\":true,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"description\\":\\"\\",\\"example\\":\\"DescribeTenantMetrics\\"},{\\"name\\":\\"InstanceId\\",\\"position\\":\\"Body\\",\\"required\\":true,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"ob317v4uif****\\"},{\\"name\\":\\"PageSize\\",\\"position\\":\\"Body\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"Integer\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"10\\"},{\\"name\\":\\"PageNumber\\",\\"position\\":\\"Body\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"Integer\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"1\\"},{\\"name\\":\\"TenantName\\",\\"position\\":\\"Body\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":true,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"pay_online\\"},{\\"name\\":\\"StartTime\\",\\"position\\":\\"Body\\",\\"required\\":true,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"2021-06-13T15:40:43Z\\"},{\\"name\\":\\"EndTime\\",\\"position\\":\\"Body\\",\\"required\\":true,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"2021-06-13T15:45:43Z\\"},{\\"name\\":\\"Metrics\\",\\"position\\":\\"Body\\",\\"required\\":true,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"tps\\"},{\\"name\\":\\"TenantId\\",\\"position\\":\\"Body\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":true,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"tfafd34fs****\\"},{\\"name\\":\\"TenantIdList\\",\\"position\\":\\"Body\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"[tdak3nac****,tdakc42df****]\\"}]","response_headers":"[]","response":"{\\"type\\":\\"Object\\",\\"children\\":[{\\"name\\":\\"TotalCount\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"Integer\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"9\\"},{\\"name\\":\\"RequestId\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C\\"},{\\"name\\":\\"TenantMetrics\\",\\"required\\":false,\\"checkBlank\\":false,\\"visibility\\":\\"Public\\",\\"deprecated\\":false,\\"type\\":\\"String\\",\\"title\\":\\"\\",\\"description\\":\\"\\",\\"example\\":\\"\\\\\\"Metrics\\\\\\":[ {\\\\\\"request_queue_rt\\\\\\":0.0,\\\\\\"TimeStamp\\\\\\":\\\\\\"2022-02-23T01:58:00Z\\\\\\"}]\\"}],\\"title\\":\\"\\",\\"description\\":\\"\\"}","errors":"{}"}
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// tfafd34fs****
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Example 1
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantIdList")]
        [Validation(Required=false)]
        public string TenantIdList { get; set; }

        /// <summary>
        /// 2021-06-13T15:45:43Z
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        [Obsolete]
        public string TenantName { get; set; }

    }

}
