// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateModelPermissionsRequest : TeaModel {
        /// <summary>
        /// <para>The tri-state value for one-click authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: grants authorization to all models with one click.</description></item>
        /// <item><description>CLOSE: cancels one-click authorization.</description></item>
        /// <item><description>KEEP: keeps per-model authorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("accessAllEntities")]
        [Validation(Required=false)]
        public string AccessAllEntities { get; set; }

        /// <summary>
        /// <para>The list of per-model authorization items.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<UpdateModelPermissionsRequestModels> Models { get; set; }
        public class UpdateModelPermissionsRequestModels : TeaModel {
            /// <summary>
            /// <para>Specifies whether to grant model deployment permission.</para>
            /// </summary>
            [NameInMap("deploy")]
            [Validation(Required=false)]
            public bool? Deploy { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant model training permission.</para>
            /// </summary>
            [NameInMap("fineTune")]
            [Validation(Required=false)]
            public bool? FineTune { get; set; }

            /// <summary>
            /// <para>Specifies whether to grant model invocation permission.</para>
            /// </summary>
            [NameInMap("inference")]
            [Validation(Required=false)]
            public bool? Inference { get; set; }

            /// <summary>
            /// <para>The model.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-32klhjk2312334jkh</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
