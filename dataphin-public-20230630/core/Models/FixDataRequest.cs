// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class FixDataRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("FixDataCommand")]
        [Validation(Required=false)]
        public FixDataRequestFixDataCommand FixDataCommand { get; set; }
        public class FixDataRequestFixDataCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainRootInstance")]
            [Validation(Required=false)]
            public bool? ContainRootInstance { get; set; }

            [NameInMap("DownStreamInstanceIdList")]
            [Validation(Required=false)]
            public List<FixDataRequestFixDataCommandDownStreamInstanceIdList> DownStreamInstanceIdList { get; set; }
            public class FixDataRequestFixDataCommandDownStreamInstanceIdList : TeaModel {
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t_2323421</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL_INSTANCE</para>
            /// </summary>
            [NameInMap("DownstreamRange")]
            [Validation(Required=false)]
            public string DownstreamRange { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceRerun")]
            [Validation(Required=false)]
            public bool? ForceRerun { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132344</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RootInstanceId")]
            [Validation(Required=false)]
            public FixDataRequestFixDataCommandRootInstanceId RootInstanceId { get; set; }
            public class FixDataRequestFixDataCommandRootInstanceId : TeaModel {
                [NameInMap("FieldInstanceIdList")]
                [Validation(Required=false)]
                public List<string> FieldInstanceIdList { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_2323111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
