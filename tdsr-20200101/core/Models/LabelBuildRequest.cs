// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class LabelBuildRequest : TeaModel {
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PATCH</para>
        /// </summary>
        [NameInMap("ModelStyle")]
        [Validation(Required=false)]
        public string ModelStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OFF</para>
        /// </summary>
        [NameInMap("OptimizeWallWidth")]
        [Validation(Required=false)]
        public string OptimizeWallWidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("PlanStyle")]
        [Validation(Required=false)]
        public string PlanStyle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WallHeight")]
        [Validation(Required=false)]
        public long? WallHeight { get; set; }

    }

}
