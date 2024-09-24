// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLogMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The data of a data shipping task.</para>
        /// </summary>
        [NameInMap("LogMeta")]
        [Validation(Required=false)]
        public GetLogMetaResponseBodyLogMeta LogMeta { get; set; }
        public class GetLogMetaResponseBodyLogMeta : TeaModel {
            /// <summary>
            /// <para>The name of the dedicated Logstore in which logs are stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis-log-login</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The Simple Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-log</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The status of a data shipping task of a log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enabled</b></description></item>
            /// <item><description><b>disabled</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
