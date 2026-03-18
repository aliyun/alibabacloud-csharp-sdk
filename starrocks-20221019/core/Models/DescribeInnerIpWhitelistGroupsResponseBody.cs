// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeInnerIpWhitelistGroupsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE74XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeInnerIpWhitelistGroupsResponseBodyData> Data { get; set; }
        public class DescribeInnerIpWhitelistGroupsResponseBodyData : TeaModel {
            [NameInMap("CidrIpList")]
            [Validation(Required=false)]
            public List<string> CidrIpList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("InnerIpWhitelistGroupId")]
            [Validation(Required=false)]
            public string InnerIpWhitelistGroupId { get; set; }

        }

    }

}
