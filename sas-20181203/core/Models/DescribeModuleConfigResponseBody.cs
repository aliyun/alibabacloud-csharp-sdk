// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeModuleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of configurations for the module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>An array that consists of the configurations of the module.</para>
        /// </summary>
        [NameInMap("ModuleConfigList")]
        [Validation(Required=false)]
        public List<DescribeModuleConfigResponseBodyModuleConfigList> ModuleConfigList { get; set; }
        public class DescribeModuleConfigResponseBodyModuleConfigList : TeaModel {
            /// <summary>
            /// <para>The name of the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>timescan</para>
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <para>An array that consists of the configuration items.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<DescribeModuleConfigResponseBodyModuleConfigListItems> Items { get; set; }
            public class DescribeModuleConfigResponseBodyModuleConfigListItems : TeaModel {
                /// <summary>
                /// <para>The ID of the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>173</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public int? GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf6435dn4t59b9av****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>inStanceName****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The IP address of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31.13.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The region in which the server resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The UUID of the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a47e3713-ed22-4015-93a3-d88ebe6****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The name of the module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alihids</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E0618A9-D5EF-4220-9471-C42B5E92719F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
