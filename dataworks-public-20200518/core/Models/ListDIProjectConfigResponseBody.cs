// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIProjectConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the query.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDIProjectConfigResponseBodyData Data { get; set; }
        public class ListDIProjectConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The default global configuration of synchronization solutions. The value indicates the processing rules of different types of DDL messages. Example: {&quot;RENAMECOLUMN&quot;:&quot;WARNING&quot;,&quot;DROPTABLE&quot;:&quot;WARNING&quot;,&quot;CREATETABLE&quot;:&quot;WARNING&quot;,&quot;MODIFYCOLUMN&quot;:&quot;WARNING&quot;,&quot;TRUNCATETABLE&quot;:&quot;WARNING&quot;,&quot;DROPCOLUMN&quot;:&quot;WARNING&quot;,&quot;ADDCOLUMN&quot;:&quot;WARNING&quot;,&quot;RENAMETABLE&quot;:&quot;WARNING&quot;}</para>
            /// <para>Field description:</para>
            /// <list type="bullet">
            /// <item><description>RENAMECOLUMN: renames a column.</description></item>
            /// <item><description>DROPTABLE: deletes a table.</description></item>
            /// <item><description>CREATETABLE: creates a table.</description></item>
            /// <item><description>MODIFYCOLUMN: changes the data type of a column.</description></item>
            /// <item><description>TRUNCATETABLE: clears a table.</description></item>
            /// <item><description>DROPCOLUMN: deletes a column.</description></item>
            /// <item><description>ADDCOLUMN: creates a column.</description></item>
            /// <item><description>RENAMETABLE: renames a table.</description></item>
            /// </list>
            /// <para>DataWorks processes a DDL message of a specific type based on the following rules:</para>
            /// <list type="bullet">
            /// <item><description>WARNING: ignores the message and records an alert in real-time synchronization logs. The alert contains information about the situation that the message is ignored because of an execution error.</description></item>
            /// <item><description>IGNORE: discards the message and does not send it to the destination.</description></item>
            /// <item><description>CRITICAL: terminates the real-time synchronization node and sets the node status to Failed.</description></item>
            /// <item><description>NORMAL: sends the message to the destination to process the message. Each destination processes DDL messages based on its own business logic. If DataWorks adopts the NORMAL policy, DataWorks only forwards DDL messages.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;RENAMECOLUMN&quot;:&quot;WARNING&quot;,&quot;DROPTABLE&quot;:&quot;WARNING&quot;,&quot;CREATETABLE&quot;:&quot;WARNING&quot;,&quot;MODIFYCOLUMN&quot;:&quot;WARNING&quot;,&quot;TRUNCATETABLE&quot;:&quot;WARNING&quot;,&quot;DROPCOLUMN&quot;:&quot;WARNING&quot;,&quot;ADDCOLUMN&quot;:&quot;WARNING&quot;,&quot;RENAMETABLE&quot;:&quot;WARNING&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
