// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKmsInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of KMS instances.</para>
        /// </summary>
        [NameInMap("KmsInstances")]
        [Validation(Required=false)]
        public ListKmsInstancesResponseBodyKmsInstances KmsInstances { get; set; }
        public class ListKmsInstancesResponseBodyKmsInstances : TeaModel {
            [NameInMap("KmsInstance")]
            [Validation(Required=false)]
            public List<ListKmsInstancesResponseBodyKmsInstancesKmsInstance> KmsInstance { get; set; }
            public class ListKmsInstancesResponseBodyKmsInstancesKmsInstance : TeaModel {
                /// <summary>
                /// <para>The ARN of the KMS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:kms:pre-hangzhou:120708975881****:keystore/kst-phzz64c9f84eo32dbs****</para>
                /// </summary>
                [NameInMap("KmsInstanceArn")]
                [Validation(Required=false)]
                public string KmsInstanceArn { get; set; }

                /// <summary>
                /// <para>The ID of the KMS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kst-phzz64c9f84eo32dbs****</para>
                /// </summary>
                [NameInMap("KmsInstanceId")]
                [Validation(Required=false)]
                public string KmsInstanceId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
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
