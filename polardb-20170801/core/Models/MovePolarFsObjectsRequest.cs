// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class MovePolarFsObjectsRequest : TeaModel {
        [NameInMap("ObjectsToMove")]
        [Validation(Required=false)]
        public List<MovePolarFsObjectsRequestObjectsToMove> ObjectsToMove { get; set; }
        public class MovePolarFsObjectsRequestObjectsToMove : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>/test1</para>
            /// </summary>
            [NameInMap("DestinationPath")]
            [Validation(Required=false)]
            public string DestinationPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/test</para>
            /// </summary>
            [NameInMap("SourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pfs-test*****</para>
        /// </summary>
        [NameInMap("PolarFsInstanceId")]
        [Validation(Required=false)]
        public string PolarFsInstanceId { get; set; }

    }

}
