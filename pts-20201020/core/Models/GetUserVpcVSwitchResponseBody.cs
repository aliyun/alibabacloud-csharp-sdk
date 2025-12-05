// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetUserVpcVSwitchResponseBody : TeaModel {
        /// <summary>
        /// <para>The system status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The returned message. If the request was successful, this parameter is left empty.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of returned entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0235E5FC-4C7C-5F0C-843C-FC674F15F947</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("VSwitchCount")]
        [Validation(Required=false)]
        public int? VSwitchCount { get; set; }

        /// <summary>
        /// <para>The vSwitches.</para>
        /// </summary>
        [NameInMap("VSwitchList")]
        [Validation(Required=false)]
        public List<GetUserVpcVSwitchResponseBodyVSwitchList> VSwitchList { get; set; }
        public class GetUserVpcVSwitchResponseBodyVSwitchList : TeaModel {
            /// <summary>
            /// <para>The number of available IP addresses in the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("AvailableIpAddressCount")]
            [Validation(Required=false)]
            public long? AvailableIpAddressCount { get; set; }

            /// <summary>
            /// <para>The maximum number of stress testers to be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxAgentCount")]
            [Validation(Required=false)]
            public int? MaxAgentCount { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1eil9df23rsd8l1sevebiszooj</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The vSwitch name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-vswitch</para>
            /// </summary>
            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9bpdaebft6j23fesdf84v2f1um3a</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
