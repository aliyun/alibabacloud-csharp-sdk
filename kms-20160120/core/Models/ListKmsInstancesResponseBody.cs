// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKmsInstancesResponseBody : TeaModel {
        [NameInMap("KmsInstances")]
        [Validation(Required=false)]
        public ListKmsInstancesResponseBodyKmsInstances KmsInstances { get; set; }
        public class ListKmsInstancesResponseBodyKmsInstances : TeaModel {
            [NameInMap("KmsInstance")]
            [Validation(Required=false)]
            public List<ListKmsInstancesResponseBodyKmsInstancesKmsInstance> KmsInstance { get; set; }
            public class ListKmsInstancesResponseBodyKmsInstancesKmsInstance : TeaModel {
                [NameInMap("KmsInstanceArn")]
                [Validation(Required=false)]
                public string KmsInstanceArn { get; set; }

                [NameInMap("KmsInstanceId")]
                [Validation(Required=false)]
                public string KmsInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of KMS instances returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3eca5c8-a856-4347-8eb6-e1898c3fda2e</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of KMS instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
