// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateOriginPoolRequest : TeaModel {
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UpdateOriginPool</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Origins")]
        [Validation(Required=false)]
        public List<UpdateOriginPoolRequestOrigins> Origins { get; set; }
        public class UpdateOriginPoolRequestOrigins : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AuthConf")]
            [Validation(Required=false)]
            public UpdateOriginPoolRequestOriginsAuthConf AuthConf { get; set; }
            public class UpdateOriginPoolRequestOriginsAuthConf : TeaModel {
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                [NameInMap("AuthType")]
                [Validation(Required=false)]
                public string AuthType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SecretKey")]
                [Validation(Required=false)]
                public string SecretKey { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Header")]
            [Validation(Required=false)]
            public object Header { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
