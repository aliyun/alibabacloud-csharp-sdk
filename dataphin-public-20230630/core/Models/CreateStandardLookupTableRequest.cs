// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateStandardLookupTableRequest : TeaModel {
        /// <summary>
        /// <para>The create command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateStandardLookupTableRequestCreateCommand CreateCommand { get; set; }
        public class CreateStandardLookupTableRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The code of the lookup table.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CITY</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The description of the lookup table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The directory to which the lookup table belongs.</para>
            /// </summary>
            [NameInMap("DirectoryReference")]
            [Validation(Required=false)]
            public CreateStandardLookupTableRequestCreateCommandDirectoryReference DirectoryReference { get; set; }
            public class CreateStandardLookupTableRequestCreateCommandDirectoryReference : TeaModel {
                /// <summary>
                /// <para>The directory to which the lookup table belongs.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/dir1/dir2</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

            }

            /// <summary>
            /// <para>The list of lookup table values.</para>
            /// </summary>
            [NameInMap("LookupTableValueList")]
            [Validation(Required=false)]
            public List<CreateStandardLookupTableRequestCreateCommandLookupTableValueList> LookupTableValueList { get; set; }
            public class CreateStandardLookupTableRequestCreateCommandLookupTableValueList : TeaModel {
                /// <summary>
                /// <para>The description of the code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The English name of the code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HZ</para>
                /// </summary>
                [NameInMap("EnglishName")]
                [Validation(Required=false)]
                public string EnglishName { get; set; }

                /// <summary>
                /// <para>The code name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The code value.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The name of the lookup table.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>城市码表</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the lookup table owner. Default value: the user ID of the caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012021</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
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
