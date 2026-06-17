// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeIspInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of ISPs.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeIspInfoResponseBodyDataList> DataList { get; set; }
        public class DescribeIspInfoResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The ID of the ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>isp-dhyw2lxfpc****</para>
            /// </summary>
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public int? IspId { get; set; }

            /// <summary>
            /// <para>The name of the ISP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>telecom</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
