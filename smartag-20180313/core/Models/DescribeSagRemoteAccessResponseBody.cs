// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRemoteAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. The 200 error code indicates that the query task is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. The Successful error message indicates that the query task is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RemoteAccesses")]
        [Validation(Required=false)]
        public DescribeSagRemoteAccessResponseBodyRemoteAccesses RemoteAccesses { get; set; }
        public class DescribeSagRemoteAccessResponseBodyRemoteAccesses : TeaModel {
            [NameInMap("RemoteAccess")]
            [Validation(Required=false)]
            public List<DescribeSagRemoteAccessResponseBodyRemoteAccessesRemoteAccess> RemoteAccess { get; set; }
            public class DescribeSagRemoteAccessResponseBodyRemoteAccessesRemoteAccess : TeaModel {
                [NameInMap("RemoteAccessIp")]
                [Validation(Required=false)]
                public string RemoteAccessIp { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E38E950D-28A4-4C41-9428-A8908EC6AE5C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-1um5x5nwhilymw****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>Indicates whether the query task is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The query task is successful.</description></item>
        /// <item><description><b>false</b>: The query task failed.</description></item>
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
