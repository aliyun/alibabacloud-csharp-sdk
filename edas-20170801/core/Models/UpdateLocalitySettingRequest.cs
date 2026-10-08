// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateLocalitySettingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You can call the <a href="https://help.aliyun.com/document_detail/149390.html">ListApplication</a> operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bfa00cfb-9642-4292-bb78-1d7d4c86004c</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether the setting is active:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The setting is active.</para>
        /// </description></item>
        /// <item><description><para>false: The setting is not active.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. This ID cannot be changed after the namespace is created. The format is [unk]physical space identifier[unk].</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the elastic compute unit (ECU) is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The total number of items that satisfy the threshold expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
