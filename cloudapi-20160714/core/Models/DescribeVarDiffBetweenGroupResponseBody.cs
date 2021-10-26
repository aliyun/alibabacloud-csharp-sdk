// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeVarDiffBetweenGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VariableDiffs")]
        [Validation(Required=false)]
        public DescribeVarDiffBetweenGroupResponseBodyVariableDiffs VariableDiffs { get; set; }
        public class DescribeVarDiffBetweenGroupResponseBodyVariableDiffs : TeaModel {
            [NameInMap("VariableDiff")]
            [Validation(Required=false)]
            public List<DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiff> VariableDiff { get; set; }
            public class DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiff : TeaModel {
                public string VarName { get; set; }
                public DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffTest Test { get; set; }
                public class DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffTest : TeaModel {
                    [NameInMap("DiffStatus")]
                    [Validation(Required=false)]
                    public string DiffStatus { get; set; }

                    [NameInMap("OldValue")]
                    [Validation(Required=false)]
                    public string OldValue { get; set; }

                    [NameInMap("NewValue")]
                    [Validation(Required=false)]
                    public string NewValue { get; set; }

                }
                public DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffPre Pre { get; set; }
                public class DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffPre : TeaModel {
                    [NameInMap("DiffStatus")]
                    [Validation(Required=false)]
                    public string DiffStatus { get; set; }

                    [NameInMap("OldValue")]
                    [Validation(Required=false)]
                    public string OldValue { get; set; }

                    [NameInMap("NewValue")]
                    [Validation(Required=false)]
                    public string NewValue { get; set; }

                }
                public DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffRelease Release { get; set; }
                public class DescribeVarDiffBetweenGroupResponseBodyVariableDiffsVariableDiffRelease : TeaModel {
                    [NameInMap("DiffStatus")]
                    [Validation(Required=false)]
                    public string DiffStatus { get; set; }

                    [NameInMap("OldValue")]
                    [Validation(Required=false)]
                    public string OldValue { get; set; }

                    [NameInMap("NewValue")]
                    [Validation(Required=false)]
                    public string NewValue { get; set; }

                }
            }
        };

    }

}
