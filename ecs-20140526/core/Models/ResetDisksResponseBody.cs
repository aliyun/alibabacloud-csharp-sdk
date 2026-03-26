// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ResetDisksResponseBody : TeaModel {
        [NameInMap("OperationProgressSet")]
        [Validation(Required=false)]
        public ResetDisksResponseBodyOperationProgressSet OperationProgressSet { get; set; }
        public class ResetDisksResponseBodyOperationProgressSet : TeaModel {
            [NameInMap("OperationProgress")]
            [Validation(Required=false)]
            public List<ResetDisksResponseBodyOperationProgressSetOperationProgress> OperationProgress { get; set; }
            public class ResetDisksResponseBodyOperationProgressSetOperationProgress : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("OperationStatus")]
                [Validation(Required=false)]
                public string OperationStatus { get; set; }

                [NameInMap("RelatedItemSet")]
                [Validation(Required=false)]
                public ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet RelatedItemSet { get; set; }
                public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSet : TeaModel {
                    [NameInMap("RelatedItem")]
                    [Validation(Required=false)]
                    public List<ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem> RelatedItem { get; set; }
                    public class ResetDisksResponseBodyOperationProgressSetOperationProgressRelatedItemSetRelatedItem : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D66C85C-AA97-4A00-B0ED-2D9A80FE782C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
