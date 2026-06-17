// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeApplicationServerlessConfResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CDB3258F-B5DE-43C4-8935-CBA0CA******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of serverless configurations.</para>
        /// </summary>
        [NameInMap("ServerlessConfItems")]
        [Validation(Required=false)]
        public List<DescribeApplicationServerlessConfResponseBodyServerlessConfItems> ServerlessConfItems { get; set; }
        public class DescribeApplicationServerlessConfResponseBodyServerlessConfItems : TeaModel {
            /// <summary>
            /// <para>The type of the application sub-component.</para>
            /// <para>For Supabase, valid values are:</para>
            /// <list type="bullet">
            /// <item><description><para>gateway</para>
            /// </description></item>
            /// <item><description><para>backend</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>gateway</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            /// <summary>
            /// <para>The maximum scaling capacity for a single node. Valid values: 0 PCU to 16 PCU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum scaling capacity for a single node, measured in PolarDB Capacity Units (PCU). Valid values: 0 PCU to 16 PCU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScaleMin")]
            [Validation(Required=false)]
            public string ScaleMin { get; set; }

        }

    }

}
