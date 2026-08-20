// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20260603.Models
{
    public class GetModelDeploymentSpecRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cmu-biz</para>
        /// </summary>
        [NameInMap("BizKey")]
        [Validation(Required=false)]
        public string BizKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prf_5cd37a1c7eaa***c6829dbb02</para>
        /// </summary>
        [NameInMap("ProfileId")]
        [Validation(Required=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>%7B%22MemberType%22%3A%22Default%22%7D</para>
        /// </summary>
        [NameInMap("ResourceSelections")]
        [Validation(Required=false)]
        public string ResourceSelections { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>295949</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
