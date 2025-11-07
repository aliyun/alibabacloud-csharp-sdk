// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeMetaSearchPageListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeMetaSearchPageListResponseBodyItems> Items { get; set; }
        public class DescribeMetaSearchPageListResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ID_CARD_2_META</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6214837145546986</para>
            /// </summary>
            [NameInMap("BankCard")]
            [Validation(Required=false)]
            public string BankCard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-10-17 10:00:11</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4****************X</para>
            /// </summary>
            [NameInMap("IdentifyNum")]
            [Validation(Required=false)]
            public string IdentifyNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUCC</para>
            /// </summary>
            [NameInMap("IspName")]
            [Validation(Required=false)]
            public string IspName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1500000xxxx</para>
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public DescribeMetaSearchPageListResponseBodyItemsRequest Request { get; set; }
            public class DescribeMetaSearchPageListResponseBodyItemsRequest : TeaModel {
                [NameInMap("VehicleNum")]
                [Validation(Required=false)]
                public string VehicleNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>52</para>
                /// </summary>
                [NameInMap("VehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

                [NameInMap("VehicleTypeName")]
                [Validation(Required=false)]
                public string VehicleTypeName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>B0102BEF-4411-57C3-860D-CFE7DE0A64C0</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("RequestJson")]
            [Validation(Required=false)]
            public string RequestJson { get; set; }

            [NameInMap("Response")]
            [Validation(Required=false)]
            public DescribeMetaSearchPageListResponseBodyItemsResponse Response { get; set; }
            public class DescribeMetaSearchPageListResponseBodyItemsResponse : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public DescribeMetaSearchPageListResponseBodyItemsResponseData Data { get; set; }
                public class DescribeMetaSearchPageListResponseBodyItemsResponseData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ApprovedCount")]
                    [Validation(Required=false)]
                    public string ApprovedCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ApprovedLoad")]
                    [Validation(Required=false)]
                    public string ApprovedLoad { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AxleCount")]
                    [Validation(Required=false)]
                    public string AxleCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1630</para>
                    /// </summary>
                    [NameInMap("BackWheelDistance")]
                    [Validation(Required=false)]
                    public string BackWheelDistance { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>622848001714440xxxx</para>
                    /// </summary>
                    [NameInMap("BankCard")]
                    [Validation(Required=false)]
                    public string BankCard { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("BizCode")]
                    [Validation(Required=false)]
                    public string BizCode { get; set; }

                    [NameInMap("Brand")]
                    [Validation(Required=false)]
                    public string Brand { get; set; }

                    [NameInMap("Color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Displacement")]
                    [Validation(Required=false)]
                    public string Displacement { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>N7YJ113PA</para>
                    /// </summary>
                    [NameInMap("EngineNum")]
                    [Validation(Required=false)]
                    public string EngineNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CA6GV30TD</para>
                    /// </summary>
                    [NameInMap("EngineType")]
                    [Validation(Required=false)]
                    public string EngineType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1630</para>
                    /// </summary>
                    [NameInMap("FrontWheelDistance")]
                    [Validation(Required=false)]
                    public string FrontWheelDistance { get; set; }

                    [NameInMap("FuelType")]
                    [Validation(Required=false)]
                    public string FuelType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2026-07-31 00:00:00</para>
                    /// </summary>
                    [NameInMap("InspectionDate")]
                    [Validation(Required=false)]
                    public string InspectionDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HQ7002BEV67</para>
                    /// </summary>
                    [NameInMap("ModelNum")]
                    [Validation(Required=false)]
                    public string ModelNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Power")]
                    [Validation(Required=false)]
                    public string Power { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2015-08-24 00:00:00</para>
                    /// </summary>
                    [NameInMap("RegistrationDate")]
                    [Validation(Required=false)]
                    public string RegistrationDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-08-13 00:00:00</para>
                    /// </summary>
                    [NameInMap("ReleaseDate")]
                    [Validation(Required=false)]
                    public string ReleaseDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2099-12-31 00:00:00</para>
                    /// </summary>
                    [NameInMap("RetirementDate")]
                    [Validation(Required=false)]
                    public string RetirementDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2350</para>
                    /// </summary>
                    [NameInMap("TotalMass")]
                    [Validation(Required=false)]
                    public string TotalMass { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1900</para>
                    /// </summary>
                    [NameInMap("UnladenMass")]
                    [Validation(Required=false)]
                    public string UnladenMass { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("UseProperty")]
                    [Validation(Required=false)]
                    public string UseProperty { get; set; }

                    [NameInMap("VehicleState")]
                    [Validation(Required=false)]
                    public string VehicleState { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LDC643T44G3667219</para>
                    /// </summary>
                    [NameInMap("Vin")]
                    [Validation(Required=false)]
                    public string Vin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2750</para>
                    /// </summary>
                    [NameInMap("WheelBase")]
                    [Validation(Required=false)]
                    public string WheelBase { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("ResponseJson")]
            [Validation(Required=false)]
            public string ResponseJson { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>207</para>
            /// </summary>
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("VehicleNum")]
            [Validation(Required=false)]
            public string VehicleNum { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5176EB42-6EE7-510B-9388-35018DF3175B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
