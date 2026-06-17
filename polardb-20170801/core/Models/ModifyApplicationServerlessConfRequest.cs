// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationServerlessConfRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The list of Serverless configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ServerlessConfList")]
        [Validation(Required=false)]
        public List<ModifyApplicationServerlessConfRequestServerlessConfList> ServerlessConfList { get; set; }
        public class ModifyApplicationServerlessConfRequestServerlessConfList : TeaModel {
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
            /// <para>The maximum number of PCUs for a single node. Valid values: 0 to 16.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("ScaleMax")]
            [Validation(Required=false)]
            public string ScaleMax { get; set; }

            /// <summary>
            /// <para>The minimum number of PolarDB Capacity Units (PCUs) for a single node. Valid values: 0 to 16.</para>
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
