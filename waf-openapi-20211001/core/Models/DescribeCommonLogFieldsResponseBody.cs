// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCommonLogFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log fields returned.</para>
        /// </summary>
        [NameInMap("LogFieldList")]
        [Validation(Required=false)]
        public List<DescribeCommonLogFieldsResponseBodyLogFieldList> LogFieldList { get; set; }
        public class DescribeCommonLogFieldsResponseBodyLogFieldList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the log field is a default field.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The log field is a default field.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The log field is not a default field.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>Indicates whether the log field is required.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The log field is required.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The log field is not required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <para>The name of the log field.</para>
            /// <remarks>
            /// <para>For more information about the log fields, see <a href="https://help.aliyun.com/zh/waf/web-application-firewall-3-0/user-guide/fields-in-logs?spm=openapi-amp.newDocPublishment.0.0.ccef281fNAb0XR"><b>Log field descriptions</b></a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>final_action</para>
            /// </summary>
            [NameInMap("LogKey")]
            [Validation(Required=false)]
            public string LogKey { get; set; }

            /// <summary>
            /// <para>The status of the log field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: offline.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: online or in use.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: about to be unpublished.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: about to be published.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB0775EB-2594-598A-97E1-51B1*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of log fields returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
