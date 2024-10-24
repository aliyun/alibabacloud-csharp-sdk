// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAreaBlockConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the configurations of the Location Blacklist (Domain Names) policy.</para>
        /// </summary>
        [NameInMap("AreaBlockConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs> AreaBlockConfigs { get; set; }
        public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigs : TeaModel {
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
            /// <para>The configuration of the blocked locations.</para>
            /// </summary>
            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList> RegionList { get; set; }
            public class DescribeWebAreaBlockConfigsResponseBodyAreaBlockConfigsRegionList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the location is blocked. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: yes</description></item>
                /// <item><description><b>1</b>: no</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Block")]
                [Validation(Required=false)]
                public int? Block { get; set; }

                /// <summary>
                /// <para>The name of the location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN-SHANGHAI</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

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
