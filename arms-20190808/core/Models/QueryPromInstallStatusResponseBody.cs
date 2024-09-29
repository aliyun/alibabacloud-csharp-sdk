// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryPromInstallStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryPromInstallStatusResponseBodyData Data { get; set; }
        public class QueryPromInstallStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the call was successful. Valid values:</para>
            /// <para>true: The call was successful. false: The call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isControllerInstalled")]
            [Validation(Required=false)]
            public bool? IsControllerInstalled { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27E653FA-5958-45BE-8AA9-14D884DC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
