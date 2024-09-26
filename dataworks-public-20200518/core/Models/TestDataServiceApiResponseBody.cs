// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestDataServiceApiResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the test.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestDataServiceApiResponseBodyData Data { get; set; }
        public class TestDataServiceApiResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the test.</para>
            /// 
            /// <b>Example:</b>
            /// <para>232432</para>
            /// </summary>
            [NameInMap("TestId")]
            [Validation(Required=false)]
            public string TestId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abdsfewe</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
