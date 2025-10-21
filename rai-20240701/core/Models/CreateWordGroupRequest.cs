// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class CreateWordGroupRequest : TeaModel {
        /// <summary>
        /// <para>Request object</para>
        /// </summary>
        [NameInMap("BodyData")]
        [Validation(Required=false)]
        public CreateWordGroupRequestBodyData BodyData { get; set; }
        public class CreateWordGroupRequestBodyData : TeaModel {
            /// <summary>
            /// <para>Keyword group list</para>
            /// </summary>
            [NameInMap("WordInfoList")]
            [Validation(Required=false)]
            public List<CreateWordGroupRequestBodyDataWordInfoList> WordInfoList { get; set; }
            public class CreateWordGroupRequestBodyDataWordInfoList : TeaModel {
                /// <summary>
                /// <para>Label</para>
                /// 
                /// <b>Example:</b>
                /// <para>Buss.</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Keyword</para>
                /// 
                /// <b>Example:</b>
                /// <para>Inv.</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <para>Whether to commit.
        /// false: Not actually saved, only checked
        /// true: Commit and save</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Commit")]
        [Validation(Required=false)]
        public bool? Commit { get; set; }

        /// <summary>
        /// <para>Keyword group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>643168</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public long? WorkspaceId { get; set; }

    }

}
