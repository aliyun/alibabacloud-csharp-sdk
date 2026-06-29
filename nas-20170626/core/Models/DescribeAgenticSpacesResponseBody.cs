// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAgenticSpacesResponseBody : TeaModel {
        [NameInMap("AgenticSpaces")]
        [Validation(Required=false)]
        public DescribeAgenticSpacesResponseBodyAgenticSpaces AgenticSpaces { get; set; }
        public class DescribeAgenticSpacesResponseBodyAgenticSpaces : TeaModel {
            [NameInMap("AgenticSpace")]
            [Validation(Required=false)]
            public List<DescribeAgenticSpacesResponseBodyAgenticSpacesAgenticSpace> AgenticSpace { get; set; }
            public class DescribeAgenticSpacesResponseBodyAgenticSpacesAgenticSpace : TeaModel {
                [NameInMap("AgenticSpaceId")]
                [Validation(Required=false)]
                public string AgenticSpaceId { get; set; }

                [NameInMap("Azone")]
                [Validation(Required=false)]
                public string Azone { get; set; }

                [NameInMap("CreateTimeUtc")]
                [Validation(Required=false)]
                public string CreateTimeUtc { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FileCountUsage")]
                [Validation(Required=false)]
                public long? FileCountUsage { get; set; }

                [NameInMap("FileSystemId")]
                [Validation(Required=false)]
                public string FileSystemId { get; set; }

                [NameInMap("FileSystemPath")]
                [Validation(Required=false)]
                public string FileSystemPath { get; set; }

                [NameInMap("Quota")]
                [Validation(Required=false)]
                public DescribeAgenticSpacesResponseBodyAgenticSpacesAgenticSpaceQuota Quota { get; set; }
                public class DescribeAgenticSpacesResponseBodyAgenticSpacesAgenticSpaceQuota : TeaModel {
                    [NameInMap("FileCountLimit")]
                    [Validation(Required=false)]
                    public long? FileCountLimit { get; set; }

                    [NameInMap("SizeLimit")]
                    [Validation(Required=false)]
                    public long? SizeLimit { get; set; }

                }

                [NameInMap("SpaceUsage")]
                [Validation(Required=false)]
                public long? SpaceUsage { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTimeUtc")]
                [Validation(Required=false)]
                public string UpdateTimeUtc { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MTc2NTg1MTUyMzA1OTczNTc1OCM0NjQxMzQ****=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BC7C825C-5F65-4B56-BEF6-98C56C7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
