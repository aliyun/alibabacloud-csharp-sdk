// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreatePADiagnosisTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2987b3e0-8108-2f99-4d18-3b4f1c1c36d7</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FullLink</para>
        /// </summary>
        [NameInMap("DiagnoseType")]
        [Validation(Required=false)]
        public string DiagnoseType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>socialapp-gateway.client9.me</para>
        /// </summary>
        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pop-3e244b62357dcafc</para>
        /// </summary>
        [NameInMap("PopId")]
        [Validation(Required=false)]
        public string PopId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManualSelect</para>
        /// </summary>
        [NameInMap("PopMode")]
        [Validation(Required=false)]
        public string PopMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("UdpExtraConfigs")]
        [Validation(Required=false)]
        public string UdpExtraConfigsShrink { get; set; }

        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Zhaosi</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
