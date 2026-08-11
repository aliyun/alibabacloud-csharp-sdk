// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class UpdateModelPermissionsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OPEN</para>
        /// </summary>
        [NameInMap("accessAllEntities")]
        [Validation(Required=false)]
        public string AccessAllEntities { get; set; }

        [NameInMap("models")]
        [Validation(Required=false)]
        public List<UpdateModelPermissionsRequestModels> Models { get; set; }
        public class UpdateModelPermissionsRequestModels : TeaModel {
            [NameInMap("deploy")]
            [Validation(Required=false)]
            public bool? Deploy { get; set; }

            [NameInMap("fineTune")]
            [Validation(Required=false)]
            public bool? FineTune { get; set; }

            [NameInMap("inference")]
            [Validation(Required=false)]
            public bool? Inference { get; set; }

            /// <summary>
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
