// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaAlarmsRequest : TeaModel {
        /// <summary>
        /// The name of the alert.
        /// </summary>
        [NameInMap("AlarmName")]
        [Validation(Required=false)]
        public string AlarmName { get; set; }

        /// <summary>
        /// The maximum number of records that you want to return for the query.
        /// 
        /// Valid values: 1 to 200. Default value: 30.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that marks the position from which you want to start the query.
        /// 
        /// > An empty value indicates that the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The abbreviation of the Alibaba Cloud service name.
        /// 
        /// >  To query the abbreviation of an Alibaba Cloud service name, call the [ListProducts](https://help.aliyun.com/document_detail/440554.html) operation and check the value of `ProductCode` in the response.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The quota ID.
        /// 
        /// > 
        /// 
        /// *   To obtain the quota ID of a cloud service, call the [ListProductQuotas](https://help.aliyun.com/document_detail/440554.html) operation and check the value of `QuotaActionCode` in the response.
        /// 
        /// *   If you specify this parameter, you must specify `ProductCode`.
        /// </summary>
        [NameInMap("QuotaActionCode")]
        [Validation(Required=false)]
        public string QuotaActionCode { get; set; }

        /// <summary>
        /// The quota dimensions.
        /// </summary>
        [NameInMap("QuotaDimensions")]
        [Validation(Required=false)]
        public List<ListQuotaAlarmsRequestQuotaDimensions> QuotaDimensions { get; set; }
        public class ListQuotaAlarmsRequestQuotaDimensions : TeaModel {
            /// <summary>
            /// The key of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   This parameter is required if you set the `ProductCode` parameter to `ecs`, `ecs-spec`, `actiontrail`, or `ess`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the dimension.
            /// 
            /// > 
            /// 
            /// *   The value range of N varies based on the number of dimensions that are supported by the related Alibaba Cloud service.
            /// 
            /// *   This parameter is required if you set the `ProductCode` parameter to `ecs`, `ecs-spec`, `actiontrail`, or `ess`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
