// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ColdStartRankRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eg: k1:v1|k2:v2|k3:v1,v2,v3</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public string Features { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abfsc</para>
        /// </summary>
        [NameInMap("imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16240:video</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public string Items { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sceneId</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
