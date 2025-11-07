// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeAntAndCloudAuthUserStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether financial-grade real-person authentication is activated. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Activated</description></item>
        /// <item><description><b>false</b>: Not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AntcloudauthEnabled")]
        [Validation(Required=false)]
        public bool? AntcloudauthEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether real-person authentication is activated. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Activated</description></item>
        /// <item><description><b>false</b>: Not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CloudauthEnabled")]
        [Validation(Required=false)]
        public bool? CloudauthEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether the enhanced version of real-person authentication is activated. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Activated</description></item>
        /// <item><description><b>false</b>: Not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CloudauthstEnabled")]
        [Validation(Required=false)]
        public bool? CloudauthstEnabled { get; set; }

        /// <summary>
        /// <para>Indicates whether information verification is activated. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Activated</description></item>
        /// <item><description><b>false</b>: Not activated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InforverifyEnabled")]
        [Validation(Required=false)]
        public bool? InforverifyEnabled { get; set; }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE07CCE-DF47-51C2-9D32-CD70ED62C91B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
