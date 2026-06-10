// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyTagGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cd560e89-0459-4c8a-ad98-47d713e4abd6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365b955d-6f4d-4ab5-a6e1-9a301307f4b1</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The tag groups to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagName&quot;:&quot;111&quot;,&quot;TagGroup&quot;:&quot;多层次&quot;,&quot;ScriptId&quot;:&quot;b4d0dcc8-892d-4323-8c9d-3568e5faa62f&quot;,&quot;showInput&quot;:true,&quot;Id&quot;:&quot;a683fa32-91c5-457e-9ddf-aa8549d14ce0&quot;}]</para>
        /// </summary>
        [NameInMap("TagGroups")]
        [Validation(Required=false)]
        public string TagGroups { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagGroup&quot;:&quot;多层次&quot;,&quot;ScriptId&quot;:&quot;b4d0dcc8-892d-43234-987c9d-3568e5faa62f&quot;,&quot;TagGroupIndex&quot;:0,&quot;Id&quot;:&quot;56728a30-c392-453a-a287-31af8301150f&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
