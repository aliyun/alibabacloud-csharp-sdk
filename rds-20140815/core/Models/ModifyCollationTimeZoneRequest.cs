// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCollationTimeZoneRequest : TeaModel {
        /// <summary>
        /// <para>The system character set collation. By default, the value is not modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Chinese_PRC_CI_AS</b></description></item>
        /// <item><description><b>Chinese_PRC_CS_AS</b></description></item>
        /// <item><description><b>Chinese_PRC_BIN</b></description></item>
        /// <item><description><b>Latin1_General_CI_AS</b></description></item>
        /// <item><description><b>Latin1_General_CS_AS</b></description></item>
        /// <item><description><b>SQL_Latin1_General_CP1_CI_AS</b></description></item>
        /// <item><description><b>SQL_Latin1_General_CP1_CS_AS</b></description></item>
        /// <item><description><b>Japanese_CI_AS</b></description></item>
        /// <item><description><b>Japanese_CS_AS</b></description></item>
        /// <item><description><b>Chinese_Taiwan_Stroke_CI_AS</b></description></item>
        /// <item><description><b>Chinese_Taiwan_Stroke_CS_AS</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The default character set collation of the instance is <b>Chinese_PRC_CI_AS</b>.</description></item>
        /// <item><description>You must specify at least one of <b>Collation</b> and <b>Timezone</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Chinese_PRC_CS_AS</para>
        /// </summary>
        [NameInMap("Collation")]
        [Validation(Required=false)]
        public string Collation { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp15qi0nd1u27****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The system time zone. By default, the value is not modified.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The default time zone of the instance is <b>China Standard Time</b>.</description></item>
        /// <item><description>You must specify at least one of <b>Collation</b> and <b>Timezone</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>China Standard Time</para>
        /// </summary>
        [NameInMap("Timezone")]
        [Validation(Required=false)]
        public string Timezone { get; set; }

    }

}
