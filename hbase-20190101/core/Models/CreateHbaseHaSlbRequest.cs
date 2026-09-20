// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class CreateHbaseHaSlbRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the BDS cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bds-t4n3496whj23****</para>
        /// </summary>
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The value cannot exceed 64 printable ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The high-availability ID in the BDS active-active management.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-v21tmnxjwh2yu****</para>
        /// </summary>
        [NameInMap("HaId")]
        [Validation(Required=false)]
        public string HaId { get; set; }

        /// <summary>
        /// <para>The high-availability type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>thrift</description></item>
        /// <item><description>phoenix.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thrift</para>
        /// </summary>
        [NameInMap("HaTypes")]
        [Validation(Required=false)]
        public string HaTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether the high-availability type is on the primary or secondary instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active: The high-availability type is on the primary instance.</description></item>
        /// <item><description>Standby: The high-availability type is on the secondary instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("HbaseType")]
        [Validation(Required=false)]
        public string HbaseType { get; set; }

    }

}
