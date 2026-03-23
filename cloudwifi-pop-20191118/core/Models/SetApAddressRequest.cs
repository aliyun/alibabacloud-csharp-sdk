// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class SetApAddressRequest : TeaModel {
        [NameInMap("ApAreaName")]
        [Validation(Required=false)]
        public string ApAreaName { get; set; }

        [NameInMap("ApBuildingName")]
        [Validation(Required=false)]
        public string ApBuildingName { get; set; }

        [NameInMap("ApCampusName")]
        [Validation(Required=false)]
        public string ApCampusName { get; set; }

        [NameInMap("ApCityName")]
        [Validation(Required=false)]
        public string ApCityName { get; set; }

        [NameInMap("ApFloor")]
        [Validation(Required=false)]
        public string ApFloor { get; set; }

        [NameInMap("ApGroup")]
        [Validation(Required=false)]
        public string ApGroup { get; set; }

        [NameInMap("ApName")]
        [Validation(Required=false)]
        public string ApName { get; set; }

        [NameInMap("ApNationName")]
        [Validation(Required=false)]
        public string ApNationName { get; set; }

        [NameInMap("ApProvinceName")]
        [Validation(Required=false)]
        public string ApProvinceName { get; set; }

        [NameInMap("ApUnitId")]
        [Validation(Required=false)]
        public long? ApUnitId { get; set; }

        [NameInMap("ApUnitName")]
        [Validation(Required=false)]
        public string ApUnitName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Lat")]
        [Validation(Required=false)]
        public string Lat { get; set; }

        [NameInMap("Lng")]
        [Validation(Required=false)]
        public string Lng { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

    }

}
