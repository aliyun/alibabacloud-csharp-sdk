// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaiEciRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-test01</para>
        /// </summary>
        [NameInMap("EaisName")]
        [Validation(Required=false)]
        public string EaisName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eais.ei-a6.2xlarge</para>
        /// </summary>
        [NameInMap("EaisType")]
        [Validation(Required=false)]
        public string EaisType { get; set; }

        [NameInMap("Eci")]
        [Validation(Required=false)]
        public CreateEaiEciRequestEci Eci { get; set; }
        public class CreateEaiEciRequestEci : TeaModel {
            [NameInMap("Container")]
            [Validation(Required=false)]
            public CreateEaiEciRequestEciContainer Container { get; set; }
            public class CreateEaiEciRequestEciContainer : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sleep</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/eais=eais,/models=eais/models</para>
                /// </summary>
                [NameInMap("Volumes")]
                [Validation(Required=false)]
                public string Volumes { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eip-uf66jeqopgqa9hdn****</para>
            /// </summary>
            [NameInMap("EipId")]
            [Validation(Required=false)]
            public string EipId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test-nginx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.c5.xlarge</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>00c7****-rivj.cn-hangzhou.extreme.nas.aliyuncs.com:/share</para>
            /// </summary>
            [NameInMap("Volume")]
            [Validation(Required=false)]
            public string Volume { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-acfmvpuy4a5****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-uf66jeqopgqa9hdn****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6h3rbwbm90urjwa****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
