// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprints. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>port</b>: port</description></item>
        /// <item><description><b>process</b>: process</description></item>
        /// <item><description><b>software</b>: software</description></item>
        /// <item><description><b>user</b>: account</description></item>
        /// <item><description><b>cron</b>: scheduled task</description></item>
        /// <item><description><b>sca</b>: middleware</description></item>
        /// <item><description><b>web</b>: website</description></item>
        /// <item><description><b>database</b>: database</description></item>
        /// <item><description><b>lkm</b>: kernel module</description></item>
        /// <item><description><b>autorun</b>: startup item</description></item>
        /// <item><description><b>web_server</b>: web service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>port,process</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the assets. Separate multiple UUIDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>9658314a-7609-4426-afc4-2c924072****,
        /// 9658314a-7609-4426-afc4-2c924072****</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
