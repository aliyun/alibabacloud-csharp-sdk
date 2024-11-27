// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class PageServiceCustomerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PageServiceCustomerResponseBodyData> Data { get; set; }
        public class PageServiceCustomerResponseBodyData : TeaModel {
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            [NameInMap("AuthStatus")]
            [Validation(Required=false)]
            public int? AuthStatus { get; set; }

            [NameInMap("CmAuthStatus")]
            [Validation(Required=false)]
            public int? CmAuthStatus { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("MonitorAuthStatus")]
            [Validation(Required=false)]
            public int? MonitorAuthStatus { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OwnId")]
            [Validation(Required=false)]
            public string OwnId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public PageServiceCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class PageServiceCustomerResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
