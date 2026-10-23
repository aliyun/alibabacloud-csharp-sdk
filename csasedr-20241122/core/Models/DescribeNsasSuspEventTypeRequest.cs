// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeNsasSuspEventTypeRequest : TeaModel {
        /// <summary>
        /// <para>The container field. This parameter is not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container field. This parameter is not supported by SASE-EDR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3108551c83c4d949106e1ab9e1e****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The language of the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the security alert type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Unusual Logon</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testECS</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180.212.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>f56406cb-916d-42db-b6f7-2ff79e34****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
