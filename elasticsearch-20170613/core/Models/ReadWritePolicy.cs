// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ReadWritePolicy : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically generate a document hash primary key when no primary key exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): automatically generates a primary key.</description></item>
        /// <item><description>false: does not automatically generate a primary key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice:  autoGeneratePk cannot be modified independently. The autoGeneratePk setting takes effect only when writeHa is changed from false to true.
        /// .</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoGeneratePk")]
        [Validation(Required=false)]
        public bool? AutoGeneratePk { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the write high-availability feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("writeHa")]
        [Validation(Required=false)]
        public bool? WriteHa { get; set; }

        /// <summary>
        /// <para>Temporarily switches between synchronous and asynchronous high availability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sync: temporarily switches from asynchronous write high availability to synchronous write.</description></item>
        /// <item><description>async: restores asynchronous write high availability after synchronous write is temporarily enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This field takes effect only when high availability is enabled, that is, writeHa is set to true. You do not need to pass in the writeHa field when setting this field.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sync</para>
        /// </summary>
        [NameInMap("writePolicy")]
        [Validation(Required=false)]
        public string WritePolicy { get; set; }

    }

}
