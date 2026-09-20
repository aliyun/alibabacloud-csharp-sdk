// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DesensitizeDataRequest : TeaModel {
        /// <summary>
        /// <para>The input data to be masked.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15365291784</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The masking scene code. You can view this on the Data Masking Management page of DataWorks Data Protection Umbrella in the DataWorks console.</para>
        /// <para>You can obtain this value from Data[].SceneCode in the response of DsgSceneQuerySceneListByName.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>_default_scene_code</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
