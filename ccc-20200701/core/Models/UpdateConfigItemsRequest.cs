// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateConfigItemsRequest : TeaModel {
        /// <summary>
        /// <para>A JSON-formatted string representing an array of configuration items. Each object in the array must contain a name to identify the configuration item and its value. You can use system-defined items (which have fixed names and customizable values, such as agent permissions to hang up or the ring no answer timeout) or create custom items.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;ShowCalledID&quot;,&quot;value&quot;:&quot;-1&quot;},{&quot;name&quot;:&quot;ShowCalleeID&quot;,&quot;value&quot;:&quot;1&quot;},{&quot;name&quot;:&quot;AllowHangup&quot;,&quot;value&quot;:&quot;0&quot;},{&quot;name&quot;:&quot;AutoAnswerCall&quot;,&quot;value&quot;:&quot;-1&quot;},{&quot;name&quot;:&quot;AllowAudioDownload&quot;,&quot;value&quot;:&quot;1&quot;},{&quot;name&quot;:&quot;AllowChooseSignedSkillGroup&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ConfigItems")]
        [Validation(Required=false)]
        public string ConfigItems { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the object to be configured.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The type of the object to be configured.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

    }

}
