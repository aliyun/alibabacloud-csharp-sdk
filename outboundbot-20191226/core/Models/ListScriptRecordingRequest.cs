// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListScriptRecordingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c209abb3-6804-4a75-b2c7-dd55c8c61b6a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RefIdsJson")]
        [Validation(Required=false)]
        public string RefIdsJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d004cfd2-6a81-491c-83c6-cbe186620c95</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public string Search { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[
        ///      &quot;8&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("StatesJson")]
        [Validation(Required=false)]
        public string StatesJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;d17d5bfa-4972-4389-9718-f9602edabe48&quot;]</para>
        /// </summary>
        [NameInMap("UuidsJson")]
        [Validation(Required=false)]
        public string UuidsJson { get; set; }

    }

}
