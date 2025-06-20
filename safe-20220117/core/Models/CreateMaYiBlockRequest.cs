// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class CreateMaYiBlockRequest : TeaModel {
        [NameInMap("BlockId")]
        [Validation(Required=false)]
        public string BlockId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BlockTimes")]
        [Validation(Required=false)]
        public List<CreateMaYiBlockRequestBlockTimes> BlockTimes { get; set; }
        public class CreateMaYiBlockRequestBlockTimes : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BlockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreatorEmpId")]
        [Validation(Required=false)]
        public string CreatorEmpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Director")]
        [Validation(Required=false)]
        public List<string> Director { get; set; }

        [NameInMap("FaultVersion")]
        [Validation(Required=false)]
        public string FaultVersion { get; set; }

        [NameInMap("Information")]
        [Validation(Required=false)]
        public List<string> Information { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public CreateMaYiBlockRequestScope Scope { get; set; }
        public class CreateMaYiBlockRequestScope : TeaModel {
            [NameInMap("GroupBlockScopeParams")]
            [Validation(Required=false)]
            public List<CreateMaYiBlockRequestScopeGroupBlockScopeParams> GroupBlockScopeParams { get; set; }
            public class CreateMaYiBlockRequestScopeGroupBlockScopeParams : TeaModel {
                [NameInMap("Az")]
                [Validation(Required=false)]
                public string Az { get; set; }

                [NameInMap("Idc")]
                [Validation(Required=false)]
                public string Idc { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
