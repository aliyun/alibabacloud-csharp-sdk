// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradePolarClawPluginResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>@larksuite/<a href="mailto:openclaw-lark@2026.4.7">openclaw-lark@2026.4.7</a></para>
        /// </summary>
        [NameInMap("NpmPackage")]
        [Validation(Required=false)]
        public string NpmPackage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ok")]
        [Validation(Required=false)]
        public bool? Ok { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>openclaw-lark</para>
        /// </summary>
        [NameInMap("PluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E2FE3BB-C677-5FF9-9FC5-9CF364BD6BE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Restarted")]
        [Validation(Required=false)]
        public bool? Restarted { get; set; }

    }

}
