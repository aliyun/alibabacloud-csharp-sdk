// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProgramTypeCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node types and quantity.</para>
        /// </summary>
        [NameInMap("ProgramTypeAndCounts")]
        [Validation(Required=false)]
        public List<ListProgramTypeCountResponseBodyProgramTypeAndCounts> ProgramTypeAndCounts { get; set; }
        public class ListProgramTypeCountResponseBodyProgramTypeAndCounts : TeaModel {
            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
