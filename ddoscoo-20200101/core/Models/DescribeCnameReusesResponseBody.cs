// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeCnameReusesResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME reuse information.</para>
        /// </summary>
        [NameInMap("CnameReuses")]
        [Validation(Required=false)]
        public List<DescribeCnameReusesResponseBodyCnameReuses> CnameReuses { get; set; }
        public class DescribeCnameReusesResponseBodyCnameReuses : TeaModel {
            /// <summary>
            /// <para>The reused canonical name value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4o6ep6q217k9****.aliyunddos0004.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether CNAME reuse is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: disabled</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bcf28g5-d57c-11e7-9bs0-d89d6717dxbc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
